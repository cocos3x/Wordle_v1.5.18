using SA.Common.Models;
using SA.IOSNative.StoreKit;

public class PaymentManagerExample
{
	public const string SMALL_PACK = "your.product.id1.here";

	public const string NC_PACK = "your.product.id2.here";

	public string lastTransactionProdudctId;

	private static bool IsInitialized;

	public static void init()
	{
	}

	public static void buyItem(string productId)
	{
	}

	private static void UnlockProducts(string productIdentifier)
	{
	}

	private static void OnTransactionComplete(PurchaseResult result)
	{
	}

	private static void OnRestoreComplete(RestoreResult res)
	{
	}

	private static void HandleOnVerificationComplete(VerificationResponse response)
	{
	}

	private static void OnStoreKitInitComplete(Result result)
	{
	}
}
