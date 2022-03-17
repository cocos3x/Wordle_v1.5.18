using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class DUI
	{
		public enum EventType
		{
			GameEvent,
			ButtonClick,
			ButtonDoubleClick,
			ButtonLongClick
		}

		public const int MENU_PRIORITY_UICANVAS = 0;

		public const string COMPONENT_MENU_UICANVAS = "DoozyUI/UI Canvas";

		public const string GAMEOBJECT_MENU_UICANVAS = "GameObject/DoozyUI/UI Canvas";

		public const int MENU_PRIORITY_UIELEMENT = 1;

		public const string COMPONENT_MENU_UIELEMENT = "DoozyUI/UI Element";

		public const string GAMEOBJECT_MENU_UIELEMENT = "GameObject/DoozyUI/UI Element";

		public const int MENU_PRIORITY_UIBUTTON = 2;

		public const string COMPONENT_MENU_UIBUTTON = "DoozyUI/UI Button";

		public const string GAMEOBJECT_MENU_UIBUTTON = "GameObject/DoozyUI/UI Button";

		public const int MENU_PRIORITY_UITOGGLE = 3;

		public const string COMPONENT_MENU_UITOGGLE = "DoozyUI/UI Toggle";

		public const string GAMEOBJECT_MENU_UITOGGLE = "GameObject/DoozyUI/UI Toggle";

		public const int MENU_PRIORITY_UIEFFECT = 4;

		public const string COMPONENT_MENU_UIEFFECT = "DoozyUI/UI Effect";

		public const string GAMEOBJECT_MENU_UIEFFECT = "GameObject/DoozyUI/UI Effect";

		public const int MENU_PRIORITY_UITRIGGER = 5;

		public const string COMPONENT_MENU_UITRIGGER = "DoozyUI/UI Trigger";

		public const string GAMEOBJECT_MENU_UITRIGGER = "GameObject/DoozyUI/UI Trigger";

		public const int MENU_PRIORITY_UINOTIFICATION = 6;

		public const string COMPONENT_MENU_UINOTIFICATION = "DoozyUI/UI Notification";

		public const string GAMEOBJECT_MENU_UINOTIFICATION = "GameObject/DoozyUI/UI Notification";

		public const int MENU_PRIORITY_PLAYMAKER_EVENT_DISPATCHER = 50;

		public const string COMPONENT_MENU_PLAYMAKER_EVENT_DISPATCHER = "DoozyUI/Playmaker/Event Dispatcher";

		public const string GAMEOBJECT_MENU_PLAYMAKER_EVENT_DISPATCHER = "GameObject/DoozyUI/Playmaker/Event Dispatcher";

		public const int MENU_PRIORITY_UIMANAGER = 100;

		public const string TOOLS_MENU_UIMANAGER = "Tools/DoozyUI/Managers/UI Manager";

		public const string GAMEOBJECT_MENU_UIMANAGER = "GameObject/DoozyUI/Managers/UI Manager";

		public const int MENU_PRIORITY_ORIENTATION_MANAGER = 101;

		public const string TOOLS_MENU_ORIENTATION_MANAGER = "Tools/DoozyUI/Managers/Orientation Manager";

		public const string GAMEOBJECT_MENU_ORIENTATION_MANAGER = "GameObject/DoozyUI/Managers/Orientation Manager";

		public const int MENU_PRIORITY_SCENE_LOADER = 102;

		public const string TOOLS_MENU_SCENE_LOADER = "Tools/DoozyUI/Managers/Scene Loader";

		public const string GAMEOBJECT_MENU_SCENE_LOADER = "GameObject/DoozyUI/Managers/Scene Loader";

		public const string SYMBOL_DOOZYUI = "dUI_DoozyUI";

		public const string SYMBOL_PLAYMAKER = "dUI_PlayMaker";

		public const string SYMBOL_MASTER_AUDIO = "dUI_MasterAudio";

		public const string SYMBOL_ENERGY_BAR_TOOLKIT = "dUI_EnergyBarToolkit";

		public const string SYMBOL_TEXT_MESH_PRO = "dUI_TextMeshPro";

		public const string SYMBOL_ORIENTATION_MANAGER = "dUI_UseOrientationManager";

		public const string SYMBOL_NAVIGATION_SYSTEM = "dUI_NavigationDisabled";

		public const string SYMBOL_SCENE_LOADER = "dUI_SceneLoaderDisabled";

		public const string DEFAULT_CATEGORY_NAME = "Uncategorized";

		public const string DEFAULT_ELEMENT_NAME = "~Element Name~";

		public const string DEFAULT_BUTTON_NAME = "~Button Name~";

		public const string DEFAULT_SOUND_NAME = "~No Sound~";

		public const string DEFAULT_CANVAS_NAME = "MasterCanvas";

		public const string DISPATCH_ALL = "~Dispatch All~";

		public const string CUSTOM_NAME = "~Custom Name~";

		public const string BACK_BUTTON_NAME = "Back";

		public const string CANVAS_DATABASE_FILENAME = "CanvasDatabase";

		public const string SETTINGS_FILENAME = "DUISettings";

		public const string RESOURCES_PATH_UIELEMENTS = "DUI/UIElements/";

		public const string RESOURCES_PATH_UIBUTTONS = "DUI/UIButtons/";

		public const string RESOURCES_PATH_UISOUNDS = "DUI/UISounds/";

		public const string RESOURCES_PATH_CANVAS_DATABASE = "DUI/Canvases/";

		public const string RESOURCES_PATH_SETTINGS = "DUI/Settings/";

		private static string _DOOZYUI_PATH;

		[SerializeField]
		private static DUISettings m_DUISettings;

		public static string DOOZYUI_PATH => "";

		public static string RELATIVE_PATH_UIELEMENTS => "";

		public static string RELATIVE_PATH_UIBUTTONS => "";

		public static string RELATIVE_PATH_UISOUNDS => "";

		public static string RELATIVE_PATH_CANVAS_DATABASE => "";

		public static string RELATIVE_PATH_SETTINGS => "";

		private static string[] GetUIElementCategoriesFileNames => null;

		private static string[] GetUIButtonCategoriesFileNames => null;

		private static string[] GetUISoundsFileNames => null;

		public static DUISettings DUISettings => null;

		public static T GetResource<T>(string resourcesPath, string fileName) where T : ScriptableObject
		{
			return null;
		}

		public static UISound GetUISound(string soundName)
		{
			return null;
		}
	}
}
