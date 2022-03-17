using SA.Common.Models;
using SA.IOSNative.Contacts;
using SA.IOSNative.Gestures;
using SA.IOSNative.Privacy;
using System;
using UnityEngine;

public class NativeIOSActionsExample : BaseIOSFeaturePreview
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<ISN_SwipeDirection> _003C_003E9__3_0;

		public static Action _003C_003E9__3_1;

		public static Action<ForceInfo> _003C_003E9__3_2;

		public static Action _003C_003E9__3_3;

		public static Action<string> _003C_003E9__3_4;

		public static Action<ContactsResult> _003C_003E9__4_0;

		public static Action<ContactsResult> _003C_003E9__4_1;

		public static Action<DateTime> _003C_003E9__4_2;

		public static Action<DateTime> _003C_003E9__4_3;

		public static Action<DateTime> _003C_003E9__4_4;

		public static Action<DateTime> _003C_003E9__4_5;

		public static Action<DateTime> _003C_003E9__4_6;

		public static Action<DateTime> _003C_003E9__4_7;

		public static Action<PermissionStatus> _003C_003E9__4_8;

		public static Action<PermissionStatus> _003C_003E9__4_9;

		public static Action<PermissionStatus> _003C_003E9__4_10;

		internal void _003CAwake_003Eb__3_0(ISN_SwipeDirection direction)
		{
		}

		internal void _003CAwake_003Eb__3_1()
		{
		}

		internal void _003CAwake_003Eb__3_2(ForceInfo info)
		{
		}

		internal void _003CAwake_003Eb__3_3()
		{
		}

		internal void _003CAwake_003Eb__3_4(string action)
		{
		}

		internal void _003COnGUI_003Eb__4_0(ContactsResult result)
		{
		}

		internal void _003COnGUI_003Eb__4_1(ContactsResult result)
		{
		}

		internal void _003COnGUI_003Eb__4_2(DateTime dateTime)
		{
		}

		internal void _003COnGUI_003Eb__4_3(DateTime dateTime)
		{
		}

		internal void _003COnGUI_003Eb__4_4(DateTime dateTime)
		{
		}

		internal void _003COnGUI_003Eb__4_5(DateTime dateTime)
		{
		}

		internal void _003COnGUI_003Eb__4_6(DateTime dateTime)
		{
		}

		internal void _003COnGUI_003Eb__4_7(DateTime dateTime)
		{
		}

		internal void _003COnGUI_003Eb__4_8(PermissionStatus permissionStatus)
		{
		}

		internal void _003COnGUI_003Eb__4_9(PermissionStatus permissionStatus)
		{
		}

		internal void _003COnGUI_003Eb__4_10(PermissionStatus permissionStatus)
		{
		}
	}

	public Texture2D hello_texture;

	public Texture2D drawTexture;

	private DateTime time;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	private void ShowDevoceInfo()
	{
	}

	private void OnDateChanged(DateTime time)
	{
	}

	private void OnPickerClosed(DateTime time)
	{
	}

	private void OnImage(IOSImagePickResult result)
	{
	}

	private void OnImageSaved(Result result)
	{
	}

	private void _003COnGUI_003Eb__4_11(ISN_FilePickerResult res)
	{
	}
}
