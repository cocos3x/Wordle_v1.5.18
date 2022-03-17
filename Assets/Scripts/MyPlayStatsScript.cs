using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class MyPlayStatsScript : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<MyWords2, int> _003C_003E9__30_0;

		public static Func<MyWords2, int> _003C_003E9__30_1;

		public static Func<MyWords2, int> _003C_003E9__30_2;

		public static Func<MyWords2, int> _003C_003E9__30_3;

		public static Func<MyWords2, int> _003C_003E9__38_0;

		internal int _003CReOrderWordsList_003Eb__30_0(MyWords2 x)
		{
			return 0;
		}

		internal int _003CReOrderWordsList_003Eb__30_1(MyWords2 x)
		{
			return 0;
		}

		internal int _003CReOrderWordsList_003Eb__30_2(MyWords2 x)
		{
			return 0;
		}

		internal int _003CReOrderWordsList_003Eb__30_3(MyWords2 x)
		{
			return 0;
		}

		internal int _003CInitialize_003Eb__38_0(MyWords2 x)
		{
			return 0;
		}
	}

	private sealed class _003CInitialize_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MyPlayStatsScript _003C_003E4__this;

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
		public _003CInitialize_003Ed__38(int _003C_003E1__state)
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

	public static MyPlayStatsScript myPlayStatsScript;

	public TextMeshProUGUI highestLevelText;

	public TextMeshProUGUI highestLevelTextMedal;

	public TextMeshProUGUI MedalText;

	public TextMeshProUGUI highestLevelDescText;

	public VerticalScrollSnap verticalScrollSnap;

	public RectTransform ScrollView;

	public Transform myWordsContent;

	public GameObject wordPanelPrefab;

	public int WordPanelHeight;

	public Color NormalBronze;

	public Color NormalSilver;

	public Color NormalGold;

	public GameObject rossette;

	public Image rossetteImage;

	public Image medal;

	public GameObject lvlGrpStandard;

	public GameObject lvlGrpMedal;

	public myWordScript WordOfTheWeek;

	public TextMeshProUGUI wordText;

	public TextMeshProUGUI DefinitionText;

	public GameObject wordnikAtt;

	public bool showingDefinitions;

	private int currentIndex;

	private bool orderByLength;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void ResizeScrollView()
	{
	}

	public void ReInitialize()
	{
	}

	public void GoToTopMyWords()
	{
	}

	public void ReOrderWordsList()
	{
	}

	public void PopulateMyWordsList()
	{
	}

	public void PopulateMyWordsList(List<MyWords2> myWords)
	{
	}

	public void GetDefinition(int index)
	{
	}

	public void GetNextDefinition()
	{
	}

	public void GetPreviousDefinition()
	{
	}

	public void onShowDefinitions()
	{
	}

	public void OnSelectWord(int index, int position)
	{
	}

	private IEnumerator Initialize()
	{
		return null;
	}
}
