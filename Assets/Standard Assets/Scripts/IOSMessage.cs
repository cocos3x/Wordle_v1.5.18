using System;

public class IOSMessage : BaseIOSPopup
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__8_0;

		internal void _003C_002Ector_003Eb__8_0()
		{
		}
	}

	public string ok;

	public event Action OnComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public static IOSMessage Create(string title, string message)
	{
		return null;
	}

	public static IOSMessage Create(string title, string message, string ok)
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
