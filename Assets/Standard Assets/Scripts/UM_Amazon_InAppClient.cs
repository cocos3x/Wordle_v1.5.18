public class UM_Amazon_InAppClient : UM_BaseInAppClient, UM_InAppClient
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

	private void HandleAmazonPurchaseProductReceived(AMN_PurchaseResponse response)
	{
	}

	private void HandleAmazonGetPurchaseProductsUpdatesReceived(AMN_GetPurchaseProductsUpdateResponse response)
	{
	}

	private void HandleAmazonGetProductDataReceived(AMN_GetProductDataResponse response)
	{
	}

	private void HandleAmazonGetUserDataReceived(AMN_GetUserDataResponse response)
	{
	}
}
