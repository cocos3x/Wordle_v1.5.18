public class WP8ConsumeResponse
{
	private WP8ConsumeCodes _code;

	private string _productId;

	private string _transactionId;

	public bool IsSucceeded => false;

	public string ProductID => "";

	public WP8ConsumeCodes Code => (WP8ConsumeCodes)null;

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

	public WP8ConsumeResponse(WP8ConsumeCodes code, string id)
	{
	}
}
