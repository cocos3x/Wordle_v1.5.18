using SA.Common.Models;
using SA.Common.Pattern;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class IOSSocialManager : Singleton<IOSSocialManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<TextMessageComposeResult> _003C_003E9__37_0;

		internal void _003COnTextMessageComposeResult_003Eb__37_0(TextMessageComposeResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__47_0()
		{
		}

		internal void _003C_002Ecctor_003Eb__47_1()
		{
		}

		internal void _003C_002Ecctor_003Eb__47_2()
		{
		}

		internal void _003C_002Ecctor_003Eb__47_3(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__47_4(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__47_5(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__47_6(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__47_7(TextMessageComposeResult _003Cp0_003E)
		{
		}
	}

	public static event Action OnFacebookPostStart
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnTwitterPostStart
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnInstagramPostStart
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnFacebookPostResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnTwitterPostResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnInstagramPostResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnMailResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<TextMessageComposeResult> OnTextMessageResult
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void ShareMedia(string text, [Optional] Texture2D texture)
	{
	}

	public void TwitterPost(string text, [Optional] string url, [Optional] Texture2D texture)
	{
	}

	public void TwitterPostGif(string text, string url)
	{
	}

	public void FacebookPost(string text, [Optional] string url, [Optional] Texture2D texture)
	{
	}

	public void InstagramPost(Texture2D texture)
	{
	}

	public void InstagramPost(Texture2D texture, string message)
	{
	}

	public void WhatsAppShareText(string message)
	{
	}

	public void WhatsAppShareImage(Texture2D texture)
	{
	}

	public void SendMail(string subject, string body, string recipients)
	{
	}

	public void SendMail(string subject, string body, string recipients, Texture2D texture)
	{
	}

	public void SendTextMessage(string body, string recepient, Action<TextMessageComposeResult> callback)
	{
	}

	public void SendTextMessage(string body, List<string> recepients, Action<TextMessageComposeResult> callback)
	{
	}

	private void OnTextMessageComposeResult(string data)
	{
	}

	private void OnTwitterPostFailed()
	{
	}

	private void OnTwitterPostSuccess()
	{
	}

	private void OnFacebookPostFailed()
	{
	}

	private void OnFacebookPostSuccess()
	{
	}

	private void OnMailFailed()
	{
	}

	private void OnMailSuccess()
	{
	}

	private void OnInstaPostSuccess()
	{
	}

	private void OnInstaPostFailed(string data)
	{
	}
}
