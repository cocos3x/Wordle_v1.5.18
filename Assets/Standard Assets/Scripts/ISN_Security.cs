using SA.Common.Models;
using SA.Common.Pattern;
using System;

public class ISN_Security : Singleton<ISN_Security>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__12_0(ISN_LocalReceiptResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__12_1(Result _003Cp0_003E)
		{
		}
	}

	public static event Action<ISN_LocalReceiptResult> OnReceiptLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<Result> OnReceiptRefreshComplete
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

	public void RetrieveLocalReceipt()
	{
	}

	public void StartReceiptRefreshRequest()
	{
	}

	private void Event_ReceiptLoaded(string data)
	{
	}

	private void Event_ReceiptRefreshRequestReceived(string data)
	{
	}
}
