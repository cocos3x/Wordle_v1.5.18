using SA.Common.Animation;
using UnityEngine;
using UnityEngine.UI;

public class SA_Notifications_EditorUIController : MonoBehaviour
{
	public Text Title;

	public Text Message;

	public Image[] Icons;

	public SA_UIHightDependence HightDependence;

	private ValuesTween _CurrentTween;

	private void Awake()
	{
	}

	public void ShowNotification(string title, string message, SA_EditorNotificationType type)
	{
	}

	private void HandleOnInTweenComplete()
	{
	}

	private void NotificationDelayComplete()
	{
	}

	private void HandleOnOutTweenComplete()
	{
	}

	private void HandleOnValueChanged(float pos)
	{
	}

	private void Animate(float from, float to, EaseType easeType)
	{
	}
}
