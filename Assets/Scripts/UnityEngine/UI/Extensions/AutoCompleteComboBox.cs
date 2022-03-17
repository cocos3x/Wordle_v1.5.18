using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	public class AutoCompleteComboBox : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass38_0
		{
			public string textOfItem;

			public AutoCompleteComboBox _003C_003E4__this;

			internal void _003CRebuildPanel_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass43_0
		{
			public string currText;

			internal bool _003CPruneItems_003Eb__0(string x)
			{
				return false;
			}

			internal bool _003CPruneItems_003Eb__1(string x)
			{
				return false;
			}
		}

		public Color disabledTextColor;

		private DropDownListItem _003CSelectedItem_003Ek__BackingField;

		public List<string> AvailableOptions;

		public Action<int> OnSelectionChanged;

		private bool _isPanelActive;

		private bool _hasDrawnOnce;

		private InputField _mainInput;

		private RectTransform _inputRT;

		private RectTransform _rectTransform;

		private RectTransform _overlayRT;

		private RectTransform _scrollPanelRT;

		private RectTransform _scrollBarRT;

		private RectTransform _slidingAreaRT;

		private RectTransform _itemsPanelRT;

		private Canvas _canvas;

		private RectTransform _canvasRT;

		private ScrollRect _scrollRect;

		private List<string> _panelItems;

		private List<string> _prunedPanelItems;

		private Dictionary<string, GameObject> panelObjects;

		private GameObject itemTemplate;

		private string _003CText_003Ek__BackingField;

		[SerializeField]
		private float _scrollBarWidth;

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

		public string Text
		{
			get
			{
				return "";
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

		public void Awake()
		{
		}

		private bool Initialize()
		{
			return false;
		}

		private void RebuildPanel()
		{
		}

		private void OnItemClicked(string item)
		{
		}

		private void RedrawPanel()
		{
		}

		public void OnValueChanged(string currText)
		{
		}

		public void ToggleDropdownPanel(bool directClick)
		{
		}

		private void PruneItems(string currText)
		{
		}
	}
}
