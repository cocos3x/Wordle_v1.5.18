using System;
using System.Collections.Generic;

[Serializable]
public class WordnikDefinition
{
	public string id;

	public string partOfSpeech;

	public string attributionText;

	public string sourceDictionary;

	public string text;

	public string sequence;

	public int score;

	public List<Label> labels;

	public List<Citation> citations;

	public string word;

	public List<RelatedWord> relatedWords;

	public List<ExampleUs> exampleUses;

	public List<TextPron> textProns;

	public List<Note> notes;

	public string attributionUrl;

	public string wordnikUrl;

	public string extendedText;

	public string seqString;
}
