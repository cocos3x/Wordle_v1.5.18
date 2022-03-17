using SA.Common.Pattern;
using SA.IOSNative.Models;
using SA.IOSNative.UserNotifications;
using System;

namespace SA.IOSNative.Core
{
	public class AppController : Singleton<AppController>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			internal void _003C_002Ecctor_003Eb__38_0()
			{
			}

			internal void _003C_002Ecctor_003Eb__38_1()
			{
			}

			internal void _003C_002Ecctor_003Eb__38_2()
			{
			}

			internal void _003C_002Ecctor_003Eb__38_3()
			{
			}

			internal void _003C_002Ecctor_003Eb__38_4()
			{
			}

			internal void _003C_002Ecctor_003Eb__38_5(LaunchUrl _003Cp0_003E)
			{
			}

			internal void _003C_002Ecctor_003Eb__38_6(UniversalLink _003Cp0_003E)
			{
			}
		}

		public static LaunchUrl LaunchUrl => null;

		public static UniversalLink LaunchUniversalLink => null;

		public static NotificationRequest LaunchNotification => null;

		public static event Action OnApplicationDidEnterBackground
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnApplicationDidBecomeActive
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnApplicationDidReceiveMemoryWarning
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnApplicationWillResignActive
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnApplicationWillTerminate
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<LaunchUrl> OnOpenURL
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<UniversalLink> OnContinueUserActivity
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

		public static void Subscribe()
		{
		}

		private void openURL(string data)
		{
		}

		private void continueUserActivity(string absoluteUrl)
		{
		}

		private void applicationDidEnterBackground()
		{
		}

		private void applicationDidBecomeActive()
		{
		}

		private void applicationDidReceiveMemoryWarning()
		{
		}

		private void applicationWillResignActive()
		{
		}

		private void applicationWillTerminate()
		{
		}

		protected override void OnApplicationQuit()
		{
		}
	}
}
