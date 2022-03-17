using System;

public class AndroidMessage : BaseAndroidPopup
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__9_0;

		internal void _003C_002Ector_003Eb__9_0()
		{
		}
	}

	public string ok;

	public Action OnComplete;

	public static AndroidMessage Create(string title, string message)
	{
		return null;
	}

	public static AndroidMessage Create(string title, string message, AndroidDialogTheme theme)
	{
		return null;
	}

	public static AndroidMessage Create(string title, string message, string ok)
	{
		return null;
	}

	public static AndroidMessage Create(string title, string message, string ok, AndroidDialogTheme theme)
	{
		return null;
	}

	public void init()
	{
	}

	public void init(AndroidDialogTheme theme)
	{
	}

	public void onPopUpCallBack(string buttonIndex)
	{
	}
}
