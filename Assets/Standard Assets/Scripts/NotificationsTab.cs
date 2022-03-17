using System.Collections.Generic;
using UnityEngine;

public sealed class NotificationsTab : FeatureTab
{
	[SerializeField]
	private Texture2D bigPicture;

	private int LastNotificationId;

	private void Awake()
	{
	}

	public void OnShowToastButton()
	{
	}

	public void OnScheduleLocal()
	{
	}

	public void OnCancelLastLocal()
	{
	}

	public void OnCancelAll()
	{
	}

	public void OnRegisterDevice()
	{
	}

	public void OnLoadLastGcmMessage()
	{
	}

	private void HandleActionGCMPushReceived(string message, Dictionary<string, object> data)
	{
	}

	private void HandleActionGCMPushLaunched(string message, Dictionary<string, object> data)
	{
	}

	private void HandleActionCMDRegistrationResult(GP_GCM_RegistrationResult res)
	{
	}

	private void OnNotificationIdLoaded(int notificationid)
	{
	}

	private void OnMessageLoaded(string msg)
	{
	}
}
