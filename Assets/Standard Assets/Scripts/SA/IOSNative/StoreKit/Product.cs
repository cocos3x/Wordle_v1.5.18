using System;
using UnityEngine;

namespace SA.IOSNative.StoreKit
{
	[Serializable]
	public class Product
	{
		public bool IsOpen;

		[SerializeField]
		private bool _IsAvailable;

		[SerializeField]
		private string _Id;

		[SerializeField]
		private string _DisplayName;

		[SerializeField]
		private string _Description;

		[SerializeField]
		private float _Price;

		[SerializeField]
		private string _LocalizedPrice;

		[SerializeField]
		private string _CurrencySymbol;

		[SerializeField]
		private string _CurrencyCode;

		[SerializeField]
		private Texture2D _Texture;

		[SerializeField]
		private ProductType _ProductType;

		[SerializeField]
		private PriceTier _PriceTier;

		public string Id
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string DisplayName
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

		public ProductType Type
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (ProductType)null;
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

		public long PriceInMicros => 0L;

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

		public string CurrencySymbol
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string CurrencyCode
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

		public PriceTier PriceTier
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (PriceTier)null;
			}
			set
			{
			}
		}

		public bool IsAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void UpdatePriceByTier()
		{
		}
	}
}
