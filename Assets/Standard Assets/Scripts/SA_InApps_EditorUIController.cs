using SA.Common.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class SA_InApps_EditorUIController : MonoBehaviour
{
	public Text Title;

	public Text Describtion;

	public Text Price;

	public Toggle IsSuccsesPurchase;

	public Image Fader;

	public SA_UIHightDependence HightDependence;

	private ValuesTween _CurrentTween;

	private ValuesTween _FaderTween;

	private Action<bool> _OnComplete;

	private void Awake()
	{
	}

	public void ShowInAppPopup(string title, string describtion, string price, [Optional] Action<bool> OnComplete)
	{
	}

	public void Close()
	{
	}

	private void HandleOnInTweenComplete()
	{
	}

	private void HandleOnOutTweenComplete()
	{
	}

	private void HandleOnValueChanged(float pos)
	{
	}

	private void HandleOnFadeValueChanged(float a)
	{
	}

	private void HandleFadeComplete()
	{
	}

	private void FadeIn()
	{
	}

	private void FadeOut()
	{
	}

	private void Animate(float from, float to, EaseType easeType)
	{
	}
}
