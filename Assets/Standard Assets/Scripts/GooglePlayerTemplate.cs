using System;
using UnityEngine;

public class GooglePlayerTemplate
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Texture2D> _003C_003E9__14_0;

		public static Action<Texture2D> _003C_003E9__14_1;

		internal void _003C_002Ector_003Eb__14_0(Texture2D _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__14_1(Texture2D _003Cp0_003E)
		{
		}
	}

	private string _id;

	private string _name;

	private string _iconImageUrl;

	private string _hiResImageUrl;

	private Texture2D _icon;

	private Texture2D _image;

	private bool _hasIconImage;

	private bool _hasHiResImage;

	public string playerId => "";

	public string name => "";

	public bool hasIconImage => false;

	public bool hasHiResImage => false;

	public string iconImageUrl => "";

	public string hiResImageUrl => "";

	public Texture2D icon => null;

	public Texture2D image => null;

	public event Action<Texture2D> BigPhotoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<Texture2D> SmallPhotoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public GooglePlayerTemplate(string pId, string pName, string iconUrl, string imageUrl, string pHasIconImage, string pHasHiResImage)
	{
	}

	public void LoadImage()
	{
	}

	public void LoadIcon()
	{
	}

	private void OnProfileImageLoaded(Texture2D tex)
	{
	}

	private void OnProfileIconLoaded(Texture2D tex)
	{
	}
}
