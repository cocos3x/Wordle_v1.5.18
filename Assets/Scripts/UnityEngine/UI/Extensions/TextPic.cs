using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	public class TextPic : Text, IPointerClickHandler, IEventSystemHandler, IPointerExitHandler, IPointerEnterHandler, ISelectHandler
	{
		[Serializable]
		public struct IconName
		{
			public string name;

			public Sprite sprite;
		}

		[Serializable]
		public class HrefClickEvent : UnityEvent<string>
		{
		}

		private class HrefInfo
		{
			public int startIndex;

			public int endIndex;

			public string name;

			public readonly List<Rect> boxes;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Predicate<Image> _003C_003E9__20_0;

			internal bool _003CUpdateQuadImage_003Eb__20_0(Image image)
			{
				return false;
			}
		}

		private readonly List<Image> m_ImagesPool;

		private readonly List<GameObject> culled_ImagesPool;

		private bool clearImages;

		private Object thisLock;

		private readonly List<int> m_ImagesVertexIndex;

		private static readonly Regex s_Regex;

		private string fixedString;

		private string m_OutputText;

		public IconName[] inspectorIconList;

		private Dictionary<string, Sprite> iconList;

		public float ImageScalingFactor;

		public string hyperlinkColor;

		[SerializeField]
		public Vector2 imageOffset;

		private Button button;

		private List<Vector2> positions;

		private string previousText;

		public bool isCreating_m_HrefInfos;

		private readonly List<HrefInfo> m_HrefInfos;

		private static readonly StringBuilder s_TextBuilder;

		private static readonly Regex s_HrefRegex;

		[SerializeField]
		private HrefClickEvent m_OnHrefClick;

		public HrefClickEvent onHrefClick
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void SetVerticesDirty()
		{
		}

		private new void Start()
		{
		}

		protected void UpdateQuadImage()
		{
		}

		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		protected string GetOutputText()
		{
			return "";
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		private void Update()
		{
		}

		private void Reset_m_HrefInfos()
		{
		}
	}
}
