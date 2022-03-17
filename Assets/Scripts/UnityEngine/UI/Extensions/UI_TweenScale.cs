using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.UI.Extensions
{
	public class UI_TweenScale : MonoBehaviour
	{
		private sealed class _003CTween_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UI_TweenScale _003C_003E4__this;

			private float _003Ct_003E5__2;

			private float _003CmaxT_003E5__3;

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
			public _003CTween_003Ed__11(int _003C_003E1__state)
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

		public AnimationCurve animCurve;

		public float speed;

		public bool isLoop;

		public bool playAtAwake;

		public bool isUniform;

		public AnimationCurve animCurveY;

		private Vector3 initScale;

		private Transform myTransform;

		private Vector3 newScale;

		private void Awake()
		{
		}

		public void Play()
		{
		}

		private IEnumerator Tween()
		{
			return null;
		}

		public void ResetTween()
		{
		}
	}
}
