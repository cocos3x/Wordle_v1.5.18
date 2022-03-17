using System.Collections.Generic;

public class UM_InAppPurchaseManager
{
	private const string PREFS_KEY = "UM_InAppPurchaseManager";

	public static UM_InAppClient _Client;

	public static UM_InAppClient Instance => null;

	public static UM_InAppClient instance => null;

	public static UM_InAppClient Client => null;

	public static List<UM_InAppProduct> InAppProducts => null;

	public static UM_InAppProduct GetProductById(string id)
	{
		return null;
	}

	public static UM_InAppProduct GetProductByIOSId(string id)
	{
		return null;
	}

	public static UM_InAppProduct GetProductByAndroidId(string id)
	{
		return null;
	}

	public static UM_InAppProduct GetProductByAmazonId(string id)
	{
		return null;
	}

	public static UM_InAppProduct GetProductByWp8Id(string id)
	{
		return null;
	}

	public static bool IsLocalPurchaseRecordExists(UM_InAppProduct product)
	{
		return false;
	}

	public static bool IsLocalPurchaseRecordExists(string productId)
	{
		return false;
	}

	public static void SaveNonConsumableItemPurchaseInfo(UM_InAppProduct product)
	{
	}

	public static void UpdatePlatfromsInAppSettings()
	{
	}

	private static void AddToANSettings(UM_InAppProduct prod)
	{
	}

	private static void AddToISNSettings(UM_InAppProduct prod)
	{
	}

	private static void AddToAMMSettings(UM_InAppProduct prod)
	{
	}

	private static void ClientPurchaseFinishedHadnler(UM_PurchaseResult result)
	{
	}
}
