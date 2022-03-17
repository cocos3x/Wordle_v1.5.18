using System.Collections.Generic;
using System.IO;

public class MNT_BinaryWriter
{
	protected BinaryWriter writer;

	protected MemoryStream buffer;

	public byte[] GetBytes()
	{
		return null;
	}

	public void WriteValue<T>(T data)
	{
	}

	public void WriteList<T>(List<T> data)
	{
	}

	public void WriteArray<T>(T[] data)
	{
	}

	public void WriteDictionary<K, V>(Dictionary<K, V> data)
	{
	}
}
