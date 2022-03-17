public class AndroidActivityResult
{
	protected AdroidActivityResultCodes _code;

	protected int _requestId;

	public AdroidActivityResultCodes code => (AdroidActivityResultCodes)null;

	public int requestId => 0;

	public bool IsSucceeded => false;

	public bool IsFailed => false;

	public AndroidActivityResult(string rId, string codeString)
	{
	}
}
