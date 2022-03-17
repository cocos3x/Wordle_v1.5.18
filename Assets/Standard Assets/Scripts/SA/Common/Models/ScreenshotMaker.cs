using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace SA.Common.Models
{
	public class ScreenshotMaker : MonoBehaviour
	{
		private sealed class _003CSaveScreenshot_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ScreenshotMaker _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSaveScreenshot_003Ed__4(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<Texture2D> _003C_003E9__5_0;

			internal void _003C_002Ector_003Eb__5_0(Texture2D _003Cp0_003E)
			{
			}
		}

		public Action<Texture2D> OnScreenshotReady;

		public static ScreenshotMaker Create()
		{
			return null;
		}

		private void Awake()
		{
		}

		public void GetScreenshot()
		{
		}

		private IEnumerator SaveScreenshot()
		{
			return null;
		}
	}
}
