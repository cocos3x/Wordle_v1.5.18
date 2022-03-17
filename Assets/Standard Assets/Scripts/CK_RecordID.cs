using System.Collections.Generic;

public class CK_RecordID
{
	private int _internalId;

	private string _Name;

	private static Dictionary<int, CK_RecordID> _Ids;

	public string Name => "";

	public int Internal_Id => 0;

	public CK_RecordID(string recordName)
	{
	}

	public static CK_RecordID GetRecordIdByInternalId(int id)
	{
		return null;
	}
}
