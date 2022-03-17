using System;
using System.Collections.Generic;

namespace DoozyUI
{
	public class UINavigation
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<NavigationPointer, bool> _003C_003E9__14_0;

			public static Func<UIElement, bool> _003C_003E9__14_2;

			public static Func<NavigationPointer, bool> _003C_003E9__14_1;

			internal bool _003CUpdateTheNavigationHistory_003Eb__14_0(NavigationPointer navPointer)
			{
				return false;
			}

			internal bool _003CUpdateTheNavigationHistory_003Eb__14_1(NavigationPointer navPointer)
			{
				return false;
			}

			internal bool _003CUpdateTheNavigationHistory_003Eb__14_2(UIElement element)
			{
				return false;
			}
		}

		public static bool m_isNavigationEnabled;

		private static List<NavigationPointerData> History;

		private static List<UIElement> visibleHideElementsList;

		private static List<UIElement> tempUIElementsList;

		private static int count;

		public static bool IsNavigationEnabled => false;

		private static void InitNavigationHistory()
		{
		}

		public static void ClearNavigationHistory()
		{
		}

		public static void AddItemToHistory(NavigationPointerData data)
		{
		}

		public static void RemoveLastItemFromHistory()
		{
		}

		public static NavigationPointerData GetLastItemFromNavigationHistory(bool removeFromHistory = true)
		{
			return null;
		}

		public static void Show(List<NavigationPointer> show, bool instantAction = false)
		{
		}

		public static void Hide(List<NavigationPointer> hide, bool instantAction = false, bool disableWhenHidden = false)
		{
		}

		public static void UpdateTheNavigationHistory(NavigationPointerData navData)
		{
		}
	}
}
