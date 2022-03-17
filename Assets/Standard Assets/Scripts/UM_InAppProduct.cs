using SA.IOSNative.StoreKit;
using System;
using UnityEngine;

[Serializable]
public class UM_InAppProduct
{
	public bool IsOpen;

	public string id;

	public UM_InAppType Type;

	public PriceTier PriceTier;

	public Texture2D Texture;

	public string DisplayName;

	public string Description;

	public string IOSId;

	public string AndroidId;

	public string WP8Id;

	public string AmazonId;

	private Product _IOSTemplate;

	private WP8ProductTemplate _WP8Template;

	private GoogleProductTemplate _AndroidTemplate;

	private AmazonProductTemplate _AmazonTemplate;

	private UM_InAppProductTemplate _template;

	private bool _isTemplateSet;

	public WP8ProductTemplate WP8Template => null;

	public Product IOSTemplate => null;

	public GoogleProductTemplate AndroidTemplate => null;

	public AmazonProductTemplate AmazonTemplate => null;

	public UM_InAppProductTemplate template => null;

	public bool IsConsumable => false;

	public string LocalizedPrice => "";

	public string CurrencyCode => "";

	public long PriceAmountMicros => 0L;

	public string ActualPrice => "";

	public float ActualPriceValue => 0f;

	public bool IsPurchased => false;

	public string Title => "";

	public void SetTemplate(WP8ProductTemplate tpl)
	{
	}

	public void SetTemplate(Product tpl)
	{
	}

	public void SetTemplate(GoogleProductTemplate tpl)
	{
	}

	public void SetTemplate(AmazonProductTemplate tpl)
	{
	}

	private float GetPriceByTier()
	{
		return 0f;
	}

	public override string ToString()
	{
		return "";
	}
}
