using SA.Common.Models;

public class ISN_RemoteNotificationsRegistrationResult : Result
{
	private ISN_DeviceToken _Token;

	public ISN_DeviceToken Token => null;

	public ISN_RemoteNotificationsRegistrationResult(ISN_DeviceToken token)
	{
	}

	public ISN_RemoteNotificationsRegistrationResult(Error error)
	{
	}
}
