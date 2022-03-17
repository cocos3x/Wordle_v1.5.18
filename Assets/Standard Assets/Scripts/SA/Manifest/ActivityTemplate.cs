using System.Xml;

namespace SA.Manifest
{
	public class ActivityTemplate : BaseTemplate
	{
		public bool IsOpen;

		private int _id;

		private bool _isLauncher;

		private string _name;

		public bool IsLauncher => false;

		public string Name => "";

		public int Id => 0;

		public ActivityTemplate(bool isLauncher, string name)
		{
		}

		public void SetName(string name)
		{
		}

		public void SetAsLauncher(bool isLauncher)
		{
		}

		public static PropertyTemplate GetLauncherPropertyTemplate()
		{
			return null;
		}

		public bool IsLauncherProperty(PropertyTemplate property)
		{
			return false;
		}

		public override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
		}
	}
}
