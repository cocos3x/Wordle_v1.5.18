using System;
using System.Collections;
using UnityEngine;

public class TwitterUserInfo
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<Texture2D> _003C_003E9__24_0;

		public static Action<Texture2D> _003C_003E9__24_1;

		public static Action<Texture2D> _003C_003E9__25_0;

		public static Action<Texture2D> _003C_003E9__25_1;

		internal void _003C_002Ector_003Eb__24_0(Texture2D _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__24_1(Texture2D _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__25_0(Texture2D _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__25_1(Texture2D _003Cp0_003E)
		{
		}
	}

	private string _id;

	private string _description;

	private string _name;

	private string _screen_name;

	private string _location;

	private string _lang;

	private string _rawJSON;

	private string _profile_image_url;

	private string _profile_image_url_https;

	private string _profile_background_image_url;

	private string _profile_background_image_url_https;

	private Texture2D _profile_image;

	private Texture2D _profile_background;

	private Color _profile_background_color;

	private Color _profile_text_color;

	private int _friends_count;

	private int _statuses_count;

	private TwitterStatus _status;

	public string rawJSON => "";

	public string id => "";

	public string name => "";

	public string description => "";

	public string screen_name => "";

	public string location => "";

	public string lang => "";

	public string profile_image_url => "";

	public string profile_image_url_https => "";

	public string profile_background_image_url => "";

	public string profile_background_image_url_https => "";

	public int friends_count => 0;

	public int statuses_count => 0;

	public TwitterStatus status => null;

	public Texture2D profile_image => null;

	public Texture2D profile_background => null;

	public Color profile_background_color => (Color)null;

	public Color profile_text_color => (Color)null;

	public event Action<Texture2D> ActionProfileImageLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<Texture2D> ActionProfileBackgroundImageLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public TwitterUserInfo(string data)
	{
	}

	public TwitterUserInfo(IDictionary JSON)
	{
	}

	public void LoadProfileImage()
	{
	}

	public void LoadBackgroundImage()
	{
	}

	private void OnProfileImageLoaded(Texture2D img)
	{
	}

	private void OnProfileBackgroundLoaded(Texture2D img)
	{
	}

	private Color HexToColor(string hex)
	{
		return (Color)null;
	}
}
