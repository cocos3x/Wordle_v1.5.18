using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UnityEditor.XCodeEditor
{
	public class PBXParser
	{
		public const string PBX_HEADER_TOKEN = "// !$*UTF8*$!\n";

		public const char WHITESPACE_SPACE = ' ';

		public const char WHITESPACE_TAB = '\t';

		public const char WHITESPACE_NEWLINE = '\n';

		public const char WHITESPACE_CARRIAGE_RETURN = '\r';

		public const char ARRAY_BEGIN_TOKEN = '(';

		public const char ARRAY_END_TOKEN = ')';

		public const char ARRAY_ITEM_DELIMITER_TOKEN = ',';

		public const char DICTIONARY_BEGIN_TOKEN = '{';

		public const char DICTIONARY_END_TOKEN = '}';

		public const char DICTIONARY_ASSIGN_TOKEN = '=';

		public const char DICTIONARY_ITEM_DELIMITER_TOKEN = ';';

		public const char QUOTEDSTRING_BEGIN_TOKEN = '"';

		public const char QUOTEDSTRING_END_TOKEN = '"';

		public const char QUOTEDSTRING_ESCAPE_TOKEN = '\\';

		public const char END_OF_FILE = '\u001a';

		public const string COMMENT_BEGIN_TOKEN = "/*";

		public const string COMMENT_END_TOKEN = "*/";

		public const string COMMENT_LINE_TOKEN = "//";

		private const int BUILDER_CAPACITY = 20000;

		private char[] data;

		private int index;

		private PBXResolver resolver;

		private string marker;

		public PBXDictionary Decode(string data)
		{
			return null;
		}

		public string Encode(PBXDictionary pbxData, bool readable = false)
		{
			return "";
		}

		private void Indent(StringBuilder builder, int deep)
		{
		}

		private void Endline(StringBuilder builder, bool useSpace = false)
		{
		}

		private void MarkSection(StringBuilder builder, string name)
		{
		}

		private bool GUIDComment(string guid, StringBuilder builder)
		{
			return false;
		}

		private char NextToken()
		{
			return '\0';
		}

		private string Peek(int step = 1)
		{
			return "";
		}

		private bool SkipWhitespaces()
		{
			return false;
		}

		private bool SkipComments()
		{
			return false;
		}

		private char StepForeward(int step = 1)
		{
			return '\0';
		}

		private char StepBackward(int step = 1)
		{
			return '\0';
		}

		private object ParseValue()
		{
			return null;
		}

		private PBXDictionary ParseDictionary()
		{
			return null;
		}

		private PBXList ParseArray()
		{
			return null;
		}

		private object ParseString()
		{
			return null;
		}

		private object ParseEntity()
		{
			return null;
		}

		private bool SerializeValue(object value, StringBuilder builder, bool readable = false, int indent = 0)
		{
			return false;
		}

		private bool SerializeDictionary(Dictionary<string, object> dictionary, StringBuilder builder, bool readable = false, int indent = 0)
		{
			return false;
		}

		private bool SerializeArray(ArrayList anArray, StringBuilder builder, bool readable = false, int indent = 0)
		{
			return false;
		}

		private bool SerializeString(string aString, StringBuilder builder, bool useQuotes = false, bool readable = false)
		{
			return false;
		}
	}
}
