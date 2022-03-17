using System;
using UnityEngine;

public class AN_InAppAndroidClient : MonoBehaviour, AN_InAppClient
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<BillingResult> _003C_003E9__47_0;

		public static Action<BillingResult> _003C_003E9__47_1;

		public static Action<BillingResult> _003C_003E9__47_2;

		public static Action<BillingResult> _003C_003E9__47_3;

		internal void _003C_002Ector_003Eb__47_0(BillingResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__47_1(BillingResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__47_2(BillingResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__47_3(BillingResult _003Cp0_003E)
		{
		}
	}

	private string _processedSKU;

	private AndroidInventory _inventory;

	private bool _IsConnectingToServiceInProcess;

	private bool _IsProductRetrievingInProcess;

	private bool _IsConnected;

	private bool _IsInventoryLoaded;

	public AndroidInventory Inventory => null;

	public bool IsConnectingToServiceInProcess => false;

	public bool IsProductRetrievingInProcess => false;

	public bool IsConnected => false;

	public bool IsInventoryLoaded => false;

	public event Action<BillingResult> ActionProductPurchased
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<BillingResult> ActionProductConsumed
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<BillingResult> ActionBillingSetupFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<BillingResult> ActionRetrieveProducsFinished
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

	public void AddProduct(string SKU)
	{
	}

	public void AddProduct(GoogleProductTemplate template)
	{
	}

	public void RetrieveProducDetails()
	{
	}

	public void Purchase(string SKU)
	{
	}

	public void Purchase(string SKU, string DeveloperPayload)
	{
	}

	public void Subscribe(string SKU)
	{
	}

	public void Subscribe(string SKU, string DeveloperPayload)
	{
	}

	public void Consume(string SKU)
	{
	}

	public void LoadStore()
	{
	}

	public void LoadStore(string base64EncodedPublicKey)
	{
	}

	public void Connect()
	{
	}

	public void Connect(string base64EncodedPublicKey)
	{
	}

	public void OnPurchaseFinishedCallback(string data)
	{
	}

	public void OnConsumeFinishedCallBack(string data)
	{
	}

	public void OnBillingSetupFinishedCallback(string data)
	{
	}

	public void OnQueryInventoryFinishedCallBack(string data)
	{
	}

	public void OnPurchasesRecive(string data)
	{
	}

	public void OnProducttDetailsRecive(string data)
	{
	}
}
