using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

namespace SIS
{
	public class VRSelectionRadial : MonoBehaviour
	{
		private sealed class _003CFillSelectionRadial_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VRSelectionRadial _003C_003E4__this;

			private float _003Ctimer_003E5__2;

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
			public _003CFillSelectionRadial_003Ed__11(int _003C_003E1__state)
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

		[SerializeField]
		private float m_SelectionDuration;

		[SerializeField]
		private bool m_HideOnStart;

		[SerializeField]
		private Image m_Selection;

		[SerializeField]
		private VRInput m_VRInput;

		[SerializeField]
		private VREyeRaycaster m_VREyeRaycaster;

		private Coroutine m_SelectionFillRoutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private IEnumerator FillSelectionRadial()
		{
			return null;
		}

		private void HandleDown()
		{
		}

		private void HandleUp()
		{
		}
	}
}
