using SA.Common.Pattern;
using UnityEngine;

public class UM_ExampleStatusBar : Singleton<UM_ExampleStatusBar>
{
	public string _text;

	private float h;

	private GUIStyle style;

	public static string text
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}
}
