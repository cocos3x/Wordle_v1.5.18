using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace EnergyBarToolkit
{
	public class RepeatedUGUILastIconAnimator : MonoBehaviour
	{
		private sealed class _003CAnim_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RepeatedUGUILastIconAnimator _003C_003E4__this;

			private Image2 _003Cclone_003E5__2;

			private float _003CstartTime_003E5__3;

			private float _003CendTime_003E5__4;

			private MadiTween.EasingFunction _003CeasingFunction_003E5__5;

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
			public _003CAnim_003Ed__11(int _003C_003E1__state)
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

		public float animationTime;

		public float scaleFrom;

		public float scaleTo;

		public float alphaFrom;

		public float alphaTo;

		private MadiTween.EaseType scaleEaseType;

		private RepeatedRendererUGUI barRenderer;

		public MadiTween.EaseType easeType
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (MadiTween.EaseType)null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public IEnumerator Anim()
		{
			return null;
		}
	}
}
