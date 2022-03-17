using System.Collections.Generic;

public class CK_Record
{
	private static Dictionary<int, CK_Record> _Records;

	private CK_RecordID _Id;

	private string _Type;

	private Dictionary<string, string> _Data;

	private int _internalId;

	public CK_RecordID Id => null;

	public string Type => "";

	public int Internal_Id => 0;

	public CK_Record(CK_RecordID id, string type)
	{
	}

	public CK_Record(string name, string template)
	{
	}

	public void SetObject(string key, string value)
	{
	}

	public string GetObject(string key)
	{
		return "";
	}

	private void IndexRecord()
	{
	}

	public void UpdateRecord()
	{
	}

	public static CK_Record GetRecordByInternalId(int id)
	{
		return null;
	}
}
