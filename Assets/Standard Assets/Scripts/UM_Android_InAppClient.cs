public class UM_Android_InAppClient : UM_BaseInAppClient, UM_InAppClient
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

	public override bool IsProductPurchased(UM_InAppProduct product)
	{
		return false;
	}

	public void RestorePurchases()
	{
	}

	private void OnProductPurchased(BillingResult result)
	{
	}

	private void OnBillingConnected(BillingResult result)
	{
	}

	private void OnRetrieveProductsFinised(BillingResult result)
	{
	}
}
