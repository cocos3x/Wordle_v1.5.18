using System;
using System.Collections.Generic;
using System.Linq;

namespace DawgSharp
{
	internal class Node<TPayload>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<char, Node<TPayload>>, char> _003C_003E9__12_0;

			internal char _003Cget_SortedChildren_003Eb__12_0(KeyValuePair<char, Node<TPayload>> e)
			{
				return '\0';
			}
		}

		private readonly Dictionary<char, Node<TPayload>> children;

		private TPayload _003CPayload_003Ek__BackingField;

		public TPayload Payload
		{
			get
			{
				return (TPayload)null;
			}
			set
			{
			}
		}

		public bool HasChildren => false;

		public Dictionary<char, Node<TPayload>> Children => null;

		public IOrderedEnumerable<KeyValuePair<char, Node<TPayload>>> SortedChildren => null;

		public bool HasPayload => false;

		public Node<TPayload> GetOrAddEdge(char c)
		{
			return null;
		}

		public Node<TPayload> GetChild(char c)
		{
			return null;
		}

		public int GetRecursiveChildNodeCount()
		{
			return 0;
		}

		public IEnumerable<Node<TPayload>> GetAllDistinctNodes()
		{
			return null;
		}
	}
}
