using System;

namespace SA.IOSNative.UIKit
{
	internal static class Calendar
	{
		private static Action<DateTime> OnCalendarClosed;

		static Calendar()
		{
		}

		public static void PickDate(Action<DateTime> callback, int startFromYear = 0)
		{
		}

		internal static void DatePicked(string time)
		{
		}
	}
}
