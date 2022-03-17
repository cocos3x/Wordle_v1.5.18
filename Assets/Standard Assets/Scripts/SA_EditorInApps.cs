using System;
using System.Runtime.InteropServices;

public class SA_EditorInApps
{
	private static SA_InApps_EditorUIController _EditorUI;

	private static SA_InApps_EditorUIController EditorUI => null;

	public static void ShowInAppPopup(string title, string describtion, string price, [Optional] Action<bool> OnComplete)
	{
	}
}
