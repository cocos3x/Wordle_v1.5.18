using SA.Common.Pattern;
using System;

public class AndroidApp : Singleton<AndroidApp>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<AndroidActivityResult> _003C_003E9__4_0;

		internal void _003C_002Ector_003Eb__4_0(AndroidActivityResult _003Cp0_003E)
		{
		}
	}

	public Action<AndroidActivityResult> OnActivityResult;

	private void Awake()
	{
	}

	public void ActivateListner()
	{
	}

	private void onActivityResult(string data)
	{
	}
}
