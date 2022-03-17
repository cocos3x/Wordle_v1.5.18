using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AndroidSocialGate : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__24_0(bool _003Cp0_003E, string _003Cp1_003E)
		{
		}
	}

	private static AndroidSocialGate _Instance;

	private static string s_message;

	private static string s_caption;

	public static event Action<bool, string> OnShareIntentCallback
	{
		add
		{
		}
		remove
		{
		}
	}

	public static void StartGooglePlusShare(string text, [Optional] Texture2D texture)
	{
	}

	public static void StartVideoPickerAndShareIntent(string message, string caption)
	{
	}

	private static void OnVideoPickedHandler(AndroidVideoPickResult result)
	{
	}

	public static void StartVideoShareIntent(string videoFilePath, string message, string caption)
	{
	}

	public static void StartShareIntent(string caption, string message, string packageNamePattern = "")
	{
	}

	public static void StartShareIntent(string caption, string message, Texture2D texture, string packageNamePattern = "")
	{
	}

	public static void StartShareIntent(string caption, string message, Texture2D[] textures, string packageNamePattern = "")
	{
	}

	public static void StartShareIntentWithSubject(string caption, string message, string subject, Texture2D[] textures, string packageNamePattern = "")
	{
	}

	public static void StartShareIntentWithSubject(string caption, string message, string subject, string packageNamePattern = "")
	{
	}

	public static void StartShareIntentWithSubject(string caption, string message, string subject, Texture2D texture, string packageNamePattern = "")
	{
	}

	public static void SendMail(string caption, string message, string subject, string recipients, Texture2D[] textures)
	{
	}

	public static void SendMail(string caption, string message, string subject, string recipients, [Optional] Texture2D texture)
	{
	}

	public static void ShareTwitterGif(string gifPath, string message)
	{
	}

	public static void SendTextMessage(string body, string recepient)
	{
	}

	public static void SendTextMessage(string body, List<string> recipients)
	{
	}

	private static void CheckAndCreateInstance()
	{
	}

	private void ShareCallback(string data)
	{
	}
}
