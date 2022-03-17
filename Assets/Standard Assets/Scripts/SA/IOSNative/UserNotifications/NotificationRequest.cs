namespace SA.IOSNative.UserNotifications
{
	public class NotificationRequest
	{
		private string _Id;

		private NotificationContent _Content;

		private NotificationTrigger _Trigger;

		public string Id => "";

		public NotificationContent Content => null;

		public NotificationTrigger Trigger => null;

		public NotificationRequest()
		{
		}

		public NotificationRequest(string id, NotificationContent content, NotificationTrigger trigger)
		{
		}

		public NotificationRequest(string data)
		{
		}
	}
}
