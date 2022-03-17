using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	public class DropDownList : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			public int ii;

			public DropDownListItem item;

			public DropDownList _003C_003E4__this;

			internal void _003CRebuildPanel_003Eb__0()
			{
			}
		}

		public Color disabledTextColor;

		private DropDownListItem _003CSelectedItem_003Ek__BackingField;

		public List<DropDownListItem> Items;

		public Action<int> OnSelectionChanged;

		public bool OverrideHighlighted;

		private bool _isPanelActive;

		private bool _hasDrawnOnce;

		private DropDownListButton _mainButton;

		private RectTransform _rectTransform;

		private RectTransform _overlayRT;

		private RectTransform _scrollPanelRT;

		private RectTransform _scrollBarRT;

		private RectTransform _slidingAreaRT;

		private RectTransform _itemsPanelRT;

		private Canvas _canvas;

		private RectTransform _canvasRT;

		private ScrollRect _scrollRect;

		private List<DropDownListButton> _panelItems;

		private GameObject _itemTemplate;

		[SerializeField]
		private float _scrollBarWidth;

		private int _selectedIndex;

		[SerializeField]
		private int _itemsToDisplay;

		public DropDownListItem SelectedItem
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public float ScrollBarWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int ItemsToDisplay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Start()
		{
		}

		private bool Initialize()
		{
			return false;
		}

		private void RebuildPanel()
		{
		}

		private void OnItemClicked(int indx)
		{
		}

		private void UpdateSelected()
		{
		}

		private void RedrawPanel()
		{
		}

		public void ToggleDropdownPanel(bool directClick)
		{
		}
	}
}
