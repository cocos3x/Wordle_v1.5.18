using SA.Common.Models;

public class GP_AdvertisingIdLoadResult : Result
{
	public string id;

	public bool isLimitAdTrackingEnabled;

	public GP_AdvertisingIdLoadResult()
	{
	}

	public GP_AdvertisingIdLoadResult(Error error)
	{
	}
}
