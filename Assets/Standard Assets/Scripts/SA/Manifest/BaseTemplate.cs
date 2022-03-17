using System.Collections.Generic;
using System.Xml;

namespace SA.Manifest
{
	public abstract class BaseTemplate
	{
		protected Dictionary<string, List<PropertyTemplate>> _properties;

		protected Dictionary<string, string> _values;

		public Dictionary<string, string> Values => null;

		public Dictionary<string, List<PropertyTemplate>> Properties => null;

		public PropertyTemplate GetOrCreateIntentFilterWithName(string name)
		{
			return null;
		}

		public PropertyTemplate GetIntentFilterWithName(string name)
		{
			return null;
		}

		public string GetIntentFilterName(PropertyTemplate intent)
		{
			return "";
		}

		public PropertyTemplate GetOrCreatePropertyWithName(string tag, string name)
		{
			return null;
		}

		public PropertyTemplate GetPropertyWithName(string tag, string name)
		{
			return null;
		}

		public PropertyTemplate GetOrCreatePropertyWithTag(string tag)
		{
			return null;
		}

		public PropertyTemplate GetPropertyWithTag(string tag)
		{
			return null;
		}

		public List<PropertyTemplate> GetPropertiesWithTag(string tag)
		{
			return null;
		}

		public abstract void ToXmlElement(XmlDocument doc, XmlElement parent);

		public BaseTemplate()
		{
		}

		public void AddProperty(PropertyTemplate property)
		{
		}

		public void AddProperty(string tag, PropertyTemplate property)
		{
		}

		public void SetValue(string key, string value)
		{
		}

		public string GetValue(string key)
		{
			return "";
		}

		public void RemoveProperty(PropertyTemplate property)
		{
		}

		public void RemoveValue(string key)
		{
		}

		public void AddPropertiesToXml(XmlDocument doc, XmlElement parent, BaseTemplate template)
		{
		}

		public void AddAttributesToXml(XmlDocument doc, XmlElement parent, BaseTemplate template)
		{
		}
	}
}
