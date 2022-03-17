using SA.Common.Pattern;
using System;

public class TVAppController : Singleton<TVAppController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__10_0()
		{
		}
	}

	private bool _IsRuningOnTVDevice;

	public bool IsRuningOnTVDevice => false;

	public static event Action DeviceTypeChecked
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

	public void CheckForATVDevice()
	{
	}

	private void OnDeviceStateResponce(string data)
	{
	}
}
