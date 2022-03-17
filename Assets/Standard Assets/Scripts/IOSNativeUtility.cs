using SA.Common.Pattern;
using System;

public class IOSNativeUtility : Singleton<IOSNativeUtility>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__22_0(ISN_Locale _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__22_1(bool _003Cp0_003E)
		{
		}
	}

	public bool IsGuidedAccessEnabled => false;

	public static bool IsRunningTestFlightBeta => false;

	public static event Action<ISN_Locale> OnLocaleLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<bool> GuidedAccessSessionRequestResult
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

	public void GetLocale()
	{
	}

	public static void CopyToClipboard(string text)
	{
	}

	public static void RedirectToAppStoreRatingPage()
	{
	}

	public static void RedirectToAppStoreRatingPage(string appleId)
	{
	}

	public static void SetApplicationBagesNumber(int count)
	{
	}

	public static void ShowPreloader()
	{
	}

	public static void HidePreloader()
	{
	}

	public void RequestGuidedAccessSession(bool enabled)
	{
	}

	private void OnGuidedAccessSessionRequestResult(string data)
	{
	}

	private void OnLocaleLoadedHandler(string data)
	{
	}
}
