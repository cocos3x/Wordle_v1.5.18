using SA.Common.Models;

public class AN_AccessTokenResult : Result
{
	private string _accessToken;

	private string _tokenType;

	private long _expiresIn;

	public string AccessToken => "";

	public string TokenType => "";

	public long ExpiresIn => 0L;

	public AN_AccessTokenResult(string errorMessage)
	{
	}

	public AN_AccessTokenResult(string accessToken, string tokenType, long expiresIn)
	{
	}
}
