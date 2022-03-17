using System;

public class IOSDialog : BaseIOSPopup
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<IOSDialogResult> _003C_003E9__9_0;

		internal void _003C_002Ector_003Eb__9_0(IOSDialogResult _003Cp0_003E)
		{
		}
	}

	public string yes;

	public string no;

	public event Action<IOSDialogResult> OnComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public static IOSDialog Create(string title, string message)
	{
		return null;
	}

	public static IOSDialog Create(string title, string message, string yes, string no)
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
