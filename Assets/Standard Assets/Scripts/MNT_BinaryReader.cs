using System.Collections.Generic;

public class MNT_BinaryReader
{
	protected ByteByffer _ReceivedDate;

	public ByteByffer ReceivedDate => null;

	public MNT_BinaryReader(byte[] data)
	{
	}

	public T ReadValue<T>()
	{
		return (T)null;
	}

	public List<T> ReadList<T>()
	{
		return null;
	}

	public T[] ReadArray<T>()
	{
		return null;
	}

	public Dictionary<K, V> ReadDictionary<K, V>()
	{
		return null;
	}
}
