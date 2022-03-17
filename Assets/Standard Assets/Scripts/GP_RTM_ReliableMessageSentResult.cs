public class GP_RTM_ReliableMessageSentResult : GP_RTM_Result
{
	private int _MessageTokenId;

	private byte[] _Data;

	public int MessageTokenId => 0;

	public byte[] Data => null;

	public GP_RTM_ReliableMessageSentResult(string status, string roomId, int messageTokedId, byte[] data)
	{
	}
}
