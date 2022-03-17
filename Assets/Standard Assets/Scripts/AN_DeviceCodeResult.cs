using SA.Common.Models;

public class AN_DeviceCodeResult : Result
{
	private string _deviceCode;

	private string _userCode;

	private string _verificationUrl;

	private long _expiresIn;

	private long _interval;

	public string DeviceCode => "";

	public string UserCode => "";

	public string VerificationUrl => "";

	public long ExpiresIn => 0L;

	public long Interval => 0L;

	public AN_DeviceCodeResult(string errorMessage)
	{
	}

	public AN_DeviceCodeResult(string deviceCode, string userCode, string verificationUrl, long expiresIn, long interval)
	{
	}
}
