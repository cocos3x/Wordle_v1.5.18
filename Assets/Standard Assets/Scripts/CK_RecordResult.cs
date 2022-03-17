using SA.Common.Models;

public class CK_RecordResult : Result
{
	private CK_Record _Record;

	private CK_Database _Database;

	public CK_Record Record => null;

	public CK_Database Database => null;

	public CK_RecordResult(int recordId)
	{
	}

	public CK_RecordResult(string errorData)
	{
	}

	public void SetDatabase(CK_Database database)
	{
	}
}
