using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class ScrollRectTweener : MonoBehaviour, IDragHandler, IEventSystemHandler
	{
		private sealed class _003CDoMove_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public ScrollRectTweener _003C_003E4__this;

			private Vector2 _003CposOffset_003E5__2;

			private float _003CcurrentTime_003E5__3;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoMove_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private ScrollRect scrollRect;

		private Vector2 startPos;

		private Vector2 targetPos;

		private bool wasHorizontal;

		private bool wasVertical;

		public float moveSpeed;

		public bool disableDragWhileTweening;

		private void Awake()
		{
		}

		public void ScrollHorizontal(float normalizedX)
		{
		}

		public void ScrollHorizontal(float normalizedX, float duration)
		{
		}

		public void ScrollVertical(float normalizedY)
		{
		}

		public void ScrollVertical(float normalizedY, float duration)
		{
		}

		public void Scroll(Vector2 normalizedPos)
		{
		}

		private float GetScrollDuration(Vector2 normalizedPos)
		{
			return 0f;
		}

		private Vector2 DeNormalize(Vector2 normalizedPos)
		{
			return (Vector2)null;
		}

		private Vector2 GetCurrentPos()
		{
			return (Vector2)null;
		}

		public void Scroll(Vector2 normalizedPos, float duration)
		{
		}

		private IEnumerator DoMove(float duration)
		{
			return null;
		}

		public Vector2 EaseVector(float currentTime, Vector2 startValue, Vector2 changeInValue, float duration)
		{
			return (Vector2)null;
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private void StopScroll()
		{
		}

		private void LockScrollability()
		{
		}

		private void RestoreScrollability()
		{
		}
	}
}
