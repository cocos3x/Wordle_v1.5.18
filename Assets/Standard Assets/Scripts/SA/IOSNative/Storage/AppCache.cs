using UnityEngine;

namespace SA.IOSNative.Storage
{
	public static class AppCache
	{
		public static void Save(string key, Texture2D texture)
		{
		}

		public static void Save(string key, byte[] data)
		{
		}

		public static void Save(string key, string value)
		{
		}

		public static Texture2D GetTexture(string key)
		{
			return null;
		}

		public static byte[] GetData(string key)
		{
			return null;
		}

		public static string GetString(string key)
		{
			return "";
		}

		public static void Remove(string key)
		{
		}
	}
}
