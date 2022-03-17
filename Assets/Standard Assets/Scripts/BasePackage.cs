using System.IO;

public abstract class BasePackage
{
	protected MemoryStream buffer;

	protected BinaryWriter writer;

	public void initWriter()
	{
	}

	public abstract int getId();

	public byte[] getBytes()
	{
		return null;
	}

	public void send()
	{
	}

	public void writeInt(int val)
	{
	}

	public void writeString(string val)
	{
	}

	public void writeFloat(float val)
	{
	}
}
