using System;
using System.Collections.Generic;

namespace DoozyUI
{
	[Serializable]
	public class NavigationPointerData
	{
		public bool addToNavigationHistory;

		public List<NavigationPointer> show;

		public List<NavigationPointer> hide;

		public NavigationPointerData(bool AddToNavigationHitory)
		{
		}

		public NavigationPointerData()
		{
		}

		public NavigationPointerData Copy()
		{
			return null;
		}
	}
}
