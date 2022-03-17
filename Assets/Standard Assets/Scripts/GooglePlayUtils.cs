using SA.Common.Pattern;
using System;

public class GooglePlayUtils : Singleton<GooglePlayUtils>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__5_0(GP_AdvertisingIdLoadResult _003Cp0_003E)
		{
		}
	}

	public static Action<GP_AdvertisingIdLoadResult> ActionAdvertisingIdLoaded;

	private void Awake()
	{
	}

	public void GetAdvertisingId()
	{
	}

	private void OnAdvertisingIdLoaded(string data)
	{
	}
}
