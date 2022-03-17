using System;
using System.Collections.Generic;
using UnityEngine;

public class FB_Score
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<FB_Score> _003C_003E9__16_0;

		internal void _003C_002Ector_003Eb__16_0(FB_Score _003Cp0_003E)
		{
		}
	}

	public string UserId;

	public string UserName;

	public string AppId;

	public string AppName;

	public int value;

	private Dictionary<FB_ProfileImageSize, Texture2D> profileImages;

	public event Action<FB_Score> OnProfileImageLoaded
	{
		add
		{
		}
		remove
		{
		}
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
