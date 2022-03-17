using DoozyUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelPanelScript : MonoBehaviour
{
	private sealed class _003CDoLoadGame_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelPanelScript _003C_003E4__this;

		public int stage;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDoLoadGame_003Ed__50(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public TextMeshProUGUI LevelText;

	public TextMeshProUGUI LevelTextStandard;

	public TextMeshProUGUI ContextText;

	public TextMeshProUGUI LetterText;

	public TextMeshProUGUI RankText;

	public TextMeshProUGUI MedalText;

	public GameObject levelGrpStandard;

	public GameObject levelGrpMedal;

	public GameObject locked;

	public Image lockedBanner;

	public GameObject Rosette;

	public UIButton StageButton;

	public Image levelBackground;

	public GameObject levelBackgroundInner;

	public Image stageButtonBackground;

	public Image rosetteImage;

	public List<GameObject> levelObjects;

	public GameObject Level1;

	public GameObject Level2;

	public GameObject Level3;

	public GameObject Level4;

	public GameObject Level5;

	public GameObject Bonus;

	public GameObject Level1Btn;

	public GameObject Level2Btn;

	public GameObject Level3Btn;

	public GameObject Level4Btn;

	public GameObject Level5Btn;

	public GameObject BonusBtn;

	public Color DisabledColor;

	public Color DisabledBlue;

	public Color NormalBlue;

	public Color DisabledBronze;

	public Color NormalBronze;

	public Color DisabledSilver;

	public Color NormalSilver;

	public Color DisabledGold;

	public Color NormalGold;

	public Image StageButtonImage;

	public Image StagePanel;

	public Image LevelPanel;

	public Sprite LevelComplete;

	public Sprite LevelNotComplete;

	public Color LevelNotCompleteColor;

	private Level thisLevel;

	private Level previousLevel;

	private wordleLevelStats thisStageStats;

	private wordleLevelStats previousStageStats;

	public void UpdateStageDetails(Level level)
	{
	}

	public void OnLoadGame(int stage)
	{
	}

	private IEnumerator DoLoadGame(int stage)
	{
		return null;
	}
}
