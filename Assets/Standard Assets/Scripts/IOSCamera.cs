using SA.Common.Models;
using SA.Common.Pattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class IOSCamera : Singleton<IOSCamera>
{
	private sealed class _003CSaveScreenshot_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IOSCamera _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSaveScreenshot_003Ed__23(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__25_0(IOSImagePickResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__25_1(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__25_2(string _003Cp0_003E)
		{
		}
	}

	private bool _IsWaitngForResponce;

	private bool _IsInitialized;

	public static event Action<IOSImagePickResult> OnImagePicked
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnImageSaved
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> OnVideoPathPicked
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

	public void Init()
	{
	}

	public void SaveTextureToCameraRoll(Texture2D texture)
	{
	}

	public void SaveScreenshotToCameraRoll()
	{
	}

	public void GetVideoPathFromAlbum()
	{
	}

	public void GetImageFromAlbum()
	{
	}

	public void GetImageFromCamera()
	{
	}

	public void PickImage(ISN_ImageSource source)
	{
	}

	private void OnImagePickedEvent(string data)
	{
	}

	private void OnImageSaveFailed()
	{
	}

	private void OnImageSaveSuccess()
	{
	}

	private void OnVideoPickedEvent(string path)
	{
	}

	private IEnumerator SaveScreenshot()
	{
		return null;
	}
}
