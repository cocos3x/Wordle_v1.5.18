using System.Collections.Generic;

namespace SA.IOSNative.UserNotifications
{
	public abstract class NotificationTrigger
	{
		public bool repeated;

		public string Type => "";

		public static NotificationTrigger triggerFromDictionary(Dictionary<string, object> triggerDictionary)
		{
			return null;
		}

		public void SetRepeat(bool repeats)
		{
		}
	}
}
