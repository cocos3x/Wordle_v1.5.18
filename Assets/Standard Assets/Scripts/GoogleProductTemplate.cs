using System;
using UnityEngine;

[Serializable]
public class GoogleProductTemplate
{
	public const long DEFAULT_PRICE_AMOUNT_MICROS = 990000L;

	public bool IsOpen;

	public string SKU;

	private string _OriginalJson;

	[SerializeField]
	private string _LocalizedPrice;

	[SerializeField]
	private long _PriceAmountMicros;

	[SerializeField]
	private string _PriceCurrencyCode;

	[SerializeField]
	private string _Description;

	[SerializeField]
	private string _Title;

	[SerializeField]
	private Texture2D _Texture;

	[SerializeField]
	private AN_InAppType _ProductType;

	public string OriginalJson
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public float Price
	{
		get
		{
			return 0f;
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

	public AN_InAppType ProductType
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (AN_InAppType)null;
		}
		set
		{
		}
	}
}
