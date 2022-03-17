using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class VerticalScrollSnap : ScrollSnapBase, IEndDragHandler, IEventSystemHandler
	{
		private sealed class _003CGoToLocation_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VerticalScrollSnap _003C_003E4__this;

			public int location;

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
			public _003CGoToLocation_003Ed__2(int _003C_003E1__state)
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

		public void GoToBeginningOfList()
		{
		}

		public void GoToItem(int item)
		{
		}

		private IEnumerator GoToLocation(int location)
		{
			return null;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private bool IsRectMovingSlowerThanThreshold(float startingSpeed)
		{
			return false;
		}

		public void DistributePages()
		{
		}

		public void AddChild(GameObject GO)
		{
		}

		public void AddChild(GameObject GO, bool WorldPositionStays)
		{
		}

		public void RemoveChild(int index, out GameObject ChildRemoved)
		{
		}

		public void RemoveAllChildren(out GameObject[] ChildrenRemoved)
		{
		}

		private void SetScrollContainerPosition()
		{
		}

		public void UpdateLayout()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
