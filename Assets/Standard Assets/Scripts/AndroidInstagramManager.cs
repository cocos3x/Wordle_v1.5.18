using SA.Common.Pattern;
using System;
using UnityEngine;

public class AndroidInstagramManager : Singleton<AndroidInstagramManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__8_0(InstagramPostResult _003Cp0_003E)
		{
		}
	}

	public static event Action<InstagramPostResult> OnPostingCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public void Share(Texture2D texture)
	{
	}

	public void Share(Texture2D texture, string message)
	{
	}

	private void OnPostSuccess()
	{
	}

	private void OnPostFailed(string data)
	{
	}
}
