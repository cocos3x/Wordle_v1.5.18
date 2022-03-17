using UnityEngine;

public class TimerScript : MonoBehaviour
{
	public static TimerScript timer;

	public float countDownTime;

	public bool countDown;

	public bool timerStart;

	public float timeRemaining;

	public bool pause;

	public bool playTick;

	public AudioClip tick;

	public AudioClip timeUp;

	private float prevTimeRemaining;

	private float volume;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DoPlayTick()
	{
	}

	private void OnTimerComplete()
	{
	}

	private float TimeTaken()
	{
		return 0f;
	}

	public void OnPauseTimer()
	{
	}
}
