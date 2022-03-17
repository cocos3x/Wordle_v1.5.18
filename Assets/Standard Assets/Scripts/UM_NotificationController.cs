using SA.Common.Pattern;
using System;

public class UM_NotificationController : Singleton<UM_NotificationController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__15_0(UM_PushRegistrationResult _003Cp0_003E)
		{
		}
	}

	private bool IsPushListnersRegistred;

	public static event Action<UM_PushRegistrationResult> OnPushIdLoadResult
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

	public void RetrieveDevicePushId()
	{
	}

	public void ShowNotificationPoup(string title, string messgae)
	{
	}

	public int ScheduleLocalNotification(string title, string message, int seconds)
	{
		return 0;
	}

	public void CancelLocalNotification(int id)
	{
	}

	public void CancelAllLocalNotifications()
	{
	}

	private void HandleActionCMDRegistrationResult(GP_GCM_RegistrationResult res)
	{
	}

	private void OnRegFailed()
	{
	}

	private void OnRegstred()
	{
	}

	private void IOSPushTokenReceived(ISN_RemoteNotificationsRegistrationResult res)
	{
	}
}
