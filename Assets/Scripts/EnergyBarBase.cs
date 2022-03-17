using System;
using UnityEngine;

public abstract class EnergyBarBase : MonoBehaviour
{
	public enum Pivot
	{
		TopLeft,
		Top,
		TopRight,
		Right,
		BottomRight,
		Bottom,
		BottomLeft,
		Left,
		Center
	}

	[Serializable]
	public class Tex : AbstractTex
	{
		public Texture2D texture;

		public virtual int width => 0;

		public virtual int height => 0;

		public virtual bool Valid => false;

		public override int GetHashCode()
		{
			return 0;
		}
	}

	public class AbstractTex
	{
		public Color color;
	}

	public enum GrowDirection
	{
		LeftToRight,
		RightToLeft,
		BottomToTop,
		TopToBottom,
		RadialCW,
		RadialCCW,
		ExpandHorizontal,
		ExpandVertical,
		ColorChange
	}

	public enum ColorType
	{
		Solid,
		Gradient
	}

	public enum SmoothDirection
	{
		Both,
		OnlyWhenDecreasing,
		OnlyWhenIncreasing
	}

	public enum BurnDirection
	{
		Both,
		OnlyWhenDecreasing,
		OnlyWhenIncreasing
	}

	public abstract class TransformFunction
	{
		public AnimationCurve animationCurve;
	}

	[Serializable]
	public class TranslateFunction : TransformFunction
	{
		public Vector2 startPosition;

		public Vector2 endPosition;

		public Vector2 Value(float progress)
		{
			return (Vector2)null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	[Serializable]
	public class ScaleFunction : TransformFunction
	{
		public Vector2 startScale;

		public Vector2 endScale;

		public Vector3 Value(float progress)
		{
			return (Vector3)null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	[Serializable]
	public class RotateFunction : TransformFunction
	{
		public float startAngle;

		public float endAngle;

		public Quaternion Value(float progress)
		{
			return (Quaternion)null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	[Serializable]
	public class Notify
	{
		public MonoBehaviour receiver;

		public string methodName;

		public event Action<EnergyBarBase> eventReceiver
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Execute(EnergyBarBase sender)
		{
		}
	}

	[SerializeField]
	protected int version;

	public bool labelEnabled;

	public Vector2 labelPosition;

	public bool labelPositionNormalized;

	public string labelFormat;

	public Color labelColor;

	public bool effectSmoothChange;

	public float effectSmoothChangeSpeed;

	public SmoothDirection effectSmoothChangeDirection;

	public Notify effectSmoothChangeFinishedNotify;

	private bool effectSmoothChangeWorking;

	public bool effectBurn;

	public Texture2D effectBurnTextureBar;

	public string atlasEffectBurnTextureBarGUID;

	public Color effectBurnTextureBarColor;

	public Notify effectBurnFinishedNotify;

	public BurnDirection effectBurnDirection;

	private bool effectBurnWorking;

	private EnergyBar _energyBar;

	protected float ValueFBurn;

	protected float ValueF2;

	[SerializeField]
	private Color _tint;

	private string labelCache;

	private int labelCacheParamsHash;

	protected EnergyBar energyBar => null;

	public abstract Rect DrawAreaRect
	{
		get;
	}

	public bool isBurning => false;

	protected float ValueF => 0f;

	protected Vector2 LabelPositionPixels => (Vector2)null;

	public float displayValue => 0f;

	public float opacity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Color tint
	{
		get
		{
			return (Color)null;
		}
		set
		{
		}
	}

	public bool burning => false;

	public virtual void ResetAnimations()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	private void UpdateAnimations()
	{
	}

	private void UpdateBurnValue()
	{
	}

	private void UpdateBarValue()
	{
	}

	protected bool RepaintPhase()
	{
		return false;
	}

	protected string LabelFormatResolve(string format)
	{
		return "";
	}

	protected Vector4 ToVector4(Rect r)
	{
		return (Vector4)null;
	}

	protected Vector2 Round(Vector2 v)
	{
		return (Vector2)null;
	}

	protected virtual bool IsVisible()
	{
		return false;
	}

	protected Color PremultiplyAlpha(Color c)
	{
		return (Color)null;
	}

	protected virtual Color ComputeColor(Color localColor)
	{
		return (Color)null;
	}

	protected static Color Multiply(Color c1, Color c2)
	{
		return (Color)null;
	}

	protected static int HashAdd(int current, bool obj)
	{
		return 0;
	}

	protected static int HashAdd(int current, int obj)
	{
		return 0;
	}

	protected static int HashAdd(int current, float obj)
	{
		return 0;
	}

	protected static int HashAdd(int current, UnityEngine.Object obj)
	{
		return 0;
	}

	protected static int HashAdd(int current, object obj)
	{
		return 0;
	}

	protected static int HashAddTexture(int current, Texture texture)
	{
		return 0;
	}

	protected static int HashAddArray(int current, object[] arr)
	{
		return 0;
	}

	protected static int HashAddTextureArray(int current, Texture[] arr, string name = "")
	{
		return 0;
	}

	protected Rect FindBounds(Texture2D texture)
	{
		return (Rect)null;
	}

	protected void Expand(int x, int y, ref int left, ref int top, ref int right, ref int bottom)
	{
	}
}
