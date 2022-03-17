using SA.Common.Models;

public class AN_RefreshTokenResult : Result
{
	private string _accessToken;

	private string _refreshToken;

	private string _tokenType;

	private long _expiresIn;

	public string AccessToken => "";

	public string RefreshToken => "";

	public string TokenType => "";

	public long ExpiresIn => 0L;

	public AN_RefreshTokenResult(string errorMessage)
	{
	}

	public AN_RefreshTokenResult(string accessToken, string refreshToken, string tokenType, long expiresIn)
	{
	}
}
