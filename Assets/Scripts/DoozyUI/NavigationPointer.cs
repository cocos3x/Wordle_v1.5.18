using System;

namespace DoozyUI
{
	[Serializable]
	public class NavigationPointer
	{
		public string category;

		public string name;

		public NavigationPointer()
		{
		}

		public NavigationPointer(string Category, string Name)
		{
		}

		public NavigationPointer Copy()
		{
			return null;
		}
	}
}
