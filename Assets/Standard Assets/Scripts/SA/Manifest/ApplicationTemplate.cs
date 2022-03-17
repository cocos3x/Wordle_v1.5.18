using System.Collections.Generic;
using System.Xml;

namespace SA.Manifest
{
	public class ApplicationTemplate : BaseTemplate
	{
		private Dictionary<int, ActivityTemplate> _activities;

		public Dictionary<int, ActivityTemplate> Activities => null;

		public void AddActivity(ActivityTemplate activity)
		{
		}

		public void RemoveActivity(ActivityTemplate activity)
		{
		}

		public ActivityTemplate GetOrCreateActivityWithName(string name)
		{
			return null;
		}

		public ActivityTemplate GetActivityWithName(string name)
		{
			return null;
		}

		public ActivityTemplate GetLauncherActivity()
		{
			return null;
		}

		public override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
		}
	}
}
