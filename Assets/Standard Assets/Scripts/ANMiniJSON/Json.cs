using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ANMiniJSON
{
	public static class Json
	{
		private sealed class Parser : IDisposable
		{
			private enum TOKEN
			{
				NONE,
				CURLY_OPEN,
				CURLY_CLOSE,
				SQUARED_OPEN,
				SQUARED_CLOSE,
				COLON,
				COMMA,
				STRING,
				NUMBER,
				TRUE,
				FALSE,
				NULL
			}

			private const string WHITE_SPACE = " \t\n\r";

			private const string WORD_BREAK = " \t\n\r{}[],:\"";

			private StringReader json;

			private char PeekChar => '\0';

			private char NextChar => '\0';

			private string NextWord => "";

			private TOKEN NextToken => (TOKEN)null;

			private Parser(string jsonString)
			{
			}

			public static object Parse(string jsonString)
			{
				return null;
			}

			public void Dispose()
			{
			}

			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			private List<object> ParseArray()
			{
				return null;
			}

			private object ParseValue()
			{
				return null;
			}

			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			private string ParseString()
			{
				return "";
			}

			private object ParseNumber()
			{
				return null;
			}

			private void EatWhitespace()
			{
			}
		}

		private sealed class Serializer
		{
			private StringBuilder builder;

			private Serializer()
			{
			}

			public static string Serialize(object obj)
			{
				return "";
			}

			private void SerializeValue(object value)
			{
			}

			private void SerializeObject(IDictionary obj)
			{
			}

			private void SerializeArray(IList anArray)
			{
			}

			private void SerializeString(string str)
			{
			}

			private void SerializeOther(object value)
			{
			}
		}

		public static object Deserialize(string json)
		{
			return null;
		}

		public static string Serialize(object obj)
		{
			return "";
		}
	}
}
