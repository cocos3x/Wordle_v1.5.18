using System;
using UnityEngine;

namespace SIS
{
	public class VRInput : MonoBehaviour
	{
		public enum SwipeDirection
		{
			NONE,
			UP,
			DOWN,
			LEFT,
			RIGHT
		}

		[SerializeField]
		private float m_DoubleClickTime;

		[SerializeField]
		private float m_SwipeWidth;

		private Vector2 m_MouseDownPosition;

		private Vector2 m_MouseUpPosition;

		private float m_LastMouseUpTime;

		private float m_LastHorizontalValue;

		private float m_LastVerticalValue;

		public float DoubleClickTime => 0f;

		public event Action<SwipeDirection> OnSwipe
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action OnClick
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action OnDown
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action OnUp
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action OnDoubleClick
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action OnCancel
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Update()
		{
		}

		private void CheckInput()
		{
		}

		private SwipeDirection DetectSwipe()
		{
			//IL_0003: Expected I4, but got O
			return (SwipeDirection)null;
		}

		private SwipeDirection DetectKeyboardEmulatedSwipe()
		{
			//IL_0003: Expected I4, but got O
			return (SwipeDirection)null;
		}

		private void OnDestroy()
		{
		}
	}
}
