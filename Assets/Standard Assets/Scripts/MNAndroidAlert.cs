using System;
using System.Collections.Generic;
using UnityEngine;

public class MNAndroidAlert : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__7_0;

		internal void _003C_002Ector_003Eb__7_0(string _003Cp0_003E)
		{
		}
	}

	private string title;

	private string message;

	private IEnumerable<string> actions;

	public Action<string> OnComplete;

	public static MNAndroidAlert Create(string title, string message, IEnumerable<string> actions)
	{
		return null;
	}

	public void Show()
	{
	}

	public void onPopUpCallBack(string result)
	{
	}
}
