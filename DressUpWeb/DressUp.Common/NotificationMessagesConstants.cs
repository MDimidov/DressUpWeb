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
		public const string AdminOrModeratorToEdit = "To edit this product you must be Administrator or Moderator";
		public const string AdminOrModeratorToEditStore = "To edit this store you must be Administrator or Moderator";
		public const string AdminOrModeratorToAddProduct = "To add the product you must be Administrator or Moderator";
		public const string AdminOrModeratorToAddStore = "To add the store you must be Administrator or Moderator";
		public const string AdminOrModeratorToDelete = "To delete this product you must be Administrator or Moderator";
		public const string ProductDoesNotExist = "The product with given Id does not exist";
		public const string StoreDoesNotExist = "The store with given Id does not exist";
		public const string CityDoesNotExist = "The city with given Id does not exist";
		public const string CountryDoesNotExist = "The country with given Id does not exist";
		public const string LogInError = "There was an error while logging you in! Please try again later or contact an administrator.";
		public const string AlreadyLogedIn = "You are logged in!";
		public const string AlreadyRegistered = "You are registered!";
		public const string RoleDoesNotExist = "Role {0} does not exist";
		public const string RoleAlreadyExist = "Role {0} already exist!";
		public const string UserDoesNotExist = "User with e-mail: {0} does not exist";
		public const string UserAlreadyHasARole = "User {0} already has a role {1}!";
		public const string UserDoesNotHaveARole = "User {0} does not have a role {1}!";
		public const string UnexpextedError = "Unexpected error occurred! Please try again later or contact administrator";
	}

	public static class WarningMessages
	{
		public const string ProductDeletedSuccessfuly = "The product was deleted successfuly";
		public const string DeletedStore = "The store was deleted successfully";

	}

	public static class InformationMessages
	{
		public const string DeletedRole = "The role {0} was deleted successfully";
		public const string RemovedUserFromRole = "You removed successfully user {0}, from role {1}";
	}

	public static class SuccessMessages
	{
		public const string AddedToFavorite = "You added successfully this product to Favorite";
		public const string RemovedFromFavorite = "You removed successfully product from Favorite";
		public const string AddedProduct = "You added successfully this product to our collection";
		public const string EditedProduct = "You edited successfully this product";
		public const string EditedStore = "You edited {0} store successfully";
		public const string AddedUserToRole = "You added successfully user {0}, to role {1}";
		public const string CreatedRole = "You created successfully rele {0}";
		public const string AddedStore = "You added successfully this store to our collection";
	}
}
