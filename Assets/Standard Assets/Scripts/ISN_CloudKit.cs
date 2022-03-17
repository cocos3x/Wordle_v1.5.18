using SA.Common.Pattern;

public class ISN_CloudKit : Singleton<ISN_CloudKit>
{
	private CK_Database _PrivateDB;

	private CK_Database _PublicDB;

	private const int PUBLIC_DB_KEY = -1;

	private const int PRIVATE_DB_KEY = -2;

	public CK_Database PrivateDB => null;

	public CK_Database PublicDB => null;

	private void Awake()
	{
	}

	private void OnSaveRecordSuccess(string data)
	{
	}

	private void OnSaveRecordFailed(string data)
	{
	}

	private void OnDeleteRecordSuccess(string data)
	{
	}

	private void OnDeleteRecordFailed(string data)
	{
	}

	private void OnPerformQuerySuccess(string data)
	{
	}

	private void OnPerformQueryFailed(string data)
	{
	}

	private void OnFetchRecordSuccess(string data)
	{
	}

	private void OnFetchRecordFailed(string data)
	{
	}

	public static void CreateRecordId_Object(int recordId, string name)
	{
	}

	public static void UpdateRecord_Object(int ID, string type, string keys, string values, int recordId)
	{
	}

	public static void SaveRecord(int dbId, int recordId)
	{
	}

	public static void DeleteRecord(int dbId, int recordId)
	{
	}

	public static void FetchRecord(int dbId, int recordId)
	{
	}

	public static void PerformQuery(int dbId, string query, string type)
	{
	}
}
