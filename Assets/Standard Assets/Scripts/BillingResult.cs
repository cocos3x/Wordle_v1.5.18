public class BillingResult
{
	private int _response;

	private string _message;

	private GooglePurchaseTemplate _purchase;

	public GooglePurchaseTemplate purchase => null;

	public GooglePurchaseTemplate Purchase => null;

	public int response => 0;

	public int Response => 0;

	public string message => "";

	public string Message => "";

	public bool isSuccess => false;

	public bool IsSuccess => false;

	public bool isFailure => false;

	public bool IsFailure => false;

	public BillingResult(int code, string msg, GooglePurchaseTemplate p)
	{
	}

	public BillingResult(int code, string msg)
	{
	}
}
