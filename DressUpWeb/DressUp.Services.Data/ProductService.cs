using DressUp.Data.Models;
using DressUp.Data.Models.Enums;
using DressUp.Services.Data.Interfaces;
using DressUp.Services.Data.Models.Product;
using DressUp.Web.Data;
using DressUp.Web.ViewModels.Product;
using DressUp.Web.ViewModels.Product.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Net;

namespace DressUp.Services.Data;

public class ProductService : IProductService
{
    private readonly DressUpDbContext dbContext;

    public ProductService(DressUpDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public IEnumerable<string> UploadImages(IEnumerable<IFormFile> files, SizeType sizeType)
    {
        ICollection<string> imagesUrl = new List<string>();

        foreach (IFormFile file in files)
        {
            if (file.Length > 0)
            {
                //Getting FileName
                string fileName = Path.GetFileName(file.FileName);

                //Getting file Extension
                string fileExtension = Path.GetExtension(fileName);

                string[] allowedFiledExtensions = new string[]
                {
                    ".jpg",
                    ".jpeg",
                    ".webpg",
                    ".png",
                    ".gif",
                };

                if (allowedFiledExtensions.Contains(fileExtension))
                {


                    //Assigning Unique Filename (Guid)
                    string myUniqueFileName = Guid.NewGuid().ToString();

                    // concatenating  FileName + FileExtension
                    string newFileName = String.Concat(myUniqueFileName, fileExtension);

                    string size = "Women";
                    if (sizeType == SizeType.Men)
                    {
                        size = "Men";
                    }
                    else if (sizeType == SizeType.Child)
                    {
                        size = "Child";
                    }

                    // Combines two strings into a path.
                    string filepath =
                        new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "DressPics", size)).Root + $@"\{newFileName}";

                    using (FileStream fs = File.Create(filepath))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                    }

                    filepath = filepath.Replace(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), "~");
                    filepath = filepath.Replace(@"\", @"/");
                    imagesUrl.Add(filepath);
                }
            }
        }

        return imagesUrl.ToArray();
    }

    public void DeleteImages(IEnumerable<string> ImagesUrls)
    {
        foreach (string imgUrl in ImagesUrls)
        {
            string imagePath = imgUrl;
            imagePath = imagePath.Replace("~", Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));
            imagePath = imagePath.Replace(@"/", @"\");
            File.Delete(imagePath);
        }
    }

    public async Task AddProductAsync(ProductFormModel model)
    {
        Product product = new()
        {
            Name = WebUtility.HtmlEncode(model.Name),
			Description = WebUtility.HtmlEncode(model.Description),
			BrandId = model.BrandId,
            CategoryId = model.CategoryId,
            SizeType = model.SizeType,
            Price = model.Price,
            Quantity = model.Quantity,
            ProductImages = model.Images
                .Select(i => new ProductImage
                {
                    ImageUrl = i.ImageUrl
                })
                .ToArray()
        };

        await dbContext.Products.AddAsync(product);
        await dbContext.SaveChangesAsync();
    }

    public async Task<AllProductsFilteredAndPagedServiceModel> AllAsync(AllProductsQueryModel queryModel)
    {
        IQueryable<Product> productsQuery = dbContext
            .Products
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(queryModel.Category))
        {
            productsQuery = productsQuery
                .Where(p => p.Category.Name == queryModel.Category);
        }

        if (!string.IsNullOrWhiteSpace(queryModel.Brand))
        {
            productsQuery = productsQuery
                .Where(p => p.Brand.Name == queryModel.Brand);
        }

        if (queryModel.SizeType != null)
        {
            productsQuery = productsQuery
                .Where(p => p.SizeType == queryModel.SizeType);
        }

        if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
        {
            string wildCard = $"%{queryModel.SearchString.ToLower()}%";
            productsQuery = productsQuery
                .Where(p => EF.Functions.Like(p.Name, wildCard) ||
                                  EF.Functions.Like(p.Description, wildCard) ||
                                  EF.Functions.Like(p.Brand.Name, wildCard) ||
                                  EF.Functions.Like(p.Category.Name, wildCard));
        }

        productsQuery = queryModel.ProductSorting switch
        {
            ProductSorting.Newest => productsQuery
                .OrderByDescending(p => p.AddedOn),
            ProductSorting.Oldest => productsQuery
                .OrderBy(p => p.AddedOn),
            ProductSorting.PriceDescending => productsQuery
                .OrderByDescending(p => p.Price),
            ProductSorting.PriceAscending => productsQuery
                .OrderBy(p => p.Price),
            ProductSorting.Favorites => productsQuery
                .OrderByDescending(p => p.Favorites.Count),
            ProductSorting.AvaliableQuantity => productsQuery
                .OrderByDescending(p => p.Quantity),
            _ => productsQuery
                .OrderByDescending(p => p.Quantity)
        };

        IEnumerable<AllProductsViewModel> allProducts = await productsQuery
            .Skip((queryModel.CurrentPage - 1) * queryModel.ProductsPerPage)
            .Take(queryModel.ProductsPerPage)
            .Select(p => new AllProductsViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Brand = p.Brand.Name,
                Category = p.Category.Name,
                Images = p.ProductImages
                    .Select(pi => new ProductImagesViewModel()
                    {
                        Id = pi.Id,
                        ImageUrl = pi.ImageUrl,
                    })
                    .ToList(),
                Price = p.Price,
                Quantity = p.Quantity,
            })
            .ToArrayAsync();

        int totalProducts = productsQuery.Count();

        return new AllProductsFilteredAndPagedServiceModel()
        {
            TotalProductsCount = totalProducts,
            Products = allProducts
        };
    }

    public async Task DeleteProductByIdAsync(int id)
    {
        Product product = await dbContext
            .Products
            .Include(p => p.ProductImages)
            .FirstAsync(p => p.Id == id);

        IEnumerable<string> imagesPath = product
            .ProductImages
            .Select(pi => pi.ImageUrl)
            .ToArray();

        dbContext.Products.Remove(product);
        await dbContext.SaveChangesAsync();

        DeleteImages(imagesPath);
    }

    public async Task EditProductAsync(ProductFormModel model, int id)
    {
        Product? product = await dbContext
            .Products
            .FindAsync(id);

        if (product == null)
        {
            return;
        }

        product.Name = WebUtility.HtmlEncode(model.Name);
        product.Description = WebUtility.HtmlEncode(model.Description);
        product.BrandId = model.BrandId;
        product.CategoryId = model.CategoryId;
        product.SizeType = model.SizeType;
        product.Price = model.Price;
        product.Quantity = model.Quantity;

        await dbContext.SaveChangesAsync();
    }

    public async Task<AllProductsViewModel[]> GetAllProductsAsync()
        => await dbContext.Products
        .AsNoTracking()
        .Select(p => new AllProductsViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Brand = p.Brand.Name,
            Category = p.Category.Name,
            Price = p.Price,
            Quantity = p.Quantity,
            Images = p.ProductImages
                .Select(pi => new ProductImagesViewModel()
                {
                    Id = pi.Id,
                    ImageUrl = pi.ImageUrl,
                })
                .ToList()
        })
        .ToArrayAsync();

    public IEnumerable<SizeType> GetAllSizeTypes()
    {
        SizeType[] sizeTypes =
        {
            SizeType.Men,
            SizeType.Women,
            SizeType.Child
        };

        return sizeTypes;
    }

    public async Task<AllProductsViewModel[]> GetMenProductsAsync()
        => await dbContext.Products
        .AsNoTracking()
        .Where(p => p.SizeType == SizeType.Men)
        .Select(p => new AllProductsViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Brand = p.Brand.Name,
            Category = p.Category.Name,
            Price = p.Price,
            Quantity = p.Quantity,
            Images = p.ProductImages
                .Select(pi => new ProductImagesViewModel()
                {
                    Id = pi.Id,
                    ImageUrl = pi.ImageUrl,
                })
                .ToList()
        })
        .ToArrayAsync();

    public async Task<ProductFormModel> GetProductByIdAsync(int id)
        => await dbContext
        .Products
        .Where(p => p.Id == id)
        .Select(p => new ProductFormModel()
        {
            Name = p.Name,
            Description = p.Description,
            BrandId = p.BrandId,
            CategoryId = p.CategoryId,
            SizeType = p.SizeType,
            Price = p.Price,
            Quantity = p.Quantity,
        })
        .FirstAsync();

    public async Task<ProductDetailsViewModel> GetProductDetailsByIdAsync(int id)
        => await dbContext
        .Products
        .AsNoTracking()
        .Where(p => p.Id == id)
        .Select(p => new ProductDetailsViewModel()
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Brand = p.Brand.Name,
            Category = p.Category.Name,
            SizeType = p.SizeType.ToString(),
            Price = p.Price,
            Images = p.ProductImages
                .Select(p => new ProductImagesViewModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                })
                .ToArray(),
            Quantity = p.Quantity,
        })
        .FirstAsync();

    public async Task<ProductPreDeleteDetails> GetProductPreDeleteDetailsByIdAsync(int id)
        => await dbContext
        .Products
        .AsNoTracking()
        .Where(p => p.Id == id)
        .Select(p => new ProductPreDeleteDetails()
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price,
            Quantity = p.Quantity,
            Images = p.ProductImages
                .Select(p => new ProductImagesViewModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                })
                .ToArray()
        })
        .FirstAsync();

    public async Task<bool> IsProductExistByIdAsync(int id)
    {
        Product? product = await dbContext
            .Products
            .FindAsync(id);

        if (product == null)
        {
            return false;
        }

        return true;
    }

    public async Task<bool> IsProductFavorite(string userId, int productId)
        => await dbContext
            .Favorites
            .AnyAsync(f => f.ProductId == productId
                                && f.UserId.ToString() == userId);



}