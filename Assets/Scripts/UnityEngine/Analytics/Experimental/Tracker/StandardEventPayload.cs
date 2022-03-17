using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics.Experimental.Tracker
{
	[Serializable]
	public class StandardEventPayload
	{
		[SerializeField]
		private AnalyticsEventParamListContainer m_Parameters;

		private static Dictionary<string, object> m_EventData;

		[SerializeField]
		private string m_Name;

		public AnalyticsEventParamListContainer parameters => null;

		public string name
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual AnalyticsResult Send()
		{
			//IL_0003: Expected I4, but got O
			return (AnalyticsResult)null;
		}

		private IDictionary<string, object> GetParameters()
		{
			return null;
		}

		private bool IsCustomDataValid()
		{
			return false;
		}

		private bool IsRequiredDataValid()
		{
			return false;
		}
	}
}
