using SA.Common.Pattern;
using System;

public class SA_EditorAd : Singleton<SA_EditorAd>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__53_0(bool _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__53_1(bool _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__53_2()
		{
		}

		internal void _003C_002Ecctor_003Eb__53_3(bool _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__53_4(bool _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__53_5()
		{
		}
	}

	public const float MIN_LOAD_TIME = 1f;

	public const float MAX_LOAD_TIME = 3f;

	private bool _IsInterstitialLoading;

	private bool _IsVideoLoading;

	private bool _IsInterstitialReady;

	private bool _IsVideoReady;

	private int _FillRate;

	private SA_Ad_EditorUIController _EditorUI;

	public bool IsVideoReady => false;

	public bool IsVideoLoading => false;

	public bool IsInterstitialReady => false;

	public bool IsInterstitialLoading => false;

	public bool HasFill => false;

	public int FillRate => 0;

	private SA_Ad_EditorUIController EditorUI => null;

	public static event Action<bool> OnInterstitialFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<bool> OnInterstitialLoadComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnInterstitialLeftApplication
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<bool> OnVideoFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<bool> OnVideoLoadComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnVideoLeftApplication
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void SetFillRate(int fillRate)
	{
	}

	public void LoadInterstitial()
	{
	}

	public void ShowInterstitial()
	{
	}

	public void LoadVideo()
	{
	}

	public void ShowVideo()
	{
	}

	private void OnVideoRequestComplete()
	{
	}

	private void OnInterstitialRequestComplete()
	{
	}

	private void OnInterstitialFinished_UIEvent(bool IsRewarded)
	{
	}

	private void OnVideoFinished_UIEvent(bool IsRewarded)
	{
	}

	private void OnInterstitialLeftApplication_UIEvent()
	{
	}

	private void OnVideoLeftApplication_UIEvent()
	{
	}
}
