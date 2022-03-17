public class AN_LicenseRequestResult
{
	private AN_LicenseStatusCode _status;

	private AN_LicenseErrorCode _error;

	public AN_LicenseStatusCode Status => (AN_LicenseStatusCode)null;

	public AN_LicenseErrorCode Error => (AN_LicenseErrorCode)null;

	private AN_LicenseRequestResult()
	{
	}

	public AN_LicenseRequestResult(AN_LicenseStatusCode status, AN_LicenseErrorCode error = AN_LicenseErrorCode.ERROR_NONE)
	{
	}
}
