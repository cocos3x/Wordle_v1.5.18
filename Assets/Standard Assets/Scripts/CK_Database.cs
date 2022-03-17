using System;
using System.Collections.Generic;

public class CK_Database
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<CK_RecordResult> _003C_003E9__14_0;

		public static Action<CK_RecordResult> _003C_003E9__14_1;

		public static Action<CK_RecordDeleteResult> _003C_003E9__14_2;

		public static Action<CK_QueryResult> _003C_003E9__14_3;

		internal void _003C_002Ector_003Eb__14_0(CK_RecordResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__14_1(CK_RecordResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__14_2(CK_RecordDeleteResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ector_003Eb__14_3(CK_QueryResult _003Cp0_003E)
		{
		}
	}

	private static Dictionary<int, CK_Database> _Databases;

	private int _InternalId;

	public int InternalId => 0;

	public event Action<CK_RecordResult> ActionRecordSaved
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<CK_RecordResult> ActionRecordFetchComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<CK_RecordDeleteResult> ActionRecordDeleted
	{
		add
		{
		}
		remove
		{
		}
	}

	public event Action<CK_QueryResult> ActionQueryComplete
	{
		add
		{
		}
		remove
		{
		}
	}

	public CK_Database(int internalId)
	{
	}

	public void SaveRecrod(CK_Record record)
	{
	}

	public void FetchRecordWithID(CK_RecordID recordId)
	{
	}

	public void DeleteRecordWithID(CK_RecordID recordId)
	{
	}

	public void PerformQuery(CK_Query query)
	{
	}

	public static CK_Database GetDatabaseByInternalId(int id)
	{
		return null;
	}

	public void FireSaveRecordResult(CK_RecordResult result)
	{
	}

	public void FireFetchRecordResult(CK_RecordResult result)
	{
	}

	public void FireDeleteRecordResult(CK_RecordDeleteResult result)
	{
	}

	public void FireQueryCompleteResult(CK_QueryResult result)
	{
	}
}
