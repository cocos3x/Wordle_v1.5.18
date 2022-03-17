using SA.Common.Pattern;
using System;

public class ISN_GestureRecognizer : Singleton<ISN_GestureRecognizer>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<ISN_SwipeDirection> _003C_003E9__5_0;

		internal void _003C_002Ector_003Eb__5_0(ISN_SwipeDirection _003Cp0_003E)
		{
		}
	}

	public event Action<ISN_SwipeDirection> OnSwipe
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

	private void OnSwipeAction(string data)
	{
	}
}
