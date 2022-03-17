using SA.Common.Models;
using SA.Common.Pattern;
using System;
using UnityEngine;

public class UM_Camera : Singleton<UM_Camera>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<UM_ImagePickResult> _003C_003E9__20_0;

		public static Action<UM_ImageSaveResult> _003C_003E9__20_1;

		public static Action<UM_ImagesPickResult> _003C_003E9__20_2;

		internal void _003C_002Ector_003Eb__20_0(UM_ImagePickResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__20_1(UM_ImageSaveResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__20_2(UM_ImagesPickResult _003Cp0_003E)
		{
		}
	}

	public event Action<UM_ImagePickResult> OnImagePicked
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_ImageSaveResult> OnImageSaved
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<UM_ImagesPickResult> OnImagesPicked
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

	public void SaveImageToGalalry(Texture2D image)
	{
	}

	public void SaveScreenshotToGallery()
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

	private void HandleOnImagesPicked(AndroidImagesPickResult result)
	{
	}

	private void OnAndroidImagePicked(AndroidImagePickResult obj)
	{
	}

	private void OnIOSImagePicked(IOSImagePickResult obj)
	{
	}

	private void OnAndroidImageSaved(GallerySaveResult res)
	{
	}

	private void OnIOSImageSaved(Result res)
	{
	}
}
