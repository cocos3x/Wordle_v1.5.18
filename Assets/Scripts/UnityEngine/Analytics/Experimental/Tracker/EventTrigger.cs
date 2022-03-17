using System;
using System.Runtime.InteropServices;

namespace UnityEngine.Analytics.Experimental.Tracker
{
	[Serializable]
	public class EventTrigger
	{
		internal delegate void OnTrigger();

		[SerializeField]
		private TriggerType m_Type;

		[SerializeField]
		private TriggerLifecycleEvent m_LifecycleEvent;

		[SerializeField]
		private bool m_ApplyRules;

		[SerializeField]
		private TriggerListContainer m_Rules;

		[SerializeField]
		private TriggerBool m_TriggerBool;

		[SerializeField]
		private float m_InitTime;

		[SerializeField]
		private float m_RepeatTime;

		[SerializeField]
		private int m_Repetitions;

		public int repetitionCount;

		private OnTrigger m_TriggerFunction;

		[SerializeField]
		private TriggerMethod m_Method;

		public TriggerType triggerType => (TriggerType)null;

		public TriggerLifecycleEvent lifecycleEvent => (TriggerLifecycleEvent)null;

		public float initTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float repeatTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int repetitions
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void AddRule()
		{
		}

		public void RemoveRule(int index)
		{
		}

		public bool Test([Optional] GameObject gameObject)
		{
			return false;
		}
	}
}
