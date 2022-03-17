using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class myScoreScript : MonoBehaviour
{
	public TextMeshProUGUI postitionText;

	public TextMeshProUGUI wordsFoundText;

	public TextMeshProUGUI scoreText;

	public GameObject noScoreImage;

	public GameObject isNewText;

	public Image Difficulty;

	public Image Timer;

	public Sprite easyDifficulty;

	public Sprite mediumDifficulty;

	public Sprite hardDifficulty;

	public Sprite veryHardDifficulty;

	public Sprite noTime;

	public Sprite time1;

	public Sprite time2;

	public Sprite time3;

	private int position;

	private string AddOrdinal(int num)
	{
		return "";
	}

	public void NoScoreDetails()
	{
	}

	public void UpdateScoreDetails(int pos, int score, int difficulty, float timeGiven, int wordsFound, DateTime date)
	{
	}
}
