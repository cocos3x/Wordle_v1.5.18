using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnityEngine.UI.Extensions
{
	public class ReorderableListContent : MonoBehaviour
	{
		private sealed class _003CRefreshChildren_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ReorderableListContent _003C_003E4__this;

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
			public _003CRefreshChildren_003Ed__7(int _003C_003E1__state)
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

		private List<Transform> _cachedChildren;

		private List<ReorderableListElement> _cachedListElement;

		private ReorderableListElement _ele;

		private ReorderableList _extList;

		private RectTransform _rect;

		public void OnTransformChildrenChanged()
		{
		}

		public void Init(ReorderableList extList)
		{
		}

		private IEnumerator RefreshChildren()
		{
			return null;
		}
	}
}
