using System;

namespace SA.IOSNative.UIKit
{
	public static class DateTimePicker
	{
		private static event Action<DateTime> OnPickerClosed
		{
			add
			{
			}
			remove
			{
			}
		}

		private static event Action<DateTime> OnPickerDateChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		static DateTimePicker()
		{
		}

		public static void Show(DateTimePickerMode mode, Action<DateTime> callback)
		{
		}

		public static void Show(DateTimePickerMode mode, DateTime dateTime, Action<DateTime> callback)
		{
		}

		internal static void DateChangedEvent(string time)
		{
		}

		internal static void PickerClosed(string time)
		{
		}
	}
}
