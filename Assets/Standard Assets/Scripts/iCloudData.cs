using System.Collections.Generic;

public class iCloudData
{
	private string m_key;

	private string m_val;

	private bool m_IsEmpty;

	public string key => "";

	public string Key => "";

	public bool IsEmpty => false;

	public string stringValue => "";

	public string StringValue => "";

	public float floatValue => 0f;

	public float FloatValue => 0f;

	public byte[] bytesValue => null;

	public byte[] BytesValue => null;

	public List<object> ListValue => null;

	public Dictionary<string, object> DictionaryValue => null;

	public int IntValue => 0;

	public long LongValue => 0L;

	public ulong UlongValue => 0uL;

	public iCloudData(string k, string v)
	{
	}

	public T GetObject<T>()
	{
		return (T)null;
	}
}
