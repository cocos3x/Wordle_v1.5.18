using UnityEngine;

public class WPN_BillingManagerExample : MonoBehaviour
{
	public const string YOUR_DURABLE_PRODUCT_ID_CONSTANT = "item2";

	public const string YOUR_CONSUMABLE_PRODUCT_ID_CONSTANT = "item1";

	private static bool _IsInited;

	public static string _status;

	public static bool IsInited => false;

	public static void Init()
	{
	}

	public static void Purchase(string productId)
	{
	}

	private static void HandleOnPurchaseFinished(WP8PurchseResponce responce)
	{
	}

	private static void HandleOnInitComplete(WP8_InAppsInitResult result)
	{
	}
}
