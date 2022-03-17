using System;
using System.Collections.Generic;

public class WP8InAppPurchasesManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__36_0(WP8_InAppsInitResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__36_1(WP8PurchseResponce _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__36_2(WP8ConsumeResponse _003Cp0_003E)
		{
		}
	}

	private static WP8InAppPurchasesManager _instance;

	private bool _IsInitialized;

	public const string SPLITTER1 = "|";

	public const string SPLITTER2 = "|%|";

	public const int RESULT_OK = 0;

	public const int RESULT_ERROR = 1;

	private List<WP8ProductTemplate> _products;

	public static WP8InAppPurchasesManager instance => null;

	public static WP8InAppPurchasesManager Instance => null;

	public List<WP8ProductTemplate> products => null;

	public List<WP8ProductTemplate> Products => null;

	public bool IsInitialized => false;

	public static event Action<WP8_InAppsInitResult> OnInitComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<WP8PurchseResponce> OnPurchaseFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<WP8ConsumeResponse> OnConsumeFinished
	{
		add
		{
		}
		remove
		{
		}
	}

	public void init()
	{
	}

	public void Init()
	{
	}

	public void purchase(string productId)
	{
	}

	public void Purchase(string productID)
	{
	}

	public WP8ProductTemplate GetProductById(string id)
	{
		return null;
	}

	private void InitCallback(string res)
	{
	}

	private void PurchaseCallback(string result)
	{
	}

	private void ConsumeCallback(string result)
	{
	}

	private void DefferedPurchaseCallback(string result)
	{
	}
}
