using System.Collections.Generic;
using System.Xml;

namespace SA.Manifest
{
	public class Template : BaseTemplate
	{
		private ApplicationTemplate _applicationTemplate;

		private List<PropertyTemplate> _permissions;

		public ApplicationTemplate ApplicationTemplate => null;

		public List<PropertyTemplate> Permissions => null;

		public bool HasPermission(string name)
		{
			return false;
		}

		public void RemovePermission(string name)
		{
		}

		public void RemovePermission(PropertyTemplate permission)
		{
		}

		public void AddPermission(string name)
		{
		}

		public void AddPermission(PropertyTemplate permission)
		{
		}

		public override void ToXmlElement(XmlDocument doc, XmlElement parent)
		{
		}
	}
}
