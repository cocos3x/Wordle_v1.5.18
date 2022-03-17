using System.Collections.Generic;

namespace QuickEngine.Extensions
{
	public static class ArrayAndListExtensions
	{
		public static bool IsNullOrEmpty<T>(this T[] array)
		{
			return false;
		}

		public static bool IsNullOrEmpty<T>(this List<T> list)
		{
			return false;
		}

		public static bool IsNullOrEmpty<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			return false;
		}

		public static T GetRandomElement<T>(this T[] array)
		{
			return (T)null;
		}

		public static T GetRandomElement<T>(this List<T> list)
		{
			return (T)null;
		}

		public static void ShuffleArray<T>(this T[] array)
		{
		}

		public static void ShuffleList<T>(this List<T> list)
		{
		}

		public static string ToString<T>(this T[] array, string separator)
		{
			return "";
		}

		public static string ToString<T>(this List<T> list, string separator)
		{
			return "";
		}
	}
}
