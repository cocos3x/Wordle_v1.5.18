using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SIS.SimpleJSON
{
	public class JSONClass : JSONNode, IEnumerable
	{
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public JSONNode aNode;

			internal bool _003CRemove_003Eb__0(KeyValuePair<string, JSONNode> k)
			{
				return false;
			}
		}

		private sealed class _003Cget_Childs_003Ed__16 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JSONNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public JSONClass _003C_003E4__this;

			private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003CSIS_002ESimpleJSON_002EJSONNode_003E_002ECurrent
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
			public _003Cget_Childs_003Ed__16(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003CSIS_002ESimpleJSON_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private sealed class _003CGetEnumerator_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JSONClass _003C_003E4__this;

			private Dictionary<string, JSONNode>.Enumerator _003C_003E7__wrap1;

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
			public _003CGetEnumerator_003Ed__17(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private Dictionary<string, JSONNode> m_Dict;

		public Dictionary<string, JSONNode>.KeyCollection Keys => null;

		public override JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int Count => 0;

		public override IEnumerable<JSONNode> Childs => null;

		public override void Add(string aKey, JSONNode aItem)
		{
		}

		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public override string ToString()
		{
			return "";
		}

		public override string ToString(string aPrefix)
		{
			return "";
		}

		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
}
