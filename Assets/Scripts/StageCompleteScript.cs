using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class StageCompleteScript : MonoBehaviour
{
	private sealed class _003CUpdateDisplay_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageCompleteScript _003C_003E4__this;

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
		public _003CUpdateDisplay_003Ed__36(int _003C_003E1__state)
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

	private sealed class _003CShowNextLevel_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CShowNextLevel_003Ed__38(int _003C_003E1__state)
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

	private sealed class _003CPlayCheering_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageCompleteScript _003C_003E4__this;

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
		public _003CPlayCheering_003Ed__41(int _003C_003E1__state)
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

	private sealed class _003CPlayFireworks_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StageCompleteScript _003C_003E4__this;

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
		public _003CPlayFireworks_003Ed__42(int _003C_003E1__state)
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

	public TextMeshProUGUI StageTitle;

	public TextMeshProUGUI hintsCountText;

	public TextMeshProUGUI wordsFoundText;

	public GameObject hintsCollect;

	public GameObject hintsCollectQty;

	public GameObject hintsContinue;

	public GameObject hintsImage;

	public TextMeshProUGUI hintsCollectQtyText;

	public TextMeshProUGUI CurrentLevelText;

	public TextMeshProUGUI CurrentLevelDescText;

	public TextMeshProUGUI NextLevelText;

	public TextMeshProUGUI NextLevelDescText;

	public EnergyBar wordsFoundBar;

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

	public Color NormalSilver;

	public Color NormalGold;

	public Color NormalBlue;

	private bool gameComplete;

	private int wordsTarget1;

	private int wordsTarget2;

	private int wordsTarget3;

	private int wordsFound;

	private int wordsFoundInc;

	private int hints;

	private IEnumerator UpdateDisplay()
	{
		return null;
	}

	private void UpdateValues()
	{
	}

	private IEnumerator ShowNextLevel()
	{
		return null;
	}

	public void Initialise()
	{
	}

	private void PlayCheer()
	{
	}

	private IEnumerator PlayCheering()
	{
		return null;
	}

	private IEnumerator PlayFireworks(int loops)
	{
		return null;
	}

	public void CollectHints()
	{
	}
}
