using System;
using UnityEngine;

namespace DoozyUI
{
	[Serializable]
	public class DUISettings : ScriptableObject
	{
		public bool InternalSettings_ExecutedUpgrade;

		public bool HierarchyManager_Enabled;

		public bool HierarchyManager_PlaymakerEventDispatcher_ShowIcon;

		public bool HierarchyManager_UITrigger_ShowIcon;

		public bool HierarchyManager_UIManager_ShowIcon;

		public bool HierarchyManager_Soundy_ShowIcon;

		public bool HierarchyManager_UINotificationManager_ShowIcon;

		public bool HierarchyManager_OrientationManager_ShowIcon;

		public bool HierarchyManager_SceneLoader_ShowIcon;

		public bool HierarchyManager_UICanvas_ShowIcon;

		public bool HierarchyManager_UICanvas_ShowCanvasName;

		public bool HierarchyManager_UICanvas_ShowSortingLayerNameAndOrder;

		public bool HierarchyManager_UINotification_ShowIcon;

		public bool HierarchyManager_UIElement_ShowIcon;

		public bool HierarchyManager_UIElement_ShowElementCategory;

		public bool HierarchyManager_UIElement_ShowElementName;

		public bool HierarchyManager_UIElement_ShowSortingLayerNameAndOrder;

		public bool HierarchyManager_UIButton_ShowIcon;

		public bool HierarchyManager_UIButton_ShowButtonCategory;

		public bool HierarchyManager_UIButton_ShowButtonName;

		public bool HierarchyManager_UIEffect_ShowIcon;

		public bool HierarchyManager_UIEffect_ShowSortingLayerNameAndOrder;

		public bool UIElement_Inspector_ShowButtonRenameGameObject;

		public string UIElement_Inspector_RenameGameObjectPrefix;

		public string UIElement_Inspector_RenameGameObjectSuffix;

		public bool UIElement_LANDSCAPE;

		public bool UIElement_PORTRAIT;

		public bool UIElement_startHidden;

		public bool UIElement_animateAtStart;

		public bool UIElement_disableWhenHidden;

		public bool UIElement_useCustomStartAnchoredPosition;

		public Vector3 UIElement_customStartAnchoredPosition;

		public bool UIElement_executeLayoutFix;

		public string UIElement_inAnimationsPresetCategoryName;

		public string UIElement_inAnimationsPresetName;

		public bool UIElement_loadInAnimationsPresetAtRuntime;

		public string UIElement_outAnimationsPresetCategoryName;

		public string UIElement_outAnimationsPresetName;

		public bool UIElement_loadOutAnimationsPresetAtRuntime;

		public bool UIElement_Inspector_HideLoopAnimations;

		public string UIElement_loopAnimationsPresetCategoryName;

		public string UIElement_loopAnimationsPresetName;

		public bool UIElement_loadLoopAnimationsPresetAtRuntime;

		public bool UIButton_Inspector_ShowButtonRenameGameObject;

		public string UIButton_Inspector_RenameGameObjectPrefix;

		public string UIButton_Inspector_RenameGameObjectSuffix;

		public bool UIButton_allowMultipleClicks;

		public float UIButton_disableButtonInterval;

		public bool UIButton_deselectButtonOnClick;

		public bool UIButton_Inspector_HideOnPointerEnter;

		public bool UIButton_useOnPointerEnter;

		public float UIButton_onPointerEnterDisableInterval;

		public string UIButton_onPointerEnterSound;

		public bool UIButton_customOnPointerEnterSound;

		public string UIButton_onPointerEnterPunchPresetCategory;

		public string UIButton_onPointerEnterPunchPresetName;

		public bool UIButton_loadOnPointerEnterPunchPresetAtRuntime;

		public bool UIButton_Inspector_HideOnPointerExit;

		public bool UIButton_useOnPointerExit;

		public float UIButton_onPointerExitDisableInterval;

		public string UIButton_onPointerExitSound;

		public bool UIButton_customOnPointerExitSound;

		public string UIButton_onPointerExitPunchPresetCategory;

		public string UIButton_onPointerExitPunchPresetName;

		public bool UIButton_loadOnPointerExitPunchPresetAtRuntime;

		public bool UIButton_Inspector_HideOnPointerDown;

		public bool UIButton_useOnPointerDown;

		public string UIButton_onPointerDownSound;

		public bool UIButton_customOnPointerDownSound;

		public string UIButton_onPointerDownPunchPresetCategory;

		public string UIButton_onPointerDownPunchPresetName;

		public bool UIButton_loadOnPointerDownPunchPresetAtRuntime;

		public bool UIButton_Inspector_HideOnPointerUp;

		public bool UIButton_useOnPointerUp;

		public string UIButton_onPointerUpSound;

		public bool UIButton_customOnPointerUpSound;

		public string UIButton_onPointerUpPunchPresetCategory;

		public string UIButton_onPointerUpPunchPresetName;

		public bool UIButton_loadOnPointerUpPunchPresetAtRuntime;

		public bool UIButton_Inspector_HideOnClick;

		public bool UIButton_useOnClickAnimations;

		public bool UIButton_waitForOnClickAnimation;

		public UIButton.SingleClickMode UIButton_singleClickMode;

		public string UIButton_onClickSound;

		public bool UIButton_customOnClickSound;

		public string UIButton_onClickPunchPresetCategory;

		public string UIButton_onClickPunchPresetName;

		public bool UIButton_loadOnClickPunchPresetAtRuntime;

		public bool UIButton_Inspector_HideOnDoubleClick;

		public bool UIButton_useOnDoubleClick;

		public bool UIButton_waitForOnDoubleClickAnimation;

		public float UIButton_doubleClickRegisterInterval;

		public string UIButton_onDoubleClickSound;

		public bool UIButton_customOnDoubleClickSound;

		public string UIButton_onDoubleClickPunchPresetCategory;

		public string UIButton_onDoubleClickPunchPresetName;

		public bool UIButton_loadOnDoubleClickPunchPresetAtRuntime;

		public bool UIButton_Inspector_HideOnLongClick;

		public bool UIButton_useOnLongClick;

		public bool UIButton_waitForOnLongClickAnimation;

		public float UIButton_longClickRegisterInterval;

		public string UIButton_onLongClickSound;

		public bool UIButton_customOnLongClickSound;

		public string UIButton_onLongClickPunchPresetCategory;

		public string UIButton_onLongClickPunchPresetName;

		public bool UIButton_loadOnLongClickPunchPresetAtRuntime;

		public bool UIButton_Inspector_HideNormalLoop;

		public string UIButton_normalLoopPresetCategory;

		public string UIButton_normalLoopPresetName;

		public bool UIButton_loadNormalLoopPresetAtRuntime;

		public bool UIButton_Inspector_HideSelectedLoop;

		public string UIButton_selectedLoopPresetCategory;

		public string UIButton_selectedLoopPresetName;

		public bool UIButton_loadSelectedLoopPresetAtRuntime;

		public bool UIButton_addToNavigationHistory;

		public bool UIToggle_Inspector_ShowButtonRenameGameObject;

		public string UIToggle_Inspector_RenameGameObjectPrefix;

		public string UIToggle_Inspector_RenameGameObjectSuffix;

		public bool UIToggle_allowMultipleClicks;

		public float UIToggle_disableButtonInterval;

		public bool UIToggle_deselectButtonOnClick;

		public bool UIToggle_Inspector_HideOnPointerEnter;

		public bool UIToggle_useOnPointerEnter;

		public float UIToggle_onPointerEnterDisableInterval;

		public string UIToggle_onPointerEnterSoundToggleOn;

		public string UIToggle_onPointerEnterSoundToggleOff;

		public bool UIToggle_customOnPointerEnterSoundToggleOn;

		public bool UIToggle_customOnPointerEnterSoundToggleOff;

		public string UIToggle_onPointerEnterPunchPresetCategory;

		public string UIToggle_onPointerEnterPunchPresetName;

		public bool UIToggle_loadOnPointerEnterPunchPresetAtRuntime;

		public bool UIToggle_Inspector_HideOnPointerExit;

		public bool UIToggle_useOnPointerExit;

		public float UIToggle_onPointerExitDisableInterval;

		public string UIToggle_onPointerExitSoundToggleOn;

		public string UIToggle_onPointerExitSoundToggleOff;

		public bool UIToggle_customOnPointerExitSoundToggleOn;

		public bool UIToggle_customOnPointerExitSoundToggleOff;

		public string UIToggle_onPointerExitPunchPresetCategory;

		public string UIToggle_onPointerExitPunchPresetName;

		public bool UIToggle_loadOnPointerExitPunchPresetAtRuntime;

		public bool UIToggle_Inspector_HideOnClick;

		public bool UIToggle_useOnClickAnimations;

		public bool UIToggle_waitForOnClickAnimation;

		public string UIToggle_onClickSoundToggleOn;

		public string UIToggle_onClickSoundToggleOff;

		public bool UIToggle_customOnClickSoundToggleOn;

		public bool UIToggle_customOnClickSoundToggleOff;

		public string UIToggle_onClickPunchPresetCategory;

		public string UIToggle_onClickPunchPresetName;

		public bool UIToggle_loadOnClickPunchPresetAtRuntime;

		public bool UIEffect_Inspector_ShowButtonRenameGameObject;

		public string UIEffect_Inspector_RenameGameObjectPrefix;

		public string UIEffect_Inspector_RenameGameObjectSuffix;

		public bool UIEffect_playOnAwake;

		public bool UIEffect_stopInstantly;

		public bool UIEffect_useCustomSortingLayerName;

		public string UIEffect_customSortingLayerName;

		public bool UIEffect_useCustomOrderInLayer;

		public int UIEffect_customOrderInLayer;

		public UIEffect.EffectPosition UIEffect_effectPosition;

		public int UIEffect_sortingOrderStep;

		public bool HierarchyManager_UICanvas_Enabled => false;

		public bool HierarchyManager_UIElement_Enabled => false;

		public bool HierarchyManager_UIButton_Enabled => false;

		public bool HierarchyManager_UIEffect_Enabled => false;
	}
}
