using DG.Tweening;
using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class Move
	{
		public enum MoveDirection
		{
			Left,
			Right,
			Top,
			Bottom,
			TopLeft,
			TopCenter,
			TopRight,
			MiddleLeft,
			MiddleCenter,
			MiddleRight,
			BottomLeft,
			BottomCenter,
			BottomRight,
			CustomPosition
		}

		public bool enabled;

		public Anim.AnimationType animationType;

		public MoveDirection moveDirection;

		public Vector3 customPosition;

		public UIAnimator.EaseType easeType;

		public Ease ease;

		public AnimationCurve animationCurve;

		public float startDelay;

		public float duration;

		public float TotalDuration => 0f;

		public static MoveDirection Reverse(MoveDirection moveDirection)
		{
			//IL_0003: Expected I4, but got O
			return (MoveDirection)null;
		}

		public Move(Anim.AnimationType aType)
		{
		}

		public void Reset(Anim.AnimationType aType, MoveDirection mDirection = MoveDirection.Left)
		{
		}

		public void UpdateValues(Move m)
		{
		}

		public Move Copy()
		{
			return null;
		}

		public Move Reverse()
		{
			return null;
		}
	}
}
