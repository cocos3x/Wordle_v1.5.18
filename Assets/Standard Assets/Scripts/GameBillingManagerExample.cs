using UnityEngine;

public class GameBillingManagerExample : MonoBehaviour
{
	private static bool _isInited;

	public const string COINS_ITEM = "small_coins_bag";

	public const string COINS_BOOST = "coins_bonus";

	private static bool ListnersAdded;

	public static bool isInited => false;

	public static void init()
	{
	}

	public static void purchase(string SKU)
	{
	}

	public static void consume(string SKU)
	{
	}

	private static void OnProcessingPurchasedProduct(GooglePurchaseTemplate purchase)
	{
	}

	private static void OnProcessingConsumeProduct(GooglePurchaseTemplate purchase)
	{
	}

	private static void OnProductPurchased(BillingResult result)
	{
	}

	private static void OnProductConsumed(BillingResult result)
	{
	}

	private static void OnBillingConnected(BillingResult result)
	{
	}

	private static void OnRetrieveProductsFinised(BillingResult result)
	{
	}

	private static void UpdateStoreData()
	{
	}
}
