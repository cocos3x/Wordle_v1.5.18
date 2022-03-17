using SA.Common.Pattern;
using System;

public class UM_Location : Singleton<UM_Location>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__7_0(UM_LocaleInfo _003Cp0_003E)
		{
		}
	}

	public static event Action<UM_LocaleInfo> OnLocaleLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public void GetLocale()
	{
	}

	private void HandleLocaleInfoLoaded_Android(AN_Locale locale)
	{
	}

	private void HandleOnLocaleLoaded_IOS(ISN_Locale locale)
	{
	}
}
