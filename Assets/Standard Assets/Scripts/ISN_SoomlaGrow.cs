using SA.Common.Models;
using SA.Common.Pattern;
using SA.IOSNative.StoreKit;
using System;

public class ISN_SoomlaGrow : Singleton<ISN_SoomlaGrow>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__38_0()
		{
		}

		internal void _003C_002Ecctor_003Eb__38_1()
		{
		}

		internal void _003C_002Ecctor_003Eb__38_2()
		{
		}
	}

	private static bool _IsInitialized;

	public static bool IsInitialized => false;

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

	public void CreateObject()
	{
	}

	public static void Init()
	{
	}

	private static void HandleOnVerificationComplete(VerificationResponse res)
	{
	}

	private static void HandleOnRestoreComplete(RestoreResult res)
	{
	}

	private static void HandleOnRestoreStarted()
	{
	}

	private static void HandleOnTransactionStarted(string prodcutId)
	{
	}

	private static void HandleOnTransactionComplete(PurchaseResult res)
	{
	}

	public static void SocialAction(ISN_SoomlaEvent soomlaEvent, ISN_SoomlaAction action, ISN_SoomlaProvider provider)
	{
	}

	private static void PurchaseStarted(string prodcutId)
	{
	}

	private static void PurchaseFinished(string prodcutId, string priceInMicros, string currency)
	{
	}

	private static void PurchaseCanceled(string prodcutId)
	{
	}

	public static void SetPurchasesSupportedState(bool isSupported)
	{
	}

	private static void PurchaseError()
	{
	}

	private static void VerificationFailed()
	{
	}

	private static void RestoreStarted()
	{
	}

	private static void RestoreFinished(bool state)
	{
	}

	private void OnHighWayInitialized()
	{
	}

	private void OnHihgWayConnected()
	{
	}

	private void OnHihgWayDisconnected()
	{
	}

	private static void HandleOnInstagramPostResult(Result res)
	{
	}

	private static void HandleOnTwitterPostResult(Result res)
	{
	}

	private static void HandleOnInstagramPostStart()
	{
	}

	private static void HandleOnTwitterPostStart()
	{
	}

	private static void HandleOnFacebookPostStart()
	{
	}

	private static void HandleOnFacebookPostResult(Result res)
	{
	}
}
