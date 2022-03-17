using System;

namespace UnityEngine.Analytics.Experimental.Tracker
{
	[Serializable]
	public class TriggerRule
	{
		[SerializeField]
		private TrackableField m_Target;

		[SerializeField]
		private TriggerOperator m_Operator;

		[SerializeField]
		private ValueProperty m_Value;

		[SerializeField]
		private ValueProperty m_Value2;

		public bool Test()
		{
			return false;
		}

		public bool Test(out bool error, out string message)
		{
			return false;
		}

		private bool TestByObject(object currentValue)
		{
			return false;
		}

		private bool TestByEnum(string currentValue)
		{
			return false;
		}

		private bool TestByString(string currentValue)
		{
			return false;
		}

		private bool TestByBool(bool currentValue)
		{
			return false;
		}

		private bool TestByDouble(double currentValue)
		{
			return false;
		}

		private bool SafeEquals(double double1, double double2)
		{
			return false;
		}

		private double GetDouble(object value)
		{
			return 0.0;
		}
	}
}
