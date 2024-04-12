using DressUp.Web.ViewModels.Product.Interfaces;

namespace DressUp.Web.Infrastructure.Extensions;

public static class ViewModelsExtensions
{
    public static string GetUrlInformation(this IProductDetailsModel model)
        => model.Name.Replace(" ", "-");
}
