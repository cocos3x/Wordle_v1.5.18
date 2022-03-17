using DoozyUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;

namespace SIS
{
	public class ShopManager : MonoBehaviour
	{
		private sealed class _003CStart_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShopManager _003C_003E4__this;

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
			public _003CStart_003Ed__12(int _003C_003E1__state)
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

		private static ShopManager instance;

		public UIElement errorWindow;

		public GameObject confirmWindow;

		public TextMeshProUGUI message;

		public List<ShopContainer> containers;

		public Dictionary<string, IAPItem> IAPItems;

		public static event Action<string> itemSelectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string> itemDeselectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		public static ShopManager GetInstance()
		{
			return null;
		}

		public void Init()
		{
		}

		public static void RefreshAll()
		{
		}

		public void Refresh(string id)
		{
		}

		public static void OverwriteWithFetch(Product[] products)
		{
		}

		public static void SetToSelected(IAPItem item)
		{
		}

		public static void SetToDeselected(IAPItem item)
		{
		}

		public static void ShowMessage(string text)
		{
		}

		public static void ShowConfirmation()
		{
		}

		public static IAPItem GetIAPItem(string id)
		{
			return null;
		}

		public ShopContainer GetContainer(string id)
		{
			return null;
		}
	}
}
