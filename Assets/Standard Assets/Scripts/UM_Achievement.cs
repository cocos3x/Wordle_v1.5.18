using System;
using UnityEngine;

[Serializable]
public class UM_Achievement
{
	public bool IsOpen;

	[SerializeField]
	public string id;

	[SerializeField]
	private int _Steps;

	[SerializeField]
	private string _Description;

	[SerializeField]
	private Texture2D _Texture;

	public bool IsIncremental;

	public string IOSId;

	public string AndroidId;

	public string AmazonId;

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

	public Texture2D Texture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Steps
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}
}
