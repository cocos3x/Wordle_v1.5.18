using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LvlCompleteContainerScript : MonoBehaviour
{
	private sealed class _003CPlayCheering_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LvlCompleteContainerScript _003C_003E4__this;

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
		public _003CPlayCheering_003Ed__50(int _003C_003E1__state)
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

	private sealed class _003CPlayFireworks_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LvlCompleteContainerScript _003C_003E4__this;

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
		public _003CPlayFireworks_003Ed__51(int _003C_003E1__state)
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

		public static Predicate<StageStats> _003C_003E9__52_0;

		internal bool _003CInitialise_003Eb__52_0(StageStats i)
		{
			return false;
		}
	}

	private sealed class _003CanimateProgress_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LvlCompleteContainerScript _003C_003E4__this;

		private int _003CnewLevel_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CanimateProgress_003Ed__53(int _003C_003E1__state)
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

	private sealed class _003CanimateStars_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LvlCompleteContainerScript _003C_003E4__this;

		public int Stars;

		public int prevStars;

		private float _003CtimeTarget_003E5__2;

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
		public _003CanimateStars_003Ed__54(int _003C_003E1__state)
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

	public AudioClip star;

	public AudioClip fly;

	public AudioClip arrive;

	public AudioClip plusOne;

	public Image star1Empty;

	public Image star2Empty;

	public Image star3Empty;

	public Image star1Full;

	public Image star2Full;

	public Image star3Full;

	public Image star1Fly;

	public Image star2Fly;

	public Image star3Fly;

	public TextMeshProUGUI score;

	public TextMeshProUGUI highScoreWord;

	public TextMeshProUGUI timeCompleted;

	public TextMeshProUGUI todaysScore;

	public TextMeshProUGUI highestScore;

	public TextMeshProUGUI ranking;

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

	public EnergyBar progressBar;

	public GameObject rankGrp;

	public GameObject loginToSee;

	public Sprite starFull;

	public Sprite starEmpty;

	public Transform hintImage;

	public GameObject hintQty;

	public LettetAnimations highScoreAnim;

	public SkipStageScript skipStageScript;

	private int stageScore;

	private int todayScore;

	private int stars;

	private Vector3 star1FlyLoc;

	private Vector3 star2FlyLoc;

	private Vector3 star3FlyLoc;

	private void Awake()
	{
	}

	private void Update()
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

	public void Initialise()
	{
	}

	private IEnumerator animateProgress()
	{
		return null;
	}

	private IEnumerator animateStars(int prevStars, int Stars)
	{
		return null;
	}

	public void OnHide()
	{
	}

	public void DoExit()
	{
	}

	public void DoExitDailyChallenge()
	{
	}
}
