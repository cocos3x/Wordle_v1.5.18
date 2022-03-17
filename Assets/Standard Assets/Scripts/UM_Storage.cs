using UnityEngine;

public static class UM_Storage
{
	public static void Save(string key, string data)
	{
	}

	public static void Save(string key, Texture2D texture)
	{
	}

	public static void Save(string key, byte[] data)
	{
	}

	public static string GetString(string key)
	{
		return "";
	}

	public static Texture2D GetTexture(string key)
	{
		return null;
	}

	public static byte[] GetData(string key)
	{
		return null;
	}
}
