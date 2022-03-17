using DG.Tweening;
using System;

namespace DoozyUI
{
	[Serializable]
	public class Loop
	{
		public enum LoopType
		{
			Restart,
			Yoyo
		}

		public bool autoStart;

		public MoveLoop move;

		public RotateLoop rotate;

		public ScaleLoop scale;

		public FadeLoop fade;

		public bool Enabled => false;

		public float TotalDuration => 0f;

		public static DG.Tweening.LoopType GetLoopType(LoopType loopType)
		{
			//IL_0003: Expected I4, but got O
			return (DG.Tweening.LoopType)null;
		}

		public static LoopType GetLoopType(DG.Tweening.LoopType loopType)
		{
			//IL_0003: Expected I4, but got O
			return (LoopType)null;
		}

		public void Reset()
		{
		}

		public Loop Copy()
		{
			return null;
		}
	}
}
