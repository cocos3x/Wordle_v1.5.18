public class ByteByffer
{
	private byte[] _buffer;

	public int pointer;

	public byte[] buffer => null;

	public ByteByffer(byte[] buf)
	{
	}

	public byte ReadByte()
	{
		return 0;
	}

	public int ReadInt()
	{
		return 0;
	}

	public float ReadFloat()
	{
		return 0f;
	}

	public long ReadLong()
	{
		return 0L;
	}

	public bool ReadBool()
	{
		return false;
	}

	public short ReadShort()
	{
		//IL_0003: Expected I4, but got O
		return (short)(int)null;
	}

	public string ReadString(int length)
	{
		return "";
	}
}
