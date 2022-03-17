using System;

namespace UnityEngine.Analytics.Experimental.Tracker
{
	[Serializable]
	public class ValueProperty
	{
		public enum PropertyType
		{
			Disabled,
			Static,
			Dynamic
		}

		[SerializeField]
		private PropertyType m_PropertyType;

		[SerializeField]
		private string m_ValueType;

		[SerializeField]
		private string m_Value;

		[SerializeField]
		private TrackableField m_Target;

		public string valueType
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string propertyValue => "";

		public TrackableField target => null;

		public bool IsValid()
		{
			return false;
		}
	}
}
