public class FB_LoginResult : FB_Result
{
	private bool _IsCanceled;

	private string _UserId;

	private string _AccessToken;

	public string UserId => "";

	public string AccessToken => "";

	public bool IsCanceled => false;

	public FB_LoginResult(string RawData, string Error, bool isCanceled)
	{
	}

	public void SetCredential(string userId, string accessToken)
	{
	}
}
