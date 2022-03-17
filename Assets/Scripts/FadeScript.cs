using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
	public static FadeScript fadescript;

	public Texture2D fadeOutTexture;

	public float fadeSpeed;

	private int drawDepth;

	private float alpha;

	private int fadeDir;

	private void Awake()
	{
	}

	private void MakeThisTheOnlyFadeScript()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGUI()
	{
	}

	public float BeginFade(int direction)
	{
		return 0f;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}
}
