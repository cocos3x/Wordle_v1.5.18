public class GooglePlayResult
{
	private GP_GamesStatusCodes _response;

	private string _message;

	public GP_GamesStatusCodes response => (GP_GamesStatusCodes)null;

	public GP_GamesStatusCodes Response => (GP_GamesStatusCodes)null;

	public string message => "";

	public string Message => "";

	public bool isSuccess => false;

	public bool IsSucceeded => false;

	public bool isFailure => false;

	public bool IsFailed => false;

	public GooglePlayResult(GP_GamesStatusCodes code)
	{
	}

	public GooglePlayResult(string code)
	{
	}

	private void SetCode(GP_GamesStatusCodes code)
	{
	}
}
