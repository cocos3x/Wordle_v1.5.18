using SA.Common.Pattern;
using System;

namespace SA.IOSNative.Gestures
{
	public class ForceTouch : Singleton<ForceTouch>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__21_0;

			public static Action _003C_003E9__21_1;

			public static Action<ForceInfo> _003C_003E9__21_2;

			public static Action<string> _003C_003E9__21_3;

			internal void _003C_002Ector_003Eb__21_0()
			{
			}

			internal void _003C_002Ector_003Eb__21_1()
			{
			}

			internal void _003C_002Ector_003Eb__21_2(ForceInfo _003Cp0_003E)
			{
			}

			internal void _003C_002Ector_003Eb__21_3(string _003Cp0_003E)
			{
			}
		}

		private static bool _IsTouchTrigerred;

		public static string AppOpenshortcutItem => "";

		public event Action OnForceTouchStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action OnForceTouchFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<ForceInfo> OnForceChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<string> OnAppShortcutClick
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

		public void Setup(float forceTouchDelay, float baseForceTouchPressure, float triggeringForceTouchPressure)
		{
		}

		private void didStartForce(string array)
		{
		}

		private void didForceChanged(string array)
		{
		}

		private void didForceEnded(string array)
		{
		}

		private void performActionForShortcutItem(string action)
		{
		}
	}
}
