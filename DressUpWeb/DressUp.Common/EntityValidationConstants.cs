namespace DressUp.Common;

public static class EntityValidationConstants
{
    public static class Brand
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 30;
    }

    public static class Card
    {
        public const int NumberMaxLength = 19;
        public const int CvcExactLength = 3;
    }

    public static class Category
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 35;
    }

    public static class City
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 85;
    }

    public static class Country
    {
        public const int NameMinLength = 2;
        public const int NameMaxLength = 85;
    }

    public static class Address
    {
        public const int StreetMinLength = 2;
        public const int StreetMaxLength = 100;
    }

    public static class Product
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 35;

        public const int DescriptionMinLength = 5;
        public const int DescriptionMaxLength = 500;

        //May be not string
        public const string PriceMinRange = "0.01";
        public const string PriceMaxRange = "1000.00";
    }

    public static class ProductImage
    {
        public const int ImageUrlMaxLength = 2048;
    }

    public static class Store
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 35;

        public const int ContactInfoMinLength = 10;
        public const int ContactInfoMaxLength = 80;

        public const int ImageUrlMaxLength = 2048;
    }

    public static class ProductReview
    {
        public const int TitleMinLength = 3;
        public const int TitleMaxLength = 35;

        public const int DescriptionMinLength = 10;
        public const int DescriptionMaxLength = 80;

        public const int RateMinRange = 1;
        public const int RateMaxRange = 10;
    }
}
