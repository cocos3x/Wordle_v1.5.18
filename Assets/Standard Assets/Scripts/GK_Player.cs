using System;
using System.Collections.Generic;
using UnityEngine;

public class GK_Player
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GK_UserPhotoLoadResult> _003C_003E9__9_0;

		internal void _003C_002Ector_003Eb__9_0(GK_UserPhotoLoadResult _003Cp0_003E)
		{
		}
	}

	private string _PlayerId;

	private string _DisplayName;

	private string _Alias;

	private Texture2D _SmallPhoto;

	private Texture2D _BigPhoto;

	private static Dictionary<string, Texture2D> LocalPhotosCache;

	public string Id => "";

	public string Alias => "";

	public string DisplayName => "";

	public Texture2D SmallPhoto => null;

	public Texture2D BigPhoto => null;

	private string SmallPhotoCacheKey => "";

	private string BigPhotoCacheKey => "";

	public event Action<GK_UserPhotoLoadResult> OnPlayerPhotoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public GK_Player(string pId, string pName, string pAlias)
	{
	}

	public void LoadPhoto(GK_PhotoSize size)
	{
	}

	public void SetPhotoData(GK_PhotoSize size, string base64String)
	{
	}

	public void SetPhotoLoadFailedEventData(GK_PhotoSize size, string errorData)
	{
	}

	public static void UpdatePhotosCache(string key, Texture2D photo)
	{
	}

	public static Texture2D GetLocalCachedPhotoByKey(string key)
	{
		return null;
	}
}
