using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DawgSharp
{
	internal class PrefixMatcher<TPayload>
	{
		private sealed class _003CMatchPrefix_003Ed__2 : IEnumerable<KeyValuePair<string, TPayload>>, IEnumerable, IEnumerator<KeyValuePair<string, TPayload>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<string, TPayload> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Node<TPayload> node;

			public Node<TPayload> _003C_003E3__node;

			public PrefixMatcher<TPayload> _003C_003E4__this;

			private Dictionary<char, Node<TPayload>>.Enumerator _003C_003E7__wrap1;

			private IEnumerator<KeyValuePair<string, TPayload>> _003C_003E7__wrap2;

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
			public _003CMatchPrefix_003Ed__2(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
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

		private readonly StringBuilder sb;

		public PrefixMatcher(StringBuilder sb)
		{
		}

		public IEnumerable<KeyValuePair<string, TPayload>> MatchPrefix(Node<TPayload> node)
		{
			return null;
		}
	}
}
