using System.Collections.Generic;
using UnityEngine;

public class AndroidImagesPickResult : AndroidActivityResult
{
	private Dictionary<string, Texture2D> _Images;

	public Dictionary<string, Texture2D> Images => null;

	public AndroidImagesPickResult(string resultCode, string imagesData)
	{
	}
}
