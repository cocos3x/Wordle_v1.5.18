using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class GoogleCloudMessageService : Singleton<GoogleCloudMessageService>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__38_0(string _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__38_1(GP_GCM_RegistrationResult _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__38_2(string _003Cp0_003E, Dictionary<string, object> _003Cp1_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__38_3(string _003Cp0_003E, Dictionary<string, object> _003Cp1_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__38_4(string _003Cp0_003E, Dictionary<string, object> _003Cp1_003E)
		{
		}
	}

	private string _lastMessage;

	private string _registrationId;

	public string registrationId => "";

	public string lastMessage => "";

	public static event Action<string> ActionCouldMessageLoaded
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<GP_GCM_RegistrationResult> ActionCMDRegistrationResult
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string, Dictionary<string, object>> ActionGCMPushLaunched
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string, Dictionary<string, object>> ActionGCMPushReceived
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<string, Dictionary<string, object>> ActionParsePushReceived
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

	public void InitOneSignalNotifications()
	{
	}

	public void InitPushNotifications()
	{
	}

	public void InitPushNotifications(string smallIcon, string largeIcon, string sound, bool enableVibrationPush, bool showWhenAppForeground, bool replaceOldNotificationWithNew, string color)
	{
	}

	public void InitParsePushNotifications()
	{
	}

	public void RgisterDevice()
	{
	}

	public void LoadLastMessage()
	{
	}

	public void RemoveLastMessageInfo()
	{
	}

	public void HideAll()
	{
	}

	private void HandleOnPushReceived(string stringPayload, Dictionary<string, object> payload)
	{
	}

	private void GCMNotificationCallback(string data)
	{
	}

	private void GCMNotificationLaunchedCallback(string data)
	{
	}

	private void OnLastMessageLoaded(string data)
	{
	}

	private void OnRegistrationReviced(string regId)
	{
	}

	private void OnRegistrationFailed()
	{
	}
}
