using UnityEngine;

public class AndroidNotificationBuilder
{
	public class NotificationColor
	{
		private Color _value;

		public Color Value => (Color)null;

		public NotificationColor(Color value)
		{
		}
	}

	private int _id;

	private string _title;

	private string _message;

	private int _time;

	private string _sound;

	private string _smallIcon;

	private bool _vibration;

	private bool _showIfAppForeground;

	private bool _repeating;

	private int _repeatDelay;

	private string _largeIcon;

	private Texture2D _bigPicture;

	private NotificationColor _color;

	private int _wakeLockTime;

	private const string SOUND_SILENT = "SOUND_SILENT";

	public int Id => 0;

	public string Title => "";

	public string Message => "";

	public int Time => 0;

	public NotificationColor Color => null;

	public string Sound => "";

	public string Icon => "";

	public bool Vibration => false;

	public bool ShowIfAppForeground => false;

	public bool Repeating => false;

	public int RepeatDelay => 0;

	public string LargeIcon => "";

	public Texture2D BigPicture => null;

	public int WakeLockTime => 0;

	public AndroidNotificationBuilder(int id, string title, string message, int time)
	{
	}

	public void SetColor(NotificationColor color)
	{
	}

	public void SetSoundName(string sound)
	{
	}

	public void SetIconName(string icon)
	{
	}

	public void SetVibration(bool vibration)
	{
	}

	public void SetSilentNotification()
	{
	}

	public void ShowIfAppIsForeground(bool show)
	{
	}

	public void SetRepeating(bool repeat)
	{
	}

	public void SetRepeatDelay(int delay)
	{
	}

	public void SetLargeIcon(string icon)
	{
	}

	public void SetBigPicture(Texture2D picture)
	{
	}

	public void SetWakeLockTime(int wakeTime)
	{
	}
}
