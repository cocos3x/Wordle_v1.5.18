using System;

public class IOSRateUsPopUp : BaseIOSPopup
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<IOSDialogResult> _003C_003E9__11_0;

		internal void _003C_002Ector_003Eb__11_0(IOSDialogResult _003Cp0_003E)
		{
		}
	}

	public string rate;

	public string remind;

	public string declined;

	public event Action<IOSDialogResult> OnComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public static IOSRateUsPopUp Create()
	{
		return null;
	}

	public static IOSRateUsPopUp Create(string title, string message)
	{
		return null;
	}

	public static IOSRateUsPopUp Create(string title, string message, string rate, string remind, string declined)
	{
		return null;
	}

	public void init()
	{
	}

	public void onPopUpCallBack(string buttonIndex)
	{
	}
}
