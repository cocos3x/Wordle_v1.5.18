using SA.Common.Models;
using System;
using System.Collections.Generic;

namespace SA.IOSNative.UserNotifications
{
	public static class NotificationCenter
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			internal void _003C_002Ecctor_003Eb__6_0(NotificationRequest _003Cp0_003E)
			{
			}
		}

		private static Dictionary<string, Action<Result>> OnCallbackDictionary;

		private static Action<List<NotificationRequest>> OnPendingNotificationsCallback;

		private static Action<Result> RequestPermissionsCallback;

		public static NotificationRequest LastNotificationRequest;

		public static NotificationRequest LaunchNotification => null;

		public static event Action<NotificationRequest> OnWillPresentNotification
		{
			add
			{
			}
			remove
			{
			}
		}

		static NotificationCenter()
		{
		}

		public static void RequestPermissions(Action<Result> callback)
		{
		}

		public static void AddNotificationRequest(NotificationRequest request, Action<Result> callback)
		{
		}

		private static void ScheduleUserNotification(string notificationJSONData)
		{
		}

		public static void CancelAllNotifications()
		{
		}

		public static void CancelUserNotificationById(string nId)
		{
		}

		public static void GetPendingNotificationRequests(Action<List<NotificationRequest>> callback)
		{
		}

		internal static void RequestPermissionsResponse(string dataString)
		{
		}

		internal static void AddNotificationRequestResponse(string dataString)
		{
		}

		internal static void WillPresentNotification(string data)
		{
		}

		internal static void PendingNotificationsRequestResponse(string data)
		{
		}

		internal static void SetLastNotifification(string data)
		{
		}
	}
}
