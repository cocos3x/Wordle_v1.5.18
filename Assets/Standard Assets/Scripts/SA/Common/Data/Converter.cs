using System.Collections.Generic;

namespace SA.Common.Data
{
	public class Converter
	{
		public const char DATA_SPLITTER = '|';

		public const string DATA_SPLITTER2 = "|%|";

		public const string ARRAY_SPLITTER = "%%%";

		public const string DATA_EOF = "endofline";

		public static string SerializeArray(List<string> array, string splitter = "%%%")
		{
			return "";
		}

		public static string SerializeArray(string[] array, string splitter = "%%%")
		{
			return "";
		}

		public static string[] ParseArray(string arrayData, string splitter = "%%%")
		{
			return null;
		}
	}
}
