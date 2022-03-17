using SA.Common.Pattern;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SPFacebook : Singleton<SPFacebook>
{
	public delegate void FB_Delegate(FB_Result result);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__161_0()
		{
		}

		internal void _003C_002Ecctor_003Eb__161_1()
		{
		}

		internal void _003C_002Ecctor_003Eb__161_2()
		{
		}

		internal void _003C_002Ecctor_003Eb__161_3()
		{
		}

		internal void _003C_002Ecctor_003Eb__161_4(FB_AppInviteResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_5()
		{
		}

		internal void _003C_002Ecctor_003Eb__161_6(FB_PostResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_7(bool _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_8(FB_LoginResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_9(FB_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_10(FB_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_11(FB_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_12(FB_AppRequestResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_13(FB_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_14(FB_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_15(FB_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_16(FB_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_17(FB_Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__161_18(FB_Result _003Cp0_003E)
		{
		}
	}

	private FB_UserInfo _userInfo;

	private Dictionary<string, FB_UserInfo> _friends;

	private Dictionary<string, FB_UserInfo> _invitableFriends;

	private bool _IsInited;

	private Dictionary<string, FB_Score> _userScores;

	private Dictionary<string, FB_Score> _appScores;

	private int lastSubmitedScore;

	private Dictionary<string, Dictionary<string, FB_LikeInfo>> _likes;

	private List<FB_AppRequest> _AppRequests;

	private SP_FB_API _FB;

	public bool IsInited => false;

	public bool IsLoggedIn => false;

	public string UserId => "";

	public string AccessToken => "";

	public string AppId => "";

	public FB_UserInfo userInfo => null;

	public Dictionary<string, FB_UserInfo> friends => null;

	public Dictionary<string, FB_UserInfo> InvitableFriends => null;

	public List<string> friendsIds => null;

	public List<string> InvitableFriendsIds => null;

	public List<FB_UserInfo> friendsList => null;

	public List<FB_UserInfo> InvitableFriendsList => null;

	public Dictionary<string, FB_Score> userScores => null;

	public Dictionary<string, FB_Score> appScores => null;

	public List<FB_Score> applicationScoreList => null;

	public List<FB_AppRequest> AppRequests => null;

	public SP_FB_API FB => null;

	public static event Action OnPostStarted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnLoginStarted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnLogOut
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnFriendsRequestStarted
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_AppInviteResult> OnAppInviteSent
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action OnInitCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_PostResult> OnPostingCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<bool> OnFocusChangedAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_LoginResult> OnAuthCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_Result> OnUserDataRequestCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_Result> OnFriendsDataRequestCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_Result> OnInvitableFriendsDataRequestCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_AppRequestResult> OnAppRequestCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_Result> OnAppRequestsLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_Result> OnAppScoresRequestCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_Result> OnPlayerScoresRequestCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_Result> OnSubmitScoreRequestCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_Result> OnDeleteScoresRequestCompleteAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<FB_Result> OnLikesListLoadedAction
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void Login()
	{
	}

	public void Login(params string[] scopes)
	{
	}

	public void SendAppInvite(string appLinkUrl, string previewImageUrl)
	{
	}

	public void Logout()
	{
	}

	public void LoadUserData()
	{
	}

	public void LoadInvitableFrientdsInfo(int limit)
	{
	}

	public FB_UserInfo GetInvitableFriendById(string id)
	{
		return null;
	}

	public void LoadFrientdsInfo(int limit)
	{
	}

	public FB_UserInfo GetFriendById(string id)
	{
		return null;
	}

	public void PostImage(string caption, Texture2D image)
	{
	}

	public void PostText(string message)
	{
	}

	public void FeedShare(string toId = "", string link = "", string linkName = "", string linkCaption = "", string linkDescription = "", string picture = "", string actionName = "", string actionLink = "", string reference = "")
	{
	}

	public void SendTrunRequest(string title, string message, string data = "", [Optional] string[] to)
	{
	}

	public void SendGift(string title, string message, string objectId, string data = "", [Optional] string[] to)
	{
	}

	public void AskGift(string title, string message, string objectId, string data = "", [Optional] string[] to)
	{
	}

	public void SendInvite(string title, string message, string data = "", [Optional] string[] to)
	{
	}

	private void OnAppRequestFailed_AndroidCB(string error)
	{
	}

	private void OnAppRequestCompleted_AndroidCB(string data)
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

	public void LoadPendingRequests()
	{
	}

	private void OnRequestsLoadComplete(FB_Result result)
	{
	}

	public void LoadPlayerScores()
	{
	}

	public void LoadAppScores()
	{
	}

	public void SubmitScore(int score)
	{
	}

	public void DeletePlayerScores()
	{
	}

	public void LoadCurrentUserLikes()
	{
	}

	public void LoadLikes(string userId)
	{
	}

	public void LoadLikes(string userId, string pageId)
	{
	}

	public FB_Score GetCurrentPlayerScoreByAppId(string appId)
	{
		return null;
	}

	public int GetCurrentPlayerIntScoreByAppId(string appId)
	{
		return 0;
	}

	public int GetScoreByUserId(string userId)
	{
		return 0;
	}

	public FB_Score GetScoreObjectByUserId(string userId)
	{
		return null;
	}

	public List<FB_LikeInfo> GerUserLikesList(string userId)
	{
		return null;
	}

	public bool IsUserLikesPage(string userId, string pageId)
	{
		return false;
	}

	private void OnUserLikesResult(FB_Result result, FB_LikesRetrieveTask task)
	{
	}

	private void OnScoreDeleted(FB_Result result)
	{
	}

	private void OnScoreSubmited(FB_Result result)
	{
	}

	private void OnAppScoresComplete(FB_Result result)
	{
	}

	private void AddToAppScores(FB_Score score)
	{
	}

	private void AddToUserScores(FB_Score score)
	{
	}

	private void OnLoaPlayrScoresComplete(FB_Result result)
	{
	}

	public void ParseInvitableFriendsData(string data)
	{
	}

	private void ParseFriendsFromJson(string data, Dictionary<string, FB_UserInfo> friends, bool invitable = false)
	{
	}

	public void ParseFriendsData(string data)
	{
	}

	public void OnInitComplete()
	{
	}

	public void OnHideUnity(bool isGameShown)
	{
	}

	public void LoginCallback(FB_LoginResult result)
	{
	}

	private void PostCallback_Internal(FB_Result result)
	{
	}

	public void PostCallback(FB_PostResult result)
	{
	}

	public void AppRequestCallback(FB_AppRequestResult result)
	{
	}

	public void AppInviteResultCallback(FB_AppInviteResult result)
	{
	}

	private void UserDataCallBack(FB_Result result)
	{
	}

	private void InvitableFriendsDataCallBack(FB_Result result)
	{
	}

	private void FriendsDataCallBack(FB_Result result)
	{
	}
}
