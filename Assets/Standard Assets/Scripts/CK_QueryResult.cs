using SA.Common.Models;
using System.Collections.Generic;

public class CK_QueryResult : Result
{
	private CK_Database _Database;

	private List<CK_Record> _Records;

	public CK_Database Database => null;

	public List<CK_Record> Records => null;

	public CK_QueryResult(List<CK_Record> records)
	{
	}

	public CK_QueryResult(string errorData)
	{
	}

	public void SetDatabase(CK_Database database)
	{
	}
}
