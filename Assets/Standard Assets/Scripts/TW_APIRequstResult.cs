using System.Collections.Generic;

public class TW_APIRequstResult
{
	public List<TweetTemplate> tweets;

	public List<TwitterUserInfo> users;

	public List<string> ids;

	private bool _IsSucceeded;

	private string _data;

	public bool IsSucceeded => false;

	public string responce => "";

	public TW_APIRequstResult(bool IsResSucceeded, string resData)
	{
	}
}
