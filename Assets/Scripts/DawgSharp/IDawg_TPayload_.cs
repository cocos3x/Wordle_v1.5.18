using System.Collections.Generic;

namespace DawgSharp
{
	internal interface IDawg<TPayload>
	{
		TPayload this[IEnumerable<char> word]
		{
			get;
		}

		int GetLongestCommonPrefixLength(IEnumerable<char> word);

		IEnumerable<KeyValuePair<string, TPayload>> MatchPrefix(IEnumerable<char> prefix);

		int GetNodeCount();
	}
}
