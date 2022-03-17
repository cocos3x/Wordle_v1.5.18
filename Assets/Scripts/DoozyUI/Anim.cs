using System;

namespace DoozyUI
{
	[Serializable]
	public class Anim
	{
		public enum AnimationType
		{
			In,
			Out
		}

		public AnimationType animationType;

		public Move move;

		public Rotate rotate;

		public Scale scale;

		public Fade fade;

		public bool Enabled => false;

		public float TotalDuration => 0f;

		public float StartDelay => 0f;

		public static AnimationType Reverse(AnimationType animationType)
		{
			//IL_0003: Expected I4, but got O
			return (AnimationType)null;
		}

		public Anim(AnimationType aType)
		{
		}

		public void Reset(AnimationType aType)
		{
		}

		public void UpdateValues(Anim a)
		{
		}

		public Anim Copy()
		{
			return null;
		}

		public Anim Reverse()
		{
			return null;
		}
	}
}
