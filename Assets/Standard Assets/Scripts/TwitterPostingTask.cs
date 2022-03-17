using System;
using UnityEngine;

public class TwitterPostingTask : AsyncTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<TWResult> _003C_003E9__11_0;

		internal void _003C_002Ector_003Eb__11_0(TWResult _003Cp0_003E)
		{
		}
	}

	private string _status;

	private Texture2D _texture;

	private TwitterManagerInterface _controller;

	public event Action<TWResult> ActionComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public static TwitterPostingTask Cretae()
	{
		return null;
	}

	public void Post(string status, Texture2D texture, TwitterManagerInterface controller)
	{
	}

	private void OnTWInited(TWResult result)
	{
	}

	private void OnTWAuth(TWResult result)
	{
	}

	private void OnPost(TWResult res)
	{
	}
}
