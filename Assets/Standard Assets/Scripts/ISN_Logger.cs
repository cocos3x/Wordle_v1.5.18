using SA.Common.Pattern;
using UnityEngine;

public class ISN_Logger : Singleton<ISN_Logger>
{
	private void Awake()
	{
	}

	public void Create()
	{
	}

	public static void Log(object message, LogType logType = LogType.Log)
	{
	}

	private static void ISNEditorLog(LogType logType, object message)
	{
	}
}
