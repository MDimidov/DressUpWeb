namespace DressUp.Web.ViewModels.Product;

public class ProductPreDeleteDetails
{
    public ProductPreDeleteDetails()
    {
        Images = new List<ProductImagesViewModel>();
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public IEnumerable<ProductImagesViewModel> Images { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}
