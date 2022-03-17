public class WP8PurchseResponce
{
	private WP8PurchaseCodes _code;

	private string _transactionId;

	private string _productId;

	public bool IsSuccses => false;

	public string ProductId => "";

	public string TransactionId
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public WP8PurchseResponce(WP8PurchaseCodes code, string id)
	{
	}
}
