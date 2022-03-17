using SA.Common.Models;
using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class ISN_LocalNotificationsController : Singleton<ISN_LocalNotificationsController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__26_0(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__26_1(ISN_LocalNotification _003Cp0_003E)
		{
		}
	}

	private const string PP_KEY = "IOSNotificationControllerKey";

	private const string PP_ID_KEY = "IOSNotificationControllerrKey_ID";

	private ISN_LocalNotification _LaunchNotification;

	public static int AllowedNotificationsType => 0;

	public ISN_LocalNotification LaunchNotification => null;

	public static event Action<Result> OnNotificationScheduleResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<ISN_LocalNotification> OnLocalNotificationReceived
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

	public void RequestNotificationPermissions()
	{
	}

	public void ShowGmaeKitNotification(string title, string message)
	{
	}

	public void CancelAllLocalNotifications()
	{
	}

	public void CancelLocalNotification(ISN_LocalNotification notification)
	{
	}

	public void CancelLocalNotificationById(int notificationId)
	{
	}

	public void ScheduleNotification(ISN_LocalNotification notification)
	{
	}

	public List<ISN_LocalNotification> LoadPendingNotifications(bool includeAll = false)
	{
		return null;
	}

	public void ApplicationIconBadgeNumber(int badges)
	{
	}

	private void OnNotificationScheduleResultAction(string array)
	{
	}

	private void OnLocalNotificationReceived_Event(string array)
	{
	}

	private void SaveNotifications(List<ISN_LocalNotification> notifications)
	{
	}
}
