using System;

namespace DressUp.Web.ViewModels.Product;

using System.ComponentModel.DataAnnotations;

//using Enums;

//using static Common.GeneralApplicationConstants;

public class AllProductsQueryModel
{
    public AllProductsQueryModel()
    {
        //CurrentPage = DefaultPage;
        //HousesPerPage = EntitiesPerPage;

        //Categories = new HashSet<string>();
        Products = new HashSet<AllProductsViewModel>();
    }

    //public string? Category { get; set; }

    //[Display(Name = "Search by word")]
    //public string? SearchString { get; set; }

    //[Display(Name = "Sort Products By")]
    //public HouseSorting HouseSorting { get; set; }

    //public int CurrentPage { get; set; }

    //[Display(Name = "Show Products On Page")]
    //public int HousesPerPage { get; set; }

    //public int TotalHouses { get; set; }

    //public IEnumerable<string> Categories { get; set; }

    public IEnumerable<AllProductsViewModel> Products { get; set; }
}
