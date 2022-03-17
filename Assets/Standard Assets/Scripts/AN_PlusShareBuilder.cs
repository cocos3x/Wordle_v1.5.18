using SA.Common.Models;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AN_PlusShareBuilder
{
	private const string LISTENER_OBJECT_NAME = "AN_PlusShareListener";

	private GameObject listenerObject;

	private string message;

	private List<Texture2D> images;

	public event Action<Result> OnPlusShareResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public AN_PlusShareBuilder(string text)
	{
	}

	public void AddImage(Texture2D image)
	{
	}

	public void Share()
	{
	}

	private void PlusShareCallback(Result result)
	{
	}
}
