using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class levelProgressScript : MonoBehaviour
{
	private sealed class _003CInitialize_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public levelProgressScript _003C_003E4__this;

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
		public _003CInitialize_003Ed__20(int _003C_003E1__state)
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

	private sealed class _003CsetPercentage_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public levelProgressScript _003C_003E4__this;

		public int percentage;

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
		public _003CsetPercentage_003Ed__21(int _003C_003E1__state)
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

	private sealed class _003CPlayFireworks_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public levelProgressScript _003C_003E4__this;

		public int loops;

		private int _003Cidx_003E5__2;

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
		public _003CPlayFireworks_003Ed__23(int _003C_003E1__state)
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

	public EnergyBar progress;

	public TextMeshProUGUI percentage;

	private int numberOfStages;

	private int percntg;

	private int currPerc;

	public ParticleSystem FireWorkA1;

	public ParticleSystem FireWorkA2;

	public ParticleSystem FireWorkB1;

	public ParticleSystem FireWorkB2;

	public ParticleSystem FireWorkC1;

	public ParticleSystem FireWorkC2;

	public ParticleSystem FireWorkD1;

	public ParticleSystem FireWorkD2;

	public AudioClip FireWorkBangSparkle;

	public AudioClip FireWorkLaunch1;

	public AudioClip FireWorkLaunch2;

	public AudioClip Cheer1;

	public AudioClip Cheer2;

	private void Start()
	{
	}

	public void ReInitialize()
	{
	}

	private IEnumerator Initialize()
	{
		return null;
	}

	private IEnumerator setPercentage(int percentage)
	{
		return null;
	}

	private void PlayCheer()
	{
	}

	private IEnumerator PlayFireworks(int loops)
	{
		return null;
	}

	private void Update()
	{
	}
}
