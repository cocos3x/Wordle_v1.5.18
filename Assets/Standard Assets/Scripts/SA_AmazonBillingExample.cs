using System.Collections.Generic;
using UnityEngine;

public class SA_AmazonBillingExample : MonoBehaviour
{
	public DefaultPreviewButton[] buttons;

	private List<string> entitlements;

	private Dictionary<string, AmazonProductTemplate> availableItems;

	private List<string> unavailableSkus;

	private List<SA_AmazonReceipt> listReceipts;

	private SA_AmazonReceipt receipt;

	private bool isInitialized;

	private string SKU_EXAMPLE;

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void OnGetUserDataReceived(AMN_GetUserDataResponse result)
	{
	}

	private void OnPurchaseProductReceived(AMN_PurchaseResponse result)
	{
	}

	private void OnGetProductDataReceived(AMN_GetProductDataResponse result)
	{
	}

	private void OnGetPurchaseProductsUpdatesReceived(AMN_GetPurchaseProductsUpdateResponse result)
	{
	}

	private void InitializeAmazonBilling()
	{
	}

	private void DisableButtons()
	{
	}

	private void EnableButtons()
	{
	}

	private void Purchase()
	{
	}

	private void GetUserData()
	{
	}

	private void GetProductUpdates()
	{
	}

	private void AddEntitlement(string SKU)
	{
	}
}
