using System.Collections.Generic;
using UnityEngine;

public class UM_ImagesPickResult : UM_BaseResult
{
	private Dictionary<string, Texture2D> _Images;

	public Dictionary<string, Texture2D> Images => null;

	public UM_ImagesPickResult(bool isSuccess, Dictionary<string, Texture2D> images)
	{
	}
}
