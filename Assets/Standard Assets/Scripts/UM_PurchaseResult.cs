using SA.IOSNative.StoreKit;

public class UM_PurchaseResult
{
	public bool isSuccess;

	public UM_InAppProduct product;

	private int _ResponceCode;

	private string EditorDummyId;

	public GooglePurchaseTemplate Google_PurchaseInfo;

	public PurchaseResult IOS_PurchaseInfo;

	public WP8PurchseResponce WP8_PurchaseInfo;

	public AMN_PurchaseResponse Amazon_PurchaseInfo;

	public string TransactionId => "";

	public int ResponceCode => 0;

	public void SetResponceCode(int code)
	{
	}
}
