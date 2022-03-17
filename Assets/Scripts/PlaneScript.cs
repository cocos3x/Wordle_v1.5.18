using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
	private sealed class _003CResizeCollider_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlaneScript _003C_003E4__this;

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
		public _003CResizeCollider_003Ed__7(int _003C_003E1__state)
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

	public BoxCollider backgroundColl;

	public RectTransform LeftSpawnObject;

	public RectTransform RightSpawnObject;

	public RectTransform planeTransform;

	public RectTransform background;

	public RectTransform columns;

	private void Start()
	{
	}

	private IEnumerator ResizeCollider()
	{
		return null;
	}

	private void OnTouchBegin()
	{
	}

	private void OnTouchEnd()
	{
	}

	private void OnTouchOver()
	{
	}
}
