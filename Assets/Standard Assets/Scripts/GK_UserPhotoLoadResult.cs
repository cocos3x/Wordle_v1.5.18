using SA.Common.Models;
using UnityEngine;

public class GK_UserPhotoLoadResult : Result
{
	private Texture2D _Photo;

	private GK_PhotoSize _Size;

	public Texture2D Photo => null;

	public GK_PhotoSize Size => (GK_PhotoSize)null;

	public GK_UserPhotoLoadResult(GK_PhotoSize size, Texture2D photo)
	{
	}

	public GK_UserPhotoLoadResult(GK_PhotoSize size, Error error)
	{
	}
}
