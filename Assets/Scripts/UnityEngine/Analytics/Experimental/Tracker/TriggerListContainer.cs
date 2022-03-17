using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics.Experimental.Tracker
{
	[Serializable]
	public class TriggerListContainer
	{
		[SerializeField]
		private List<TriggerRule> m_Rules;

		internal List<TriggerRule> rules
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
