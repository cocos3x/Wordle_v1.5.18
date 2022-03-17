using System;
using UnityEngine;

[Serializable]
public class AmazonProductTemplate
{
	public bool IsOpen;

	[SerializeField]
	private string _LocalizedPrice;

	[SerializeField]
	private long _PriceAmountMicros;

	[SerializeField]
	private string _PriceCurrencyCode;

	[SerializeField]
	private string _sku;

	[SerializeField]
	private AMN_InAppType _productType;

	[SerializeField]
	private string _price;

	[SerializeField]
	private string _title;

	[SerializeField]
	private string _description;

	[SerializeField]
	private string _smallIconUrl;

	[SerializeField]
	private Texture2D _Texture;

	public string Sku
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public AMN_InAppType ProductType
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (AMN_InAppType)null;
		}
		set
		{
		}
	}

	public string Price => "";

	public string Title
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string Description
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string SmallIconUrl => "";

	public Texture2D Texture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PriceCurrencyCode
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string LocalizedPrice
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public long PriceAmountMicros
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	private static bool isFloatChar(char c)
	{
		return false;
	}

	private void SetPriceFromLocalizedPrice()
	{
	}
}
