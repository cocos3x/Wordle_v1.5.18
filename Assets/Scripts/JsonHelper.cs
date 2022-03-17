using System;

public class JsonHelper
{
	[Serializable]
	private class WordnikDefinitions<WordnikDefinition>
	{
		public WordnikDefinition[] Items;
	}

	public static WordnikDefinition[] FromJson<WordnikDefinition>(string json)
	{
		return null;
	}
}
