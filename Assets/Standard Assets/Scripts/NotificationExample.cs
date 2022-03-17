using SA.Common.Models;
using SA.IOSNative.UserNotifications;
using System;
using System.Collections.Generic;

public class NotificationExample : BaseIOSFeaturePreview
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<NotificationRequest> _003C_003E9__1_0;

		public static Action<ISN_RemoteNotificationsRegistrationResult> _003C_003E9__2_0;

		public static Action<Result> _003C_003E9__2_1;

		public static Action<Result> _003C_003E9__2_3;

		public static Action<Result> _003C_003E9__2_4;

		public static Action<Result> _003C_003E9__2_5;

		public static Action<List<NotificationRequest>> _003C_003E9__2_2;

		internal void _003CAwake_003Eb__1_0(NotificationRequest obj)
		{
		}

		internal void _003COnGUI_003Eb__2_0(ISN_RemoteNotificationsRegistrationResult res)
		{
		}

		internal void _003COnGUI_003Eb__2_1(Result result)
		{
		}

		internal void _003COnGUI_003Eb__2_3(Result result)
		{
		}

		internal void _003COnGUI_003Eb__2_4(Result result)
		{
		}

		internal void _003COnGUI_003Eb__2_5(Result result)
		{
		}

		internal void _003COnGUI_003Eb__2_2(List<NotificationRequest> requests)
		{
		}
	}

	private int lastNotificationId;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	public void CheckNotificationSettings()
	{
	}

	private void HandleOnLocalNotificationReceived(ISN_LocalNotification notification)
	{
	}

	private void OnNotificationScheduleResult(Result res)
	{
	}
}
