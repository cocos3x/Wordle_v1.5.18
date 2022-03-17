using System.Collections.Generic;

namespace DawgSharp
{
	public class DawgBuilder<TPayload>
	{
		private readonly Node<TPayload> root;

		private readonly List<Node<TPayload>> lastPath;

		private string lastKey;

		public void Insert(IEnumerable<char> key, TPayload value)
		{
		}

		private void InsertLastPath(string strKey, TPayload value)
		{
		}

		private static void DoInsert(Node<TPayload> node, IEnumerable<char> key, TPayload value)
		{
		}

		public bool TryGetValue(IEnumerable<char> key, out TPayload value)
		{
			return false;
		}

		public Dawg<TPayload> BuildDawg()
		{
			return null;
		}
	}
}
