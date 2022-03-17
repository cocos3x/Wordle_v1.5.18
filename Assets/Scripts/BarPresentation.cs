using System;
using UnityEngine;

public class BarPresentation : MonoBehaviour
{
	[Serializable]
	public class Slide
	{
		public GameObject gameObject;

		public void Show()
		{
		}

		public void Hide()
		{
		}
	}

	public int currentSlideNum;

	public GameObject slidesBar;

	public Slide[] slides;

	private Slide currentSlide;

	private EnergyBar bar;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private void HideAll()
	{
	}

	private void NextSlide()
	{
	}

	private void PreviousSlide()
	{
	}

	private void ChangeSlide(int num)
	{
	}
}
