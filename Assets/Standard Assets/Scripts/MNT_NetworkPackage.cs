using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MNT_NetworkPackage
{
	protected MemoryStream buffer;

	protected BinaryWriter writer;

	protected ByteByffer _ReceivedDate;

	private int _Id;

	public int Id => 0;

	public ByteByffer ReceivedDate => null;

	public MNT_NetworkPackage(int id)
	{
	}

	public MNT_NetworkPackage(byte[] data)
	{
	}

	public byte[] GetBytes()
	{
		return null;
	}

	public string GetBase64DataFormat()
	{
		return "";
	}

	public void WriteValue<T>(T data)
	{
	}

	private void WriteMNTPack(MNT_NetworkPackage pack)
	{
	}

	public Vector3 ReadVector3()
	{
		return (Vector3)null;
	}

	public MNT_NetworkPackage ReadNetworkPackage()
	{
		return null;
	}

	public T ReadValue<T>()
	{
		return (T)null;
	}

	public void WriteList<T>(List<T> data)
	{
	}

	public List<T> ReadList<T>()
	{
		return null;
	}

	public void WriteArray<T>(T[] data)
	{
	}

	public T[] ReadArray<T>()
	{
		return null;
	}

	public void WriteDictionary<K, V>(Dictionary<K, V> data)
	{
	}

	public Dictionary<K, V> ReadDictionary<K, V>()
	{
		return null;
	}
}
