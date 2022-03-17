using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace SA.Analytics.Google
{
	public class Manager : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static UnityAction<Scene, LoadSceneMode> _003C_003E9__8_0;

			internal void _003CAwake_003Eb__8_0(Scene arg0, LoadSceneMode arg1)
			{
			}
		}

		private sealed class _003CSendAnalytics_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public byte[] data;

			public string cache;

			private WWW _003Cwww_003E5__2;

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
			public _003CSendAnalytics_003Ed__37(int _003C_003E1__state)
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

		public const string GOOGLE_ANALYTICS_CLIENTID_PREF_KEY = "google_analytics_clientid_pref_key";

		public const string GOOGLE_ANALYTICS_SYSTEM_INFO_SUBMITED = "system_info_submited";

		public const string SYSTEM_INFO = "SystemInfo";

		private static Manager Instance;

		private static string _ClientId;

		private static Client cleint;

		private static string CurrentLevelName;

		private static bool IsSessionStarted;

		private string _003CCampaignSource_003Ek__BackingField;

		private string _003CCampaignName_003Ek__BackingField;

		private string _003CCampaignContent_003Ek__BackingField;

		private static System.Random random;

		public string CampaignSource
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public string CampaignName
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public string CampaignContent
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public static Client Client => null;

		public static string ClientId => "";

		public static string LoadedLevelName => "";

		private void Awake()
		{
		}

		public static void SetTrackingId(string TrackingId)
		{
		}

		public static void StartTracking()
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void HandleLog(string logString, string stackTrace, LogType type)
		{
		}

		private void OnReferalIntentReciver(string referrerString)
		{
		}

		public static void SubmitSystemInfo()
		{
		}

		public static void RestorePrefKeys()
		{
		}

		public static void Send(string request)
		{
		}

		public static WWW SendSkipCache(string request)
		{
			return null;
		}

		private IEnumerator SendAnalytics(byte[] data, string cache)
		{
			return null;
		}

		private static void SendFirstScreenHit()
		{
		}

		private static void TrackNewLevel()
		{
		}

		private static void GenerateClientId()
		{
		}

		private static string RandomString(int size)
		{
			return "";
		}
	}
}
