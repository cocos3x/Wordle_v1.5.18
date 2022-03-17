using UnityEngine;

public class BaseIOSFeaturePreview : MonoBehaviour
{
	protected GUIStyle style;

	protected int buttonWidth;

	protected int buttonHeight;

	protected float StartY;

	protected float StartX;

	protected float XStartPos;

	protected float YStartPos;

	protected float XButtonStep;

	protected float YButtonStep;

	protected float YLableStep;

	protected virtual void InitStyles()
	{
	}

	public virtual void Start()
	{
	}

	public void UpdateToStartPos()
	{
	}

	public void LoadLevel(string levelName)
	{
	}
}
