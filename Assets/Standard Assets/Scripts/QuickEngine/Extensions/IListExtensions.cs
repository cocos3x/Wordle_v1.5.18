using System.Collections.Generic;

namespace QuickEngine.Extensions
{
	public static class IListExtensions
	{
		public static bool IsNullOrEmpty<T>(this IList<T> items)
		{
			return false;
		}

		public static bool NotNullOrEmpty<T>(this IList<T> items)
		{
			return false;
		}

		public static void Shuffle<T>(this IList<T> list)
		{
		}
	}
}
