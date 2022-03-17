using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public interface SP_FB_API
{
	bool IsLoggedIn
	{
		get;
	}

	string UserId
	{
		get;
	}

	string AccessToken
	{
		get;
	}

	string AppId
	{
		get;
	}

	void Init();

	void Login(params string[] scopes);

	void Logout();

	void API(string query, FB_HttpMethod method, SPFacebook.FB_Delegate callback);

	void API(string query, FB_HttpMethod method, SPFacebook.FB_Delegate callback, WWWForm form);

	void AppInvite(string appLinkUrl, string previewImgUrl);

	void AppRequest(string message, FB_RequestActionType actionType, string objectId, string[] to, string data = "", string title = "");

	void AppRequest(string message, FB_RequestActionType actionType, string objectId, [Optional] List<object> filters, [Optional] string[] excludeIds, [Optional] int? maxRecipients, string data = "", string title = "");

	void AppRequest(string message, [Optional] string[] to, [Optional] List<object> filters, [Optional] string[] excludeIds, [Optional] int? maxRecipients, string data = "", string title = "");

	void FeedShare(string toId = "", string link = "", string linkName = "", string linkCaption = "", string linkDescription = "", string picture = "", string actionName = "", string actionLink = "", string reference = "");
}
