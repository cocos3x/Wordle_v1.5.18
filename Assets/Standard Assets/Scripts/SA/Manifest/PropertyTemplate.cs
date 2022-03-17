using System.Xml;

namespace SA.Manifest
{
	public class PropertyTemplate : BaseTemplate
	{
		public bool IsOpen;

		private string _tag;

		public string Tag => "";

		public string Name
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string Value
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string Label
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public PropertyTemplate(string tag)
		{
		}

		public override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
		}
	}
}
