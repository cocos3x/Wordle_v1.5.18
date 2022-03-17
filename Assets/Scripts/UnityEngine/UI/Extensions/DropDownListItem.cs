using System;
using System.Runtime.InteropServices;

namespace UnityEngine.UI.Extensions
{
	[Serializable]
	public class DropDownListItem
	{
		[SerializeField]
		private string _caption;

		[SerializeField]
		private Sprite _image;

		[SerializeField]
		private bool _isDisabled;

		[SerializeField]
		private string _id;

		public Action OnSelect;

		internal Action OnUpdate;

		public string Caption
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public Sprite Image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsDisabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string ID
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public DropDownListItem(string caption = "", string inId = "", [Optional] Sprite image, bool disabled = false, [Optional] Action onSelect)
		{
		}
	}
}
