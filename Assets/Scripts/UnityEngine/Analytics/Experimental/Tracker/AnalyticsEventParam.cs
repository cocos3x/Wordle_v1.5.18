using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Analytics.Experimental.Tracker
{
	[Serializable]
	public class AnalyticsEventParam
	{
		public enum RequirementType
		{
			None,
			Required,
			Optional
		}

		[SerializeField]
		private RequirementType m_RequirementType;

		[SerializeField]
		private string m_GroupID;

		[SerializeField]
		private string m_Name;

		[SerializeField]
		private ValueProperty m_Value;

		public RequirementType requirementType => (RequirementType)null;

		public string groupID => "";

		public ValueProperty valueProperty => null;

		public string name => "";

		public object value => null;

		public AnalyticsEventParam([Optional] string name, params Type[] validTypes)
		{
		}
	}
}
