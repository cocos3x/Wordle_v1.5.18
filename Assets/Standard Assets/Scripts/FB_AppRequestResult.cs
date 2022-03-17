using System.Collections.Generic;

public class FB_AppRequestResult : FB_Result
{
	private string _ReuqestId;

	private List<string> _Recipients;

	public string ReuqestId => "";

	public List<string> Recipients => null;

	public FB_AppRequestResult(string RawData, string Error)
	{
	}

	public FB_AppRequestResult(string requestId, List<string> _recipients, string RawData)
	{
	}
}
