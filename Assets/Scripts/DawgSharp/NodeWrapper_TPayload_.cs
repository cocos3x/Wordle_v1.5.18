using System;
using System.Collections.Generic;

namespace DawgSharp
{
	internal class NodeWrapper<TPayload>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<char, Node<TPayload>>, char> _003C_003E9__5_0;

			internal char _003CGetSortedChildren_003Eb__5_0(KeyValuePair<char, Node<TPayload>> c)
			{
				return '\0';
			}
		}

		public readonly Node<TPayload> Node;

		public readonly Node<TPayload> Super;

		public readonly char Char;

		private KeyValuePair<char, Node<TPayload>>[] sortedChildren;

		public KeyValuePair<char, Node<TPayload>>[] SortedChildren => null;

		public NodeWrapper(Node<TPayload> node, Node<TPayload> super, char @char)
		{
		}

		private KeyValuePair<char, Node<TPayload>>[] GetSortedChildren()
		{
			return null;
		}
	}
}
