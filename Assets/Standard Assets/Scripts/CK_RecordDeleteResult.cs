using SA.Common.Models;

public class CK_RecordDeleteResult : Result
{
	private CK_RecordID _RecordID;

	private CK_Database _Database;

	public CK_Database Database => null;

	public CK_RecordID RecordID => null;

	public CK_RecordDeleteResult(int recordId)
	{
	}

	public CK_RecordDeleteResult(string errorData)
	{
	}

	public void SetDatabase(CK_Database database)
	{
	}
}
