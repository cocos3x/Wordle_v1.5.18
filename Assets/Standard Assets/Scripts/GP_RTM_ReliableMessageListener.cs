public class GP_RTM_ReliableMessageListener
{
	private byte[] _Data;

	private int _DataTokenId;

	private int _ReliableMessagesCounter;

	public int DataTokenId => 0;

	public byte[] Data => null;

	public GP_RTM_ReliableMessageListener(int dataTokenId, byte[] data)
	{
	}

	public void ReportSentMessage()
	{
	}

	public void ReportDeliveredMessage()
	{
	}
}
