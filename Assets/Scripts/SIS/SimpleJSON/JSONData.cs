using System.IO;

namespace SIS.SimpleJSON
{
	public class JSONData : JSONNode
	{
		private string m_Data;

		public override string Value
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public JSONData(string aData)
		{
		}

		public JSONData(float aData)
		{
		}

		public JSONData(double aData)
		{
		}

		public JSONData(bool aData)
		{
		}

		public JSONData(int aData)
		{
		}

		public override string ToString()
		{
			return "";
		}

		public override string ToString(string aPrefix)
		{
			return "";
		}

		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
