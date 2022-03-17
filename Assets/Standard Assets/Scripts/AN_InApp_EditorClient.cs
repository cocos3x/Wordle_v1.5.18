using System;
using UnityEngine;

public class AN_InApp_EditorClient : MonoBehaviour, AN_InAppClient
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<BillingResult> _003C_003E9__48_0;

		public static Action<BillingResult> _003C_003E9__48_1;

		public static Action<BillingResult> _003C_003E9__48_2;

		public static Action<BillingResult> _003C_003E9__48_3;

		internal void _003C_002Ector_003Eb__48_0(BillingResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__48_1(BillingResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__48_2(BillingResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__48_3(BillingResult _003Cp0_003E)
		{
		}
	}

	private string _processedSKU;

	private AndroidInventory _inventory;

	private bool _IsConnectingToServiceInProcess;

	private bool _IsProductRetrievingInProcess;

	private bool _IsConnected;

	private bool _IsInventoryLoaded;

	private float _RequestsSuccessRate;

	private string _CurrentSKU;

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

	public void Connect()
	{
	}

	public void Connect(string base64EncodedPublicKey)
	{
	}

	private void GenerateConnectionResult()
	{
	}

	public void RetrieveProducDetails()
	{
	}

	public void OnQueryInventoryFinishedCallBack()
	{
	}

	public void Purchase(string SKU)
	{
	}

	public void Purchase(string SKU, string DeveloperPayload)
	{
	}

	private void OnPurchaseComplete(bool IsSucceeded)
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

	public void OnPurchaseFinishedCallback(string data)
	{
	}

	public void OnConsumeFinishedCallBack(string data)
	{
	}
}
