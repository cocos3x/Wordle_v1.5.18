using System;

public class GK_SavedGame
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GK_SaveDataLoaded> _003C_003E9__10_0;

		internal void _003C_002Ector_003Eb__10_0(GK_SaveDataLoaded _003Cp0_003E)
		{
		}
	}

	private string _Id;

	private string _Name;

	private string _DeviceName;

	private DateTime _ModificationDate;

	private string _OriginalDateString;

	private byte[] _Data;

	private bool _IsDataLoaded;

	public string Id => "";

	public string Name => "";

	public string DeviceName => "";

	public DateTime ModificationDate => (DateTime)null;

	public string OriginalDateString => "";

	public byte[] Data => null;

	public bool IsDataLoaded => false;

	public event Action<GK_SaveDataLoaded> ActionDataLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public GK_SavedGame(string id, string name, string device, string dateString)
	{
	}

	public void LoadData()
	{
	}

	public void GenerateDataLoadEvent(string base64Data)
	{
	}

	public void GenerateDataLoadFailedEvent(string erorrData)
	{
	}
}
