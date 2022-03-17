using SA.Common.Models;
using SA.IOSNative.StoreKit;

public class UM_IOS_InAppClient : UM_BaseInAppClient, UM_InAppClient
{
	public void Connect()
	{
	}

	public override void Purchase(UM_InAppProduct product)
	{
	}

	public override void Subscribe(UM_InAppProduct product)
	{
	}

	public override void Consume(UM_InAppProduct product)
	{
	}

	public override void FinishTransaction(UM_InAppProduct product)
	{
	}

	public void RestorePurchases()
	{
	}

	private void IOS_OnTransactionComplete(PurchaseResult responce)
	{
	}

	private void IOS_OnStoreKitInitComplete(Result res)
	{
	}

	private void IOS_OnRestoreComplete(RestoreResult res)
	{
	}
}
