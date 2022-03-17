using System;
using UnityEngine;

public class WP8ProductTemplate
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Texture2D> _003C_003E9__45_0;

		internal void _003C_002Ector_003Eb__45_0(Texture2D _003Cp0_003E)
		{
		}
	}

	private string _003CDescription_003Ek__BackingField;

	private string _003CImgURI_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private string _003CProductId_003Ek__BackingField;

	private string _003CPrice_003Ek__BackingField;

	private string _003CTransactionID_003Ek__BackingField;

	private WP8PurchaseProductType _003CType_003Ek__BackingField;

	private bool _003CIsPurchased_003Ek__BackingField;

	private Texture2D _texture;

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

	public string ImgURI
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string Name
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string ProductId
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string Price
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string TransactionID
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public WP8PurchaseProductType Type
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (WP8PurchaseProductType)null;
		}
		set
		{
		}
	}

	public bool isPurchased
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsPurchased
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Texture2D texture => null;

	public Texture2D Texture => null;

	public event Action<Texture2D> ProdcutImageLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public void LoadProductImage()
	{
	}

	private void HandleTextureLoaded(Texture2D texture)
	{
	}
}
