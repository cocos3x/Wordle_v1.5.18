public class MNT_PlayerTemplate
{
	private string _id;

	private string _name;

	private byte[] _info;

	private bool _IsServer;

	private string _deviceName;

	private string _macAddress;

	private string _externalIP;

	private int _externalPort;

	private string _guid;

	private string _ipAddress;

	private int _port;

	public string id => "";

	public string name => "";

	public byte[] info => null;

	public bool IsServer => false;

	public string deviceName => "";

	public string macAddress => "";

	public string externalIP => "";

	public int externalPort => 0;

	public string guid => "";

	public string ipAddress => "";

	public int port => 0;

	public MNT_PlayerTemplate(string pId, string pName, byte[] pInfo)
	{
	}

	public MNT_PlayerTemplate(MNT_PlayerTemplate player)
	{
	}

	public MNT_PlayerTemplate(MNT_BluetoothDeviceTemplate device)
	{
	}

	public void SetInfo(string playerName, byte[] PlayerInfo, bool IsServerPlayer = false)
	{
	}
}
