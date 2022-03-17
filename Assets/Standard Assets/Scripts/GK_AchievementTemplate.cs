using System;
using UnityEngine;

[Serializable]
public class GK_AchievementTemplate
{
	public bool IsOpen;

	public string Id;

	public string Title;

	public string Description;

	public float _progress;

	public Texture2D Texture;

	public float Progress
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}
}
