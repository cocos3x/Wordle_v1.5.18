using System;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	public class ReorderableList : MonoBehaviour
	{
		[Serializable]
		public struct ReorderableListEventStruct
		{
			public GameObject DroppedObject;

			public int FromIndex;

			public ReorderableList FromList;

			public bool IsAClone;

			public GameObject SourceObject;

			public int ToIndex;

			public ReorderableList ToList;
		}

		[Serializable]
		public class ReorderableListHandler : UnityEvent<ReorderableListEventStruct>
		{
		}

		public LayoutGroup ContentLayout;

		public RectTransform DraggableArea;

		public bool IsDraggable;

		public bool CloneDraggedObject;

		public bool IsDropable;

		public ReorderableListHandler OnElementDropped;

		public ReorderableListHandler OnElementGrabbed;

		public ReorderableListHandler OnElementRemoved;

		private RectTransform _content;

		private ReorderableListContent _listContent;

		public RectTransform Content => null;

		private Canvas GetCanvas()
		{
			return null;
		}

		private void Awake()
		{
		}

		public void TestReOrderableListTarget(ReorderableListEventStruct item)
		{
		}
	}
}
