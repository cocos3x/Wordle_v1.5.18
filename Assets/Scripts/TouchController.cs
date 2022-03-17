using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TouchController : MonoBehaviour
{
	private sealed class _003CResetShakeProperties_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TouchController _003C_003E4__this;

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
		public _003CResetShakeProperties_003Ed__15(int _003C_003E1__state)
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

	private float accelerometerUpdateInterval;

	private float lowPassKernelWidthInSeconds;

	private float shakeDetectionThreshold;

	private float lowPassFilterFactor;

	private Vector3 lowPassValue;

	private Vector3 acceleration;

	private Vector3 deltaAcceleration;

	public List<GameObject> shakeDetectionReceivers;

	public List<GameObject> touchEndedReceivers;

	private int shakeCount;

	private float lastShake;

	public GameObject pointerPrefab;

	public GameObject pointer;

	public Transform pointerParent;

	private void Start()
	{
	}

	private IEnumerator ResetShakeProperties()
	{
		return null;
	}

	private void Update()
	{
	}
}
