using System.Collections.Generic;

public class FB_AppInviteResult : FB_Result
{
	private bool _cancelled;

	private IDictionary<string, object> _resultDictionary;

	public bool Cancelled => false;

	public IDictionary<string, object> ResultDictionary => null;

	public FB_AppInviteResult(bool cancelled, string RawData, string Error, IDictionary<string, object> dict)
	{
	}
}
