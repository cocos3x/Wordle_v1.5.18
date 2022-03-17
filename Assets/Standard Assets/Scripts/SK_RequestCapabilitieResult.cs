using SA.Common.Models;

public class SK_RequestCapabilitieResult : Result
{
	private SK_CloudServiceCapability _Capability;

	public SK_CloudServiceCapability Capability => (SK_CloudServiceCapability)null;

	public SK_RequestCapabilitieResult(SK_CloudServiceCapability capability)
	{
	}

	public SK_RequestCapabilitieResult(string errorData)
	{
	}
}
