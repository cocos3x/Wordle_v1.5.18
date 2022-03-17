using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SP_FB_API_v7 : SP_FB_API
{
	private const string PUBLISH_PERMISSION_STRING = "publish_actions";

	private string _UserId;

	private string _AccessToken;

	public bool IsLoggedIn => false;

	public string UserId => "";

	public string AccessToken => "";

	public string AppId => "";

	public static bool IsAPIEnabled => false;

	public void Init()
	{
	}

	public void Login(params string[] scopes)
	{
	}

	public void Logout()
	{
	}

	public void API(string query, FB_HttpMethod method, SPFacebook.FB_Delegate callback)
	{
	}

	public void API(string query, FB_HttpMethod method, SPFacebook.FB_Delegate callback, WWWForm form)
	{
	}

	public void AppRequest(string message, FB_RequestActionType actionType, string objectId, string[] to, string data = "", string title = "")
	{
	}

	public void AppRequest(string message, FB_RequestActionType actionType, string objectId, [Optional] List<object> filters, [Optional] string[] excludeIds, [Optional] int? maxRecipients, string data = "", string title = "")
	{
	}

	public void AppRequest(string message, [Optional] string[] to, [Optional] List<object> filters, [Optional] string[] excludeIds, [Optional] int? maxRecipients, string data = "", string title = "")
	{
	}

	public void FeedShare(string toId = "", string link = "", string linkName = "", string linkCaption = "", string linkDescription = "", string picture = "", string actionName = "", string actionLink = "", string reference = "")
	{
	}

	public void AppInvite(string appLink, string imgLink)
	{
	}
}
