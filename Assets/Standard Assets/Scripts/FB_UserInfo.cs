using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FB_UserInfo
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<FB_UserInfo> _003C_003E9__18_0;

		public static Action<FB_UserInfo> _003C_003E9__19_0;

		internal void _003C_002Ector_003Eb__18_0(FB_UserInfo _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__19_0(FB_UserInfo _003Cp0_003E)
		{
		}
	}

	private string _id;

	private string _name;

	private string _first_name;

	private string _last_name;

	private string _username;

	private string _profile_url;

	private string _email;

	private string _location;

	private string _locale;

	private string _rawJSON;

	private DateTime _Birthday;

	private FB_Gender _gender;

	private string _ageRange;

	private string _picUrl;

	private Dictionary<FB_ProfileImageSize, Texture2D> profileImages;

	public string RawJSON => "";

	public string Id => "";

	public DateTime Birthday => (DateTime)null;

	public string Name => "";

	public string FirstName => "";

	public string LastName => "";

	public string UserName => "";

	public string ProfileUrl => "";

	public string Email => "";

	public string Locale => "";

	public string Location => "";

	public FB_Gender Gender => (FB_Gender)null;

	public string AgeRange => "";

	public string PictureUrl => "";

	public event Action<FB_UserInfo> OnProfileImageLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public FB_UserInfo(string data)
	{
	}

	public FB_UserInfo(IDictionary JSON)
	{
	}

	public void InitializeData(IDictionary JSON)
	{
	}

	public string GetProfileUrl(FB_ProfileImageSize size)
	{
		return "";
	}

	public Texture2D GetProfileImage(FB_ProfileImageSize size)
	{
		return null;
	}

	public void LoadProfileImage(FB_ProfileImageSize size)
	{
	}

	private void OnSquareImageLoaded(Texture2D image)
	{
	}

	private void OnLargeImageLoaded(Texture2D image)
	{
	}

	private void OnNormalImageLoaded(Texture2D image)
	{
	}

	private void OnSmallImageLoaded(Texture2D image)
	{
	}
}
