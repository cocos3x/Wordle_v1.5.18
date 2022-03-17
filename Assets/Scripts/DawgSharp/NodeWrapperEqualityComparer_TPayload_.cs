using System.Collections.Generic;

namespace DawgSharp
{
	internal class NodeWrapperEqualityComparer<TPayload> : IEqualityComparer<NodeWrapper<TPayload>>
	{
		public bool Equals(NodeWrapper<TPayload> x, NodeWrapper<TPayload> y)
		{
			return false;
		}

		private static bool SequenceEqual(IEnumerable<KeyValuePair<char, Node<TPayload>>> x, IEnumerable<KeyValuePair<char, Node<TPayload>>> y)
		{
			return false;
		}

		private static int GetHashCode(Node<TPayload> node)
		{
			return 0;
		}

		public int GetHashCode(NodeWrapper<TPayload> obj)
		{
			return 0;
		}
	}
}
