using UnityEngine;

public class GPaymnetManagerExample : MonoBehaviour
{
	private static bool _isInited;

	public const string ANDROID_TEST_PURCHASED = "android.test.Purchased";

	public const string ANDROID_TEST_CANCELED = "android.test.canceled";

	public const string ANDROID_TEST_REFUNDED = "android.test.refunded";

	public const string ANDROID_TEST_ITEM_UNAVAILABLE = "android.test.item_unavailable";

	public static bool isInited => false;

	public static void init()
	{
	}

	public static void Purchase(string SKU)
	{
	}

	public static void consume(string SKU)
	{
	}

	private static void OnProcessingPurchasedProduct(GooglePurchaseTemplate Purchase)
	{
	}

	private static void OnProcessingConsumeProduct(GooglePurchaseTemplate Purchase)
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
}
