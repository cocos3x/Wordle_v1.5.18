using SA.Common.Pattern;
using System;

public class AndroidAppInfoLoader : Singleton<AndroidAppInfoLoader>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__7_0(PackageAppInfo _003Cp0_003E)
		{
		}
	}

	public PackageAppInfo PacakgeInfo;

	public static event Action<PackageAppInfo> ActionPacakgeInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public void LoadPackageInfo()
	{
	}

	private void OnPackageInfoLoaded(string data)
	{
	}
}
