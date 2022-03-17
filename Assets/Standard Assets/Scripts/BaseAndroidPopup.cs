using System;
using UnityEngine;

public class BaseAndroidPopup : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<AndroidDialogResult> _003C_003E9__7_0;

		internal void _003C_002Ector_003Eb__7_0(AndroidDialogResult _003Cp0_003E)
		{
		}
	}

	public string title;

	public string message;

	public event Action<AndroidDialogResult> ActionComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public void onDismissed(string data)
	{
	}

	protected void DispatchAction(AndroidDialogResult res)
	{
	}
}
