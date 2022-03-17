using System.Collections.Generic;

namespace QuickEngine.Extensions
{
	public static class DictionaryExtenstions
	{
		public static bool AddIfKeyNotPresent<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
		{
			return false;
		}

		public static void AddOrUpdate<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
		{
		}

		public static bool TryAddKey<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
		{
			return false;
		}
	}
}
