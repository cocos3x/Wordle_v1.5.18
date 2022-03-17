using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DawgSharp
{
	internal class OldDawg<TPayload> : IDawg<TPayload>
	{
		private class NodeByPayloadComparer : IComparer<Node<TPayload>>
		{
			public int Compare(Node<TPayload> x, Node<TPayload> y)
			{
				return 0;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<Node<TPayload>, int> _003C_003E9__7_0;

			public static Func<Node<TPayload>, int, _003C_003Ef__AnonymousType0<Node<TPayload>, int>> _003C_003E9__7_1;

			public static Func<_003C_003Ef__AnonymousType0<Node<TPayload>, int>, Node<TPayload>> _003C_003E9__7_2;

			public static Func<_003C_003Ef__AnonymousType0<Node<TPayload>, int>, int> _003C_003E9__7_3;

			public static Func<Node<TPayload>, bool> _003C_003E9__7_4;

			public static Func<Node<TPayload>, IEnumerable<char>> _003C_003E9__7_5;

			public static Func<char, char> _003C_003E9__7_6;

			public static Func<Node<TPayload>, _003C_003Ef__AnonymousType1<bool, bool>> _003C_003E9__8_0;

			public static Func<IGrouping<_003C_003Ef__AnonymousType1<bool, bool>, Node<TPayload>>, _003C_003Ef__AnonymousType1<bool, bool>> _003C_003E9__8_1;

			public static Func<IGrouping<_003C_003Ef__AnonymousType1<bool, bool>, Node<TPayload>>, Node<TPayload>[]> _003C_003E9__8_2;

			public static Func<Node<TPayload>, int, _003C_003Ef__AnonymousType0<Node<TPayload>, int>> _003C_003E9__8_3;

			public static Func<_003C_003Ef__AnonymousType0<Node<TPayload>, int>, Node<TPayload>> _003C_003E9__8_4;

			public static Func<_003C_003Ef__AnonymousType0<Node<TPayload>, int>, int> _003C_003E9__8_5;

			public static Func<Node<TPayload>, IEnumerable<char>> _003C_003E9__8_6;

			public static Func<char, char> _003C_003E9__8_7;

			public static Func<KeyValuePair<char, Node<TPayload>>, char> _003C_003E9__10_0;

			internal int _003CSaveAsYaleDawg_003Eb__7_0(Node<TPayload> n)
			{
				return 0;
			}

			internal _003C_003Ef__AnonymousType0<Node<TPayload>, int> _003CSaveAsYaleDawg_003Eb__7_1(Node<TPayload> node, int i)
			{
				return null;
			}

			internal Node<TPayload> _003CSaveAsYaleDawg_003Eb__7_2(_003C_003Ef__AnonymousType0<Node<TPayload>, int> t)
			{
				return null;
			}

			internal int _003CSaveAsYaleDawg_003Eb__7_3(_003C_003Ef__AnonymousType0<Node<TPayload>, int> t)
			{
				return 0;
			}

			internal bool _003CSaveAsYaleDawg_003Eb__7_4(Node<TPayload> n)
			{
				return false;
			}

			internal IEnumerable<char> _003CSaveAsYaleDawg_003Eb__7_5(Node<TPayload> node)
			{
				return null;
			}

			internal char _003CSaveAsYaleDawg_003Eb__7_6(char c)
			{
				return '\0';
			}

			internal _003C_003Ef__AnonymousType1<bool, bool> _003CSaveAsMatrixDawg_003Eb__8_0(Node<TPayload> node)
			{
				return null;
			}

			internal _003C_003Ef__AnonymousType1<bool, bool> _003CSaveAsMatrixDawg_003Eb__8_1(IGrouping<_003C_003Ef__AnonymousType1<bool, bool>, Node<TPayload>> g)
			{
				return null;
			}

			internal Node<TPayload>[] _003CSaveAsMatrixDawg_003Eb__8_2(IGrouping<_003C_003Ef__AnonymousType1<bool, bool>, Node<TPayload>> g)
			{
				return null;
			}

			internal _003C_003Ef__AnonymousType0<Node<TPayload>, int> _003CSaveAsMatrixDawg_003Eb__8_3(Node<TPayload> node, int i)
			{
				return null;
			}

			internal Node<TPayload> _003CSaveAsMatrixDawg_003Eb__8_4(_003C_003Ef__AnonymousType0<Node<TPayload>, int> t)
			{
				return null;
			}

			internal int _003CSaveAsMatrixDawg_003Eb__8_5(_003C_003Ef__AnonymousType0<Node<TPayload>, int> t)
			{
				return 0;
			}

			internal IEnumerable<char> _003CSaveAsMatrixDawg_003Eb__8_6(Node<TPayload> node)
			{
				return null;
			}

			internal char _003CSaveAsMatrixDawg_003Eb__8_7(char c)
			{
				return '\0';
			}

			internal char _003CWriteChildrenNoLength_003Eb__10_0(KeyValuePair<char, Node<TPayload>> c)
			{
				return '\0';
			}
		}

		private readonly Node<TPayload> root;

		public TPayload this[IEnumerable<char> word] => (TPayload)null;

		private Node<TPayload> FindNode(IEnumerable<char> word)
		{
			return null;
		}

		public int GetLongestCommonPrefixLength(IEnumerable<char> word)
		{
			return 0;
		}

		public IEnumerable<KeyValuePair<string, TPayload>> MatchPrefix(IEnumerable<char> prefix)
		{
			return null;
		}

		public void SaveAsYaleDawg(BinaryWriter writer, Action<BinaryWriter, TPayload> writePayload)
		{
		}

		public void SaveAsMatrixDawg(BinaryWriter writer, Action<BinaryWriter, TPayload> writePayload)
		{
		}

		private static void WriteChildren(BinaryWriter writer, Dictionary<Node<TPayload>, int> nodeIndex, Node<TPayload>[] nodes, char[] allChars)
		{
		}

		private static void WriteChildrenNoLength(BinaryWriter writer, IEnumerable<Node<TPayload>> nodes, Dictionary<Node<TPayload>, int> nodeIndex, char[] allChars)
		{
		}

		private static void WriteInt(BinaryWriter writer, int charIndex, int countOfPossibleValues)
		{
		}

		internal OldDawg(Node<TPayload> root)
		{
		}

		public int GetNodeCount()
		{
			return 0;
		}
	}
}
