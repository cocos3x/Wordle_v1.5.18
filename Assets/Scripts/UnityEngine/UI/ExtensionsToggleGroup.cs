using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	public class ExtensionsToggleGroup : UIBehaviour
	{
		[Serializable]
		public class ToggleGroupEvent : UnityEvent<bool>
		{
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Predicate<ExtensionsToggle> _003C_003E9__18_0;

			public static Func<ExtensionsToggle, bool> _003C_003E9__19_0;

			internal bool _003CAnyTogglesOn_003Eb__18_0(ExtensionsToggle x)
			{
				return false;
			}

			internal bool _003CActiveToggles_003Eb__19_0(ExtensionsToggle x)
			{
				return false;
			}
		}

		[SerializeField]
		private bool m_AllowSwitchOff;

		private List<ExtensionsToggle> m_Toggles;

		public ToggleGroupEvent onToggleGroupChanged;

		public ToggleGroupEvent onToggleGroupToggleChanged;

		private ExtensionsToggle _003CSelectedToggle_003Ek__BackingField;

		public bool AllowSwitchOff
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ExtensionsToggle SelectedToggle
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		protected ExtensionsToggleGroup()
		{
		}

		private void ValidateToggleIsInGroup(ExtensionsToggle toggle)
		{
		}

		public void NotifyToggleOn(ExtensionsToggle toggle)
		{
		}

		public void UnregisterToggle(ExtensionsToggle toggle)
		{
		}

		private void NotifyToggleChanged(bool isOn)
		{
		}

		public void RegisterToggle(ExtensionsToggle toggle)
		{
		}

		public bool AnyTogglesOn()
		{
			return false;
		}

		public IEnumerable<ExtensionsToggle> ActiveToggles()
		{
			return null;
		}

		public void SetAllTogglesOff()
		{
		}

		public void HasTheGroupToggle(bool value)
		{
		}

		public void HasAToggleFlipped(bool value)
		{
		}
	}
}
