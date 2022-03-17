using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class ScrollRectEx : ScrollRect
	{
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public PointerEventData eventData;

			internal void _003COnInitializePotentialDrag_003Eb__0(IInitializePotentialDragHandler parent)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public PointerEventData eventData;

			internal void _003COnDrag_003Eb__0(IDragHandler parent)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public PointerEventData eventData;

			internal void _003COnBeginDrag_003Eb__0(IBeginDragHandler parent)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public PointerEventData eventData;

			internal void _003COnEndDrag_003Eb__0(IEndDragHandler parent)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public PointerEventData eventData;

			internal void _003COnScroll_003Eb__0(IScrollHandler parent)
			{
			}
		}

		private bool routeToParent;

		private void DoForParents<T>(Action<T> action) where T : IEventSystemHandler
		{
		}

		public override void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		public override void OnDrag(PointerEventData eventData)
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		public override void OnScroll(PointerEventData eventData)
		{
		}
	}
}
