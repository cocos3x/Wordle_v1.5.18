using System;

namespace UnityEngine.Analytics.Experimental.Tracker
{
	[Serializable]
	public class TrackableField : TrackableProperty
	{
		[SerializeField]
		private string[] m_ValidTypeNames;

		[SerializeField]
		private string m_Type;

		[SerializeField]
		private string m_EnumType;

		public TrackableField(params Type[] validTypes)
		{
		}

		public object GetValue()
		{
			return null;
		}
	}
}
