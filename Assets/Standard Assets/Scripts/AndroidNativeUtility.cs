using SA.Common.Pattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AndroidNativeUtility : Singleton<AndroidNativeUtility>
{
	private sealed class _003CGenerateRefreshTokenRequest_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string code;

		public string clientId;

		public string clientSecret;

		public string redirectUrl;

		private WWW _003Cresponse_003E5__2;

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
		public _003CGenerateRefreshTokenRequest_003Ed__58(int _003C_003E1__state)
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

	private sealed class _003CRefreshOAuthTokenRequest_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string clientId;

		public string clientSecret;

		public string refreshToken;

		private WWW _003Cresponse_003E5__2;

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
		public _003CRefreshOAuthTokenRequest_003Ed__59(int _003C_003E1__state)
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

	private sealed class _003CObtainUserDeviceCodeRequest_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string clientId;

		private WWW _003Cresponse_003E5__2;

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
		public _003CObtainUserDeviceCodeRequest_003Ed__60(int _003C_003E1__state)
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__70_0(AN_PackageCheckResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__70_1(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__70_2(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__70_3(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__70_4(AN_Locale _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__70_5(string[] _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__70_6(AN_NetworkInfo _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__70_7(AN_RefreshTokenResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__70_8(AN_AccessTokenResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__70_9(AN_DeviceCodeResult _003Cp0_003E)
		{
		}
	}

	private string _redirectUrl;

	private string _clientId;

	private string _clientSecret;

	public static int SDKLevel => 0;

	public static event Action<AN_PackageCheckResult> OnPackageCheckResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> OnAndroidIdLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> InternalStoragePathLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string> ExternalStoragePathLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<AN_Locale> LocaleInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string[]> ActionDevicePackagesListLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<AN_NetworkInfo> ActionNetworkInfoLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<AN_RefreshTokenResult> OnOAuthRefreshTokenLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<AN_AccessTokenResult> OnOAuthAccessTokenLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<AN_DeviceCodeResult> OnDeviceCodeLoaded
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

	public void GenerateRefreshToken(string redirectUrl, string clientId, string clientSecret)
	{
	}

	public void RefreshOAuthToken(string refreshToken, string clientId, string clientSecret)
	{
	}

	public void ObtainUserDeviceCode(string clientId)
	{
	}

	public void CheckIsPackageInstalled(string packageName)
	{
	}

	public void StartApplication(string bundle)
	{
	}

	public void StartApplication(string packageName, Dictionary<string, string> extras)
	{
	}

	public void LoadAndroidId()
	{
	}

	public void GetInternalStoragePath()
	{
	}

	public void GetExternalStoragePath()
	{
	}

	public string GetExternalStoragePublicDirectory(AN_ExternalStorageType type)
	{
		return "";
	}

	public void LoadLocaleInfo()
	{
	}

	public void LoadPackagesList()
	{
	}

	public void LoadNetworkInfo()
	{
	}

	public static void OpenSettingsPage(string action)
	{
	}

	public static void ShowPreloader(string title, string message)
	{
	}

	public static void ShowPreloader(string title, string message, AndroidDialogTheme theme)
	{
	}

	public static void HidePreloader()
	{
	}

	public static void OpenAppRatingPage(string url)
	{
	}

	public static void RedirectToGooglePlayRatingPage(string url)
	{
	}

	public static void HideCurrentPopup()
	{
	}

	public static void InvitePlusFriends()
	{
	}

	private void RefreshTokenCodeReceived(string data)
	{
	}

	private IEnumerator GenerateRefreshTokenRequest(string code, string clientId, string clientSecret, string redirectUrl)
	{
		return null;
	}

	private IEnumerator RefreshOAuthTokenRequest(string clientId, string clientSecret, string refreshToken)
	{
		return null;
	}

	private IEnumerator ObtainUserDeviceCodeRequest(string clientId)
	{
		return null;
	}

	private void OnAndroidIdLoadedEvent(string id)
	{
	}

	private void OnPacakgeFound(string packageName)
	{
	}

	private void OnPacakgeNotFound(string packageName)
	{
	}

	private void OnExternalStoragePathLoaded(string path)
	{
	}

	private void OnInternalStoragePathLoaded(string path)
	{
	}

	private void OnLocaleInfoLoaded(string data)
	{
	}

	private void OnPackagesListLoaded(string data)
	{
	}

	private void OnNetworkInfoLoaded(string data)
	{
	}
}
