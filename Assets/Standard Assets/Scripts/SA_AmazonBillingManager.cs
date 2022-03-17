using System;
using System.Collections.Generic;

public class SA_AmazonBillingManager : AMN_Singleton<SA_AmazonBillingManager>
{
	public enum status
	{
		SUCCESSFUL,
		FAILED
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<AMN_GetUserDataResponse> _003C_003E9__30_0;

		public static Action<AMN_PurchaseResponse> _003C_003E9__30_1;

		public static Action<AMN_GetProductDataResponse> _003C_003E9__30_2;

		public static Action<AMN_GetPurchaseProductsUpdateResponse> _003C_003E9__30_3;

		internal void _003C_002Ector_003Eb__30_0(AMN_GetUserDataResponse _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__30_1(AMN_PurchaseResponse _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__30_2(AMN_GetProductDataResponse _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__30_3(AMN_GetPurchaseProductsUpdateResponse _003Cp0_003E)
		{
		}
	}

	public string currentSKU;

	private bool _isInitialized;

	public Dictionary<string, AmazonProductTemplate> availableItems;

	public List<string> unavailableSkus;

	public List<SA_AmazonReceipt> listReceipts;

	public bool IsInitialized => false;

	public event Action<AMN_GetUserDataResponse> OnGetUserDataReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_PurchaseResponse> OnPurchaseProductReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_GetProductDataResponse> OnGetProductDataReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AMN_GetPurchaseProductsUpdateResponse> OnGetPurchaseProductsUpdatesReceived
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

	public void Initialize()
	{
	}

	public void Initialize(List<AmazonProductTemplate> product_ids)
	{
	}

	public void AddProduct(string sku)
	{
	}

	public void GetUserData()
	{
	}

	public void Purchase(string SKU)
	{
	}

	public void GetProductUpdates()
	{
	}

	private void Init(List<AmazonProductTemplate> product_ids)
	{
	}

	private void SubscribeToEvents()
	{
	}

	private int IsExistsInSettings(AmazonProductTemplate product)
	{
		return 0;
	}
}
