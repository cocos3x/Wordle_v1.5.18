using System;

public class LocalNotificationTemplate
{
	private int _id;

	private string _title;

	private string _message;

	private DateTime _fireDate;

	private const string DATA_SPLITTER = "|||";

	public int id => 0;

	public string title => "";

	public string message => "";

	public DateTime fireDate => (DateTime)null;

	public string SerializedString => "";

	public bool IsFired => false;

	public LocalNotificationTemplate(string data)
	{
	}

	public LocalNotificationTemplate(int nId, string ttl, string msg, DateTime date)
	{
	}
}
