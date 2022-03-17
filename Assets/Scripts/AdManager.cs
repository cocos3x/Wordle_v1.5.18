using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AdManager : MonoBehaviour
{
	private sealed class _003CTryLoadAds_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdManager _003C_003E4__this;

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
		public _003CTryLoadAds_003Ed__47(int _003C_003E1__state)
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

		internal void _003C_002Ecctor_003Eb__75_0(string _003Cp0_003E, int _003Cp1_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__75_1()
		{
		}

		internal void _003C_002Ecctor_003Eb__75_2(int _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__75_3()
		{
		}

		internal void _003C_002Ecctor_003Eb__75_4()
		{
		}

		internal void _003C_002Ecctor_003Eb__75_5()
		{
		}

		internal void _003C_002Ecctor_003Eb__75_6()
		{
		}
	}

	public static AdManager adManager;

	public float TryLoadVideoTimer;

	private bool TryingToLoad;

	private bool AdClosed;

	private int HintsAwarded;

	private long timeAtStartup;

	private DateTime lastRewardedAd;

	private int RewardedAdsShown;

	public int RewardedVideosB4Wait;

	public float RewardedVideoWaitTime;

	public bool helpTextShown;

	public static bool InterstitialVideoisPlaying;

	public int playAdAfterXLevels;

	public bool AdsOff;

	public bool PremiumVersion;

	public static bool RewardedVideoLoaded => false;

	public static bool RewardedVideoReady => false;

	public static bool InterstitialVideoLoaded => false;

	public static bool InterstitialVideoReady => false;

	public static event Action<string, int> OnRewarded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoAdClosed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<int> OnRewardedVideoAdFailedToLoad
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoAdLeftApplication
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoAdOpened
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnRewardedVideoStarted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static bool RewardedVideoTimerOn()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void MakeThisTheOnlyAdManager()
	{
	}

	public DateTime NISTDateTime()
	{
		return (DateTime)null;
	}

	public DateTime CurrentDateTime()
	{
		return (DateTime)null;
	}

	private float timeSinceLastAd()
	{
		return 0f;
	}

	public string timeRemainingTillNextAd()
	{
		return "";
	}

	private void Update()
	{
	}

	public void Initialise()
	{
	}

	private void Start()
	{
	}

	private void DoTryLoadAds()
	{
	}

	private IEnumerator TryLoadAds()
	{
		return null;
	}

	public static bool CheckForInternetConnection()
	{
		return false;
	}

	public void DoShowRewardedVideoAd()
	{
	}

	public void LoadNextRewardedAd()
	{
	}

	private void LoadNextInterstitialAd()
	{
	}

	public void ShowRewardedVideoAd()
	{
	}

	public void ShowInterstitialVideoAd()
	{
	}

	private void HandleOnRewardedVideoLoaded()
	{
	}

	private void HandleOnRewardedVideoAdClosed()
	{
	}

	private void HandleOnRewarded(string reward, int qty)
	{
	}

	private void HandleOnRewardedVideoAdFailedToLoad(int val)
	{
	}

	private void HandleOnRewardedVideoClickThrough()
	{
	}

	private void HandleOnInterstitialClosed()
	{
	}

	private void HandleOnInterstitialLoadFail(int val)
	{
	}

	private void HandleOnInterstitialLoaded()
	{
	}

	private void HandleOnInterstitialClickThrough()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPaused(bool pauseStatus)
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}
}
