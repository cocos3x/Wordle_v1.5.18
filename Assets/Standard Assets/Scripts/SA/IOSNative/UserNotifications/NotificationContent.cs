using System.Collections.Generic;

namespace SA.IOSNative.UserNotifications
{
	public class NotificationContent
	{
		public string Title;

		public string Subtitle;

		public string Body;

		public string Sound;

		public int Badge;

		public string LaunchImageName;

		public Dictionary<string, object> UserInfo;

		public NotificationContent()
		{
		}

		public NotificationContent(Dictionary<string, object> contentDictionary)
		{
		}

		public override string ToString()
		{
			return "";
		}
	}
}
