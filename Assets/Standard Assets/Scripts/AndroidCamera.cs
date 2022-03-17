using SA.Common.Pattern;
using System;
using UnityEngine;

public class AndroidCamera : Singleton<AndroidCamera>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<AndroidImagePickResult> _003C_003E9__28_0;

		public static Action<AndroidImagesPickResult> _003C_003E9__28_1;

		public static Action<AndroidVideoPickResult> _003C_003E9__28_2;

		public static Action<GallerySaveResult> _003C_003E9__28_3;

		internal void _003C_002Ector_003Eb__28_0(AndroidImagePickResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__28_1(AndroidImagesPickResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__28_2(AndroidVideoPickResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__28_3(GallerySaveResult _003Cp0_003E)
		{
		}
	}

	private static string _lastImageName;

	public event Action<AndroidImagePickResult> OnImagePicked
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AndroidImagesPickResult> OnImagesPicked
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<AndroidVideoPickResult> OnVideoPicked
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<GallerySaveResult> OnImageSaved
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void SaveImageToGalalry(Texture2D image, string name = "Screenshot")
	{
	}

	public void SaveImageToGallery(Texture2D image, string name = "Screenshot")
	{
	}

	public void SaveScreenshotToGallery(string name = "Screenshot")
	{
	}

	public void GetVideoFromGallery()
	{
	}

	public void GetImageFromGallery()
	{
	}

	public void GetImagesFromGallery()
	{
	}

	public void GetImageFromCamera()
	{
	}

	private void OnVideoPickedCallback(string data)
	{
	}

	private void OnImagePickedEvent(string data)
	{
	}

	private void ImagesPickedCallback(string data)
	{
	}

	private void OnImageSavedEvent(string data)
	{
	}

	private void OnImageSaveFailedEvent(string data)
	{
	}

	private void OnScreenshotReady(Texture2D tex)
	{
	}

	public static string GetRandomString()
	{
		return "";
	}
}
