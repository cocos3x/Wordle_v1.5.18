using System;

public class ISN_LocalNotification
{
	private int _Id;

	private DateTime _Date;

	private string _Message;

	private bool _UseSound;

	private int _Badges;

	private string _Data;

	private string _SoundName;

	private const string DATA_SPLITTER = "|||";

	public int Id => 0;

	public DateTime Date => (DateTime)null;

	public bool IsFired => false;

	public string Message => "";

	public bool UseSound => false;

	public int Badges => 0;

	public string Data => "";

	public string SoundName => "";

	public string SerializedString => "";

	public ISN_LocalNotification(DateTime time, string message, bool useSound = true)
	{
	}

	public ISN_LocalNotification(string serializaedNotificationData)
	{
	}

	public void SetId(int id)
	{
	}

	public void SetData(string data)
	{
	}

	public void SetSoundName(string soundName)
	{
	}

	public void SetBadgesNumber(int badges)
	{
	}

	public void Schedule()
	{
	}
}
