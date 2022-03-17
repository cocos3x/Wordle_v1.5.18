using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MNP_EditorUIController : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public MNPopup.MNPopupAction a;

		public MNP_EditorUIController _003C_003E4__this;

		internal void _003CSetActions_003Eb__0()
		{
		}
	}

	[SerializeField]
	private GameObject Root;

	[SerializeField]
	private Text Title;

	[SerializeField]
	private Text Message;

	[SerializeField]
	private MNP_UIButton[] UIButtons;

	private MNPopup.MNPopupAction dismiss;

	private bool isActive;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Hide()
	{
	}

	public void SetTitle(string title)
	{
	}

	public void SetMessage(string message)
	{
	}

	public void SetActions(Dictionary<string, MNPopup.MNPopupAction> actions, MNPopup.MNPopupAction dismissAction)
	{
	}

	public void Show()
	{
	}

	public void OnDismiss()
	{
	}
}
