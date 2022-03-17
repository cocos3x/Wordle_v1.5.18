using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class AndroidNotificationManager : Singleton<AndroidNotificationManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<int> _003C_003E9__20_0;

		internal void _003C_002Ector_003Eb__20_0(int _003Cp0_003E)
		{
		}
	}

	public const int LENGTH_SHORT = 0;

	public const int LENGTH_LONG = 1;

	public Action<int> OnNotificationIdLoaded;

	private const string PP_KEY = "AndroidNotificationManagerKey";

	private const string PP_ID_KEY = "AndroidNotificationManagerKey_ID";

	private const string DATA_SPLITTER = "|";

	public int GetNextId => 0;

	private void Awake()
	{
	}

	public void LocadAppLaunchNotificationId()
	{
	}

	public void HideAllNotifications()
	{
	}

	public void ShowToastNotification(string text)
	{
	}

	public void ShowToastNotification(string text, int duration)
	{
	}

	public int ScheduleLocalNotification(string title, string message, int seconds)
	{
		return 0;
	}

	public int ScheduleLocalNotification(AndroidNotificationBuilder builder)
	{
		return 0;
	}

	public void CancelLocalNotification(int id, bool clearFromPrefs = true)
	{
	}

	public void CancelAllLocalNotifications()
	{
	}

	private void OnNotificationIdLoadedEvent(string data)
	{
	}

	private void SaveNotifications(List<LocalNotificationTemplate> notifications)
	{
	}

	public List<LocalNotificationTemplate> LoadPendingNotifications(bool includeAll = false)
	{
		return null;
	}
}
