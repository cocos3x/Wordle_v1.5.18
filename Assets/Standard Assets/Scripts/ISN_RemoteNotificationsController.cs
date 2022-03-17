using SA.Common.Pattern;
using System;
using System.Runtime.InteropServices;

public class ISN_RemoteNotificationsController : Singleton<ISN_RemoteNotificationsController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__13_0(ISN_RemoteNotification _003Cp0_003E)
		{
		}
	}

	private static Action<ISN_RemoteNotificationsRegistrationResult> _RegistrationCallback;

	private ISN_RemoteNotification _LaunchNotification;

	public ISN_RemoteNotification LaunchNotification => null;

	public static event Action<ISN_RemoteNotification> OnRemoteNotificationReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void RegisterForRemoteNotifications([Optional] Action<ISN_RemoteNotificationsRegistrationResult> callback)
	{
	}

	private void DidFailToRegisterForRemoteNotifications(string errorData)
	{
	}

	private void DidRegisterForRemoteNotifications(string data)
	{
	}

	private void DidReceiveRemoteNotification(string notificationBody)
	{
	}
}
