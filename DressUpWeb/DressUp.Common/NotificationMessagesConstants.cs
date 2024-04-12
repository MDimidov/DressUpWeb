namespace DressUp.Common;

public static class NotificationMessagesConstants
{
    public const string ErrorMessage = "ErrorMessage";

    public const string WarningMessage = "WarnMessage";

    public const string InformationMessage = "InfoMessage";

    public const string SuccessMessage = "SuccessMessage";

    public static class ErrorMessages
    {
        public const string AlreadyAddedToFavorite = "You already added this product to Favorite";
        public const string YouMustLogedInToAddFavorite = "You must be Loged In User to add Products to Favorite";
        public const string YouMustLogedInToRemoveFavorite = "You must be Loged In User to remove Products from Favorite";
        public const string YouMustLogedInToSeeFavorite = "You must be Loged In User to see your Favorite Products";
        public const string InvalidProductToFavorite = "This product does not exist, plese add to Favorite avaliable product";
        public const string InvalidProductToRemoveFromFavorite = "This product does not exist in your Favorites list";
        public const string LogInToOrder = "To order this product you must be Loged In";
        public const string LogInToEdit = "To edit this product you must be Loged In";
        public const string LogInToAdd = "To add the product you must be Loged In";
        public const string LogInToDelete = "To delete this product you must be Loged In";
        public const string ProductDoesNotExist = "The product with given Id does not exist";
    }

    public static class WarningMessages
    {
        public const string ProductDeletedSuccessfuly = "The product was deleted successfuly";

    }

    public static class InformationMessages
    {

    }

    public static class SuccessMessages
    {
        public const string AddedToFavorite = "You added successfully this product to Favorite";
        public const string RemovedFromFavorite = "You removed successfully product from Favorite";
        public const string AddedProduct = "You added successfully this product to our collection";
        public const string EditedProduct = "You edited successfully this product";
    }
}
