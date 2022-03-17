using SA.Common.Pattern;
using System;

public class AN_SoomlaGrow : Singleton<AN_SoomlaGrow>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__40_0()
		{
		}

		internal void _003C_002Ecctor_003Eb__40_1()
		{
		}

		internal void _003C_002Ecctor_003Eb__40_2()
		{
		}
	}

	private static bool _IsInitialized;

	public static event Action ActionInitialized
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionConnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action ActionDisconnected
	{
		add
		{
		}
		remove
		{
		}
	}

	public void CreateListner()
	{
	}

	public static void Init()
	{
	}

	public static void PurchaseStarted(string prodcutId)
	{
	}

	public static void PurchaseFinished(string prodcutId, long priceInMicros, string currency)
	{
	}

	public static void PurchaseCanceled(string prodcutId)
	{
	}

	public static void SetPurhsesSupportedState(bool isSupported)
	{
	}

	public static void PurchaseError()
	{
	}

	private static void FriendsRequest(AN_SoomlaEventType eventType, AN_SoomlaSocialProvider provider)
	{
	}

	public static void SocialLogin(AN_SoomlaEventType eventType, AN_SoomlaSocialProvider provider)
	{
	}

	public static void SocialLoginFinished(AN_SoomlaSocialProvider provider, string ProfileId)
	{
	}

	public static void SocialLogOut(AN_SoomlaEventType eventType, AN_SoomlaSocialProvider provider)
	{
	}

	public static void SocialShare(AN_SoomlaEventType eventType, AN_SoomlaSocialProvider provider)
	{
	}

	private static void FB_OnFriendsRequestStarted()
	{
	}

	private static void FB_HandleOnFriendsDataRequestCompleteAction(FB_Result res)
	{
	}

	private static void FB_OnAuthCompleteAction(FB_Result res)
	{
	}

	private static void FB_OnLoginStarted()
	{
	}

	private static void FB_OnLogOut()
	{
	}

	private static void FB_PostStarted()
	{
	}

	private static void FB_PostCompleted(FB_PostResult res)
	{
	}

	private static void HandleOnAuthCompleteAction(TWResult res)
	{
	}

	private static void HandleOnUserDataRequestCompleteAction(TWResult res)
	{
	}

	private static void OnTwitterLoginStarted()
	{
	}

	private static void OnTwitterLogOut()
	{
	}

	private static void TW_PostStarted()
	{
	}

	private static void TW_PostCompleted(TWResult res)
	{
	}

	private static bool CheckState()
	{
		return false;
	}

	private void OnInitialized()
	{
	}

	private void OnConnected()
	{
	}

	private void OnDisconnected()
	{
	}
}
