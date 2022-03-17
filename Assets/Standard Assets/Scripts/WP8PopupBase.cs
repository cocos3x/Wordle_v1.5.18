using System;
using UnityEngine;

public class WP8PopupBase : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<WP8DialogResult> _003C_003E9__3_0;

		internal void _003C_002Ector_003Eb__3_0(WP8DialogResult _003Cp0_003E)
		{
		}
	}

	public string title;

	public string message;

	public Action<WP8DialogResult> OnComplete;
}
