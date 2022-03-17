using SA.Common.Models;

public class AN_PackageCheckResult : Result
{
	private string _packageName;

	public string packageName => "";

	public AN_PackageCheckResult(string packId)
	{
	}

	public AN_PackageCheckResult(string packId, Error error)
	{
	}
}
