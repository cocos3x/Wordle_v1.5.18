using System.Collections.Generic;

public class MNPopup
{
	public delegate void MNPopupAction();

	protected Dictionary<string, MNPopupAction> actions;

	protected MNPopupAction dismissCallback;

	protected string title;

	protected string message;

	protected const int MAX_ACTIONS = 3;

	protected const string DISMISS_ACTION = "com.stansassets.action.dismiss";

	public string Title => "";

	public string Message => "";

	public Dictionary<string, MNPopupAction> Actions => null;

	public MNPopup(string title, string message)
	{
	}

	public void AddAction(string title, MNPopupAction callback)
	{
	}

	public void AddDismissListener(MNPopupAction callback)
	{
	}

	public void Show()
	{
	}

	private void OnPopupCompleted(string action)
	{
	}
}
