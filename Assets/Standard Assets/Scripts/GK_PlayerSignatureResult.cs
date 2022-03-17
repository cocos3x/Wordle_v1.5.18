using SA.Common.Models;

public class GK_PlayerSignatureResult : Result
{
	public string _PublicKeyUrl;

	public byte[] _Signature;

	public byte[] _Salt;

	public long _Timestamp;

	public string PublicKeyUrl => "";

	public byte[] Signature => null;

	public byte[] Salt => null;

	public long Timestamp => 0L;

	public GK_PlayerSignatureResult(string publicKeyUrl, string signature, string salt, string timestamp)
	{
	}

	public GK_PlayerSignatureResult(Error errro)
	{
	}
}
