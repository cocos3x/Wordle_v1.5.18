using System;
using System.Collections.Generic;

namespace DawgSharp
{
	public static class DawgExtensions
	{
		public static Dawg<TPayload> ToDawg<T, TPayload>(this IEnumerable<T> enumerable, Func<T, IEnumerable<char>> key, Func<T, TPayload> payload)
		{
			return null;
		}
	}
}
