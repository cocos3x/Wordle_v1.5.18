using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class FacebookApiTab : FeatureTab
{
	private sealed class _003CPostFBScreenshot_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CPostFBScreenshot_003Ed__27(int _003C_003E1__state)
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

	private sealed class _003CPostScreenshot_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CPostScreenshot_003Ed__65(int _003C_003E1__state)
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

	private static bool IsFrindsInfoLoaded;

	private static bool IsAuntificated;

	public Button[] ConnectionDependedntButtons;

	public Text ConnectButtonText;

	public Button ConnectButton;

	public Image Avatar;

	private Sprite AvatarSprite;

	public Text Location;

	public Text Language;

	public Text Mail;

	public Text Name;

	public Text f1Name;

	public Text f2Name;

	public Image f1ProfileLogo;

	public Image f2ProfileLogo;

	private Sprite f1Avatar;

	private Sprite f2Avatar;

	public Texture2D ImageToShare;

	public GameObject friends;

	private int startScore;

	private string UNION_ASSETS_PAGE_ID;

	private void Awake()
	{
	}

	private void HandleOnRevokePermission(FB_Result result)
	{
	}

	private void FixedUpdate()
	{
	}

	public void PostWithAuthCheck()
	{
	}

	public void PostNativeScreenshot()
	{
	}

	public void PostImage()
	{
	}

	private IEnumerator PostFBScreenshot()
	{
		return null;
	}

	public void Connect()
	{
	}

	public void LoadUserData()
	{
	}

	public void PostMessage()
	{
	}

	public void PostScreehShot()
	{
	}

	public void LoadFriends()
	{
	}

	public void AppRequest()
	{
	}

	public void LoadScore()
	{
	}

	public void LoadAppScores()
	{
	}

	public void SubmitScore()
	{
	}

	public void DeletePlayerScores()
	{
	}

	public void LikePage()
	{
	}

	public void CheckLike()
	{
	}

	public void ActivateApp()
	{
	}

	public void AchievedLevel()
	{
	}

	public void AddedPaymentInfo()
	{
	}

	public void AddedToCart()
	{
	}

	public void AddedToWishlist()
	{
	}

	public void CompletedRegistration()
	{
	}

	public void InitiatedCheckout()
	{
	}

	public void Purchased()
	{
	}

	public void Rated()
	{
	}

	public void Searched()
	{
	}

	public void SpentCredits()
	{
	}

	public void UnlockedAchievement()
	{
	}

	public void ViewedContent()
	{
	}

	private void OnLikesLoaded(FB_Result result)
	{
	}

	private void OnFocusChanged(bool focus)
	{
	}

	private void OnUserDataLoaded(FB_Result result)
	{
	}

	private void OnFriendsDataLoaded(FB_Result res)
	{
	}

	private void OnInit()
	{
	}

	private void OnAuth(FB_Result result)
	{
	}

	private void OnPost(FB_PostResult res)
	{
	}

	private void OnPlayerScoreRequestComplete(FB_Result result)
	{
	}

	private void OnAppScoreRequestComplete(FB_Result result)
	{
	}

	private void OnSubmitScoreRequestComplete(FB_Result result)
	{
	}

	private void OnDeleteScoreRequestComplete(FB_Result result)
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
