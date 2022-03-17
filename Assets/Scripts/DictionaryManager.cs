using DawgSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DictionaryManager : MonoBehaviour
{
	private sealed class _003CDoLoadDawg_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string prefix;

		public DictionaryManager _003C_003E4__this;

		private Stream _003Cstream_003E5__2;

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
		public _003CDoLoadDawg_003Ed__13(int _003C_003E1__state)
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

	private sealed class _003CDoLoadDictionary_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string prefix;

		public DictionaryManager _003C_003E4__this;

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
		public _003CDoLoadDictionary_003Ed__14(int _003C_003E1__state)
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<string, bool>, string> _003C_003E9__19_0;

		internal string _003CWordsFromPrefix_003Eb__19_0(KeyValuePair<string, bool> kvp)
		{
			return "";
		}
	}

	private sealed class _003CGetWordnikWordDefinition_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string word;

		public GameObject atributionImg;

		public DictionaryManager _003C_003E4__this;

		public TextMeshProUGUI defText;

		public TextMeshProUGUI wordText;

		private string _003Cdefinition_003E5__2;

		private string _003CwordnikURL_003E5__3;

		private UnityWebRequest _003CwebRequest_003E5__4;

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
		public _003CGetWordnikWordDefinition_003Ed__21(int _003C_003E1__state)
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

	public static DictionaryManager dictionary;

	public Dictionary<string, string> langDictionary;

	private Dawg<bool> dawg;

	private Dawg<bool> dawgRev;

	public int minWordLength;

	public Text debugText;

	private void Awake()
	{
	}

	private void MakeThisTheOnlyDictionaryManager()
	{
	}

	private void Start()
	{
	}

	public void LoadDictionary()
	{
	}

	public List<string> TextAssetToList(TextAsset ta)
	{
		return null;
	}

	public List<string> TextAssetToList(TextAsset ta, string seperator)
	{
		return null;
	}

	public string Reverse(string s)
	{
		return "";
	}

	private IEnumerator DoLoadDawg(string prefix)
	{
		return null;
	}

	private IEnumerator DoLoadDictionary(string prefix)
	{
		return null;
	}

	private void CreateDictionaryDawgs()
	{
	}

	private void PopulateDictionary(string file, string prefix)
	{
	}

	public bool IsWord(string word)
	{
		return false;
	}

	public bool IsPrefix(IEnumerable<char> prefix, bool useRevDictionaryLookup)
	{
		return false;
	}

	public string WordsFromPrefix(IEnumerable<char> prefix)
	{
		return "";
	}

	public string FormatHTMLToTMP(string text)
	{
		return "";
	}

	private IEnumerator GetWordnikWordDefinition(string word, TextMeshProUGUI wordText, TextMeshProUGUI defText, GameObject atributionImg)
	{
		return null;
	}

	public void DefinitionFromWordToTMP(string word, TextMeshProUGUI wordText, TextMeshProUGUI defText, GameObject atributionImg)
	{
	}

	public string DefinitionFromWord(string word)
	{
		return "";
	}

	private void PopulateLetters_EN()
	{
	}

	private void PopulateLetters_FR()
	{
	}

	private void PopulateLetters_DE()
	{
	}

	private void PopulateLetters_IT()
	{
	}

	private void PopulateLetters_ES()
	{
	}
}
