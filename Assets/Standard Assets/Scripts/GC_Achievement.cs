using System;
using UnityEngine;

public class GC_Achievement
{
	public bool IsOpen;

	[SerializeField]
	private string _title;

	[SerializeField]
	private string _id;

	[SerializeField]
	private string _description;

	[SerializeField]
	private float _progress;

	[SerializeField]
	private int _pointValue;

	[SerializeField]
	private bool _isHidden;

	[SerializeField]
	private bool _isUnlocked;

	[SerializeField]
	private int _position;

	private DateTime _dateUnlocked;

	[SerializeField]
	private Texture2D _Texture;

	public string Title
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	public string Identifier
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

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

	public float Progress => 0f;

	public int PointValue => 0;

	public bool IsHidden => false;

	public bool IsUnlocked => false;

	public int Position => 0;

	public DateTime DateUnlocked => (DateTime)null;

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
}
