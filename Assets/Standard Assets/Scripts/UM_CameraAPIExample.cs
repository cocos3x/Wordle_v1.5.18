using System;
using UnityEngine;

public class UM_CameraAPIExample : BaseIOSFeaturePreview
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static MNPopup.MNPopupAction _003C_003E9__3_0;

		public static MNPopup.MNPopupAction _003C_003E9__3_1;

		internal void _003COnImageSaved_003Eb__3_0()
		{
		}

		internal void _003COnImageSaved_003Eb__3_1()
		{
		}
	}

	public Texture2D hello_texture;

	public Texture2D darawTexgture;

	private void OnGUI()
	{
	}

	private void OnImageSaved(UM_ImageSaveResult result)
	{
	}

	private void OnImage(UM_ImagePickResult result)
	{
	}
}
