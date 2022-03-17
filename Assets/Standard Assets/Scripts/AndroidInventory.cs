using System.Collections.Generic;

public class AndroidInventory
{
	private Dictionary<string, GooglePurchaseTemplate> _purchases;

	public List<GooglePurchaseTemplate> Purchases => null;

	public List<GoogleProductTemplate> Products => null;

	public void addPurchase(GooglePurchaseTemplate purchase)
	{
	}

	public void removePurchase(GooglePurchaseTemplate purchase)
	{
	}

	public bool IsProductPurchased(string SKU)
	{
		return false;
	}

	public GoogleProductTemplate GetProductDetails(string SKU)
	{
		return null;
	}

	public GooglePurchaseTemplate GetPurchaseDetails(string SKU)
	{
		return null;
	}
}
