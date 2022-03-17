using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class TwitterApiTab : FeatureTab
{
	private sealed class _003CPostTWScreenshot_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPostTWScreenshot_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CPostScreenshot_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPostScreenshot_003Ed__39(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private static bool IsUserInfoLoaded;

	private static bool IsAuthenticated;

	public Texture2D ImageToShare;

	public Text ConnectButtonText;

	public Button ConnectButton;

	public Image Avatar;

	public Text Location;

	public Text Language;

	public Text Status;

	public Text Name;

	public Button[] AuthDependedButtons;

	private Sprite AvatarSprite;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Connect()
	{
	}

	public void PostWithAuthCheck()
	{
	}

	public void PostNativeScreenshot()
	{
	}

	public void PostMSG()
	{
	}

	public void PostImage()
	{
	}

	private IEnumerator PostTWScreenshot()
	{
		return null;
	}

	public void LoadUserData()
	{
	}

	private void Test()
	{
	}

	private void OnResult(TW_APIRequstResult result)
	{
	}

	public void PostMessage()
	{
	}

	public void PostScreehShot()
	{
	}

	private void OnUserDataRequestCompleteAction(TWResult result)
	{
	}

	private void OnPostingCompleteAction(TWResult result)
	{
	}

	private void OnAuthCompleteAction(TWResult result)
	{
	}

	private void OnTwitterInitedAction(TWResult result)
	{
	}

	private void OnAuth()
	{
	}

	public void RetrieveTimeLine()
	{
	}

	public void UserLookUpRequest()
	{
	}

	public void FriedsidsRequest()
	{
	}

	public void FollowersidsRequest()
	{
	}

	public void TweetSearch()
	{
	}

	private void OnIdsLoaded(TW_APIRequstResult result)
	{
	}

	private void OnLookUpRequestComplete(TW_APIRequstResult result)
	{
	}

	private void OnSearchRequestComplete(TW_APIRequstResult result)
	{
	}

	private void OnTimeLineRequestComplete(TW_APIRequstResult result)
	{
	}

	private IEnumerator PostScreenshot()
	{
		return null;
	}

	private void LogOut()
	{
	}
}
