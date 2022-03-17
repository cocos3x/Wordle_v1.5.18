using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace SIS
{
	public class IAPItem : MonoBehaviour
	{
		private sealed class _003CDoPurchase_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IAPItem _003C_003E4__this;

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
			public _003CDoPurchase_003Ed__24(int _003C_003E1__state)
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

		public string productId;

		public TextMeshProUGUI title;

		public TextMeshProUGUI description;

		public bool uppercase;

		public Image icon;

		public TextMeshProUGUI[] price;

		public GameObject buyButton;

		public GameObject buyTrigger;

		public Text lockedLabel;

		public GameObject[] hideOnUnlock;

		public GameObject[] showOnUnlock;

		public GameObject sold;

		public GameObject selected;

		public GameObject selectButton;

		public GameObject deselectButton;

		private Toggle selCheck;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void Init(IAPObject obj)
		{
		}

		public void Init(Product product)
		{
		}

		public void Unlock()
		{
		}

		public void ConfirmPurchase(bool selected)
		{
		}

		private void Purchase()
		{
		}

		public void OnPurchase()
		{
		}

		private IEnumerator DoPurchase()
		{
			return null;
		}

		public void Purchased(bool state)
		{
		}

		public void IsSelected(bool thisSelect)
		{
		}

		public void Deselect()
		{
		}
	}
}
