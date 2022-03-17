using System.Collections.Generic;

namespace DawgSharp
{
	internal class StackNode<TPayload>
	{
		public Node<TPayload> Node;

		public IEnumerator<KeyValuePair<char, Node<TPayload>>> ChildIterator;

		public int Level;
	}
}
