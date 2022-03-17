using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DawgSharp
{
	internal class YaleDawg<TPayload> : IDawg<TPayload>
	{
		private struct Child
		{
			public readonly int Index;

			public readonly ushort CharIndex;

			public Child(int index, ushort charIndex)
			{
			}
		}

		private class ChildComparer : IComparer<Child>
		{
			public int Compare(Child x, Child y)
			{
				return 0;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<BinaryReader, char> _003C_003E9__10_0;

			public static Func<int, bool> _003C_003E9__18_0;

			internal char _003C_002Ector_003Eb__10_0(BinaryReader r)
			{
				return '\0';
			}

			internal bool _003CDawgSharp_002EIDawg_003CTPayload_003E_002EGetLongestCommonPrefixLength_003Eb__18_0(int i)
			{
				return false;
			}
		}

		private sealed class _003CGetPath_003Ed__17 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public YaleDawg<TPayload> _003C_003E4__this;

			private IEnumerable<char> word;

			public IEnumerable<char> _003C_003E3__word;

			private int _003Cnode_i_003E5__2;

			private IEnumerator<char> _003C_003E7__wrap2;

			private int System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EInt32_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return 0;
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
			public _003CGetPath_003Ed__17(int _003C_003E1__state)
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
			private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EInt32_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private sealed class _003CMatchPrefix_003Ed__20 : IEnumerable<KeyValuePair<string, TPayload>>, IEnumerable, IEnumerator<KeyValuePair<string, TPayload>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, TPayload> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int node_i;

			public int _003C_003E3__node_i;

			public YaleDawg<TPayload> _003C_003E4__this;

			private StringBuilder sb;

			public StringBuilder _003C_003E3__sb;

			private int _003ClastChild_i_003E5__2;

			private int _003Ci_003E5__3;

			private IEnumerator<KeyValuePair<string, TPayload>> _003C_003E7__wrap3;

			private KeyValuePair<string, TPayload> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CTPayload_003E_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return (KeyValuePair<string, TPayload>)null;
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
			public _003CMatchPrefix_003Ed__20(int _003C_003E1__state)
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
			private IEnumerator<KeyValuePair<string, TPayload>> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CTPayload_003E_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private readonly TPayload[] payloads;

		private readonly char[] indexToChar;

		private readonly ushort[] charToIndexPlusOne;

		private readonly int nodeCount;

		private readonly int rootNodeIndex;

		private readonly char firstChar;

		private readonly char lastChar;

		private readonly int[] firstChildForNode;

		private readonly Child[] children;

		private static readonly ChildComparer childComparer;

		private TPayload DawgSharp_002EIDawg_003CTPayload_003E_002EItem => (TPayload)null;

		public YaleDawg(BinaryReader reader, Func<BinaryReader, TPayload> readPayload)
		{
		}

		internal static ushort ReadInt(BinaryReader reader, int countOfPossibleValues)
		{
			//IL_0003: Expected I4, but got O
			return (ushort)(int)null;
		}

		private TPayload GetPayload(int node_i)
		{
			return (TPayload)null;
		}

		private IEnumerable<int> GetPath(IEnumerable<char> word)
		{
			return null;
		}

		private int DawgSharp_002EIDawg_003CTPayload_003E_002EGetLongestCommonPrefixLength(IEnumerable<char> word)
		{
			return 0;
		}

		private IEnumerable<KeyValuePair<string, TPayload>> DawgSharp_002EIDawg_003CTPayload_003E_002EMatchPrefix(IEnumerable<char> prefix)
		{
			return null;
		}

		private IEnumerable<KeyValuePair<string, TPayload>> MatchPrefix(StringBuilder sb, int node_i)
		{
			return null;
		}

		private int DawgSharp_002EIDawg_003CTPayload_003E_002EGetNodeCount()
		{
			return 0;
		}
	}
}
