using System;

public static class AndroidInAppPurchaseManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__21_0(BillingResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__21_1(BillingResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__21_2(BillingResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__21_3(BillingResult _003Cp0_003E)
		{
		}
	}

	public static AN_InAppClient _Client;

	public static AN_InAppClient Client => null;

	public static AN_InAppClient Instance => null;

	public static event Action<BillingResult> ActionProductPurchased
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<BillingResult> ActionProductConsumed
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<BillingResult> ActionBillingSetupFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<BillingResult> ActionRetrieveProducsFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	private static void HandleActionRetrieveProducsFinished(BillingResult res)
	{
	}

	private static void HandleActionProductPurchased(BillingResult res)
	{
	}

	private static void HandleActionProductConsumed(BillingResult res)
	{
	}

	private static void HandleActionBillingSetupFinished(BillingResult res)
	{
	}
}
