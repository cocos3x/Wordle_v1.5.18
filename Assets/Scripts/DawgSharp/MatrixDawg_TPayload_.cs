using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DawgSharp
{
	internal class MatrixDawg<TPayload> : IDawg<TPayload>
	{
		private struct StackItem
		{
			public int node_i;

			public int child_i;
		}

		private sealed class _003CGetPath_003Ed__2 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MatrixDawg<TPayload> _003C_003E4__this;

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
			public _003CGetPath_003Ed__2(int _003C_003E1__state)
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

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<int, bool> _003C_003E9__4_0;

			public static Func<BinaryReader, char> _003C_003E9__18_0;

			internal bool _003CGetLongestCommonPrefixLength_003Eb__4_0(int i)
			{
				return false;
			}

			internal char _003C_002Ector_003Eb__18_0(BinaryReader r)
			{
				return '\0';
			}
		}

		private sealed class _003CMatchPrefix_003Ed__6 : IEnumerable<KeyValuePair<string, TPayload>>, IEnumerable, IEnumerator<KeyValuePair<string, TPayload>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, TPayload> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<char> prefix;

			public IEnumerable<char> _003C_003E3__prefix;

			public MatrixDawg<TPayload> _003C_003E4__this;

			private string _003CprefixStr_003E5__2;

			private int _003Cnode_i_003E5__3;

			private Stack<StackItem> _003Cstack_003E5__4;

			private StringBuilder _003Csb_003E5__5;

			private int _003Cchild_i_003E5__6;

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
			public _003CMatchPrefix_003Ed__6(int _003C_003E1__state)
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

		private sealed class _003CReadSequence_003Ed__22<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Func<BinaryReader, T> read;

			public Func<BinaryReader, T> _003C_003E3__read;

			private BinaryReader reader;

			public BinaryReader _003C_003E3__reader;

			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return (T)null;
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
			public _003CReadSequence_003Ed__22(int _003C_003E1__state)
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

			[DebuggerHidden]
			private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
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

		private readonly int[,] children1;

		private readonly int[,] children0;

		private readonly char[] indexToChar;

		private readonly ushort[] charToIndexPlusOne;

		private readonly int nodeCount;

		private readonly int rootNodeIndex;

		private readonly char firstChar;

		private readonly char lastChar;

		public TPayload this[IEnumerable<char> word] => (TPayload)null;

		private IEnumerable<int> GetPath(IEnumerable<char> word)
		{
			return null;
		}

		private int GetChildIndexPlusOne(int node_i, char c)
		{
			return 0;
		}

		public int GetLongestCommonPrefixLength(IEnumerable<char> word)
		{
			return 0;
		}

		public IEnumerable<KeyValuePair<string, TPayload>> MatchPrefix(IEnumerable<char> prefix)
		{
			return null;
		}

		public void SaveAsOldDawg(Stream stream, Action<BinaryWriter, TPayload> writePayload)
		{
		}

		public int GetNodeCount()
		{
			return 0;
		}

		public MatrixDawg(BinaryReader reader, Func<BinaryReader, TPayload> readPayload)
		{
		}

		public static ushort[] GetCharToIndexPlusOneMap(char[] uniqueChars)
		{
			return null;
		}

		private static int[,] ReadChildren(BinaryReader reader, char[] indexToChar)
		{
			return null;
		}

		public static T[] ReadArray<T>(BinaryReader reader, Func<BinaryReader, T> read)
		{
			return null;
		}

		private static IEnumerable<T> ReadSequence<T>(BinaryReader reader, Func<BinaryReader, T> read)
		{
			return null;
		}
	}
}
