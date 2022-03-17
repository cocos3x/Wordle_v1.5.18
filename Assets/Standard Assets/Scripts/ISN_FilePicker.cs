using SA.Common.Pattern;
using System;

public class ISN_FilePicker : Singleton<ISN_FilePicker>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__7_0(ISN_FilePickerResult _003Cp0_003E)
		{
		}
	}

	public static event Action<ISN_FilePickerResult> MediaPickFinished
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

	public void PickFromCameraRoll(int maxItemsCount = 0)
	{
	}

	private void OnSelectImagesComplete(string data)
	{
	}
}
