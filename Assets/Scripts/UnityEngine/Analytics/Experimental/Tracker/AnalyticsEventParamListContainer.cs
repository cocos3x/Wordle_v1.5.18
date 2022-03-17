using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics.Experimental.Tracker
{
	[Serializable]
	public class AnalyticsEventParamListContainer
	{
		[SerializeField]
		private List<AnalyticsEventParam> m_Parameters;

		public List<AnalyticsEventParam> parameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
