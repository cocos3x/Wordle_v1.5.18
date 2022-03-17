namespace UnityEngine.UI.Extensions
{
	public class Gradient2 : BaseMeshEffect
	{
		public enum Type
		{
			Horizontal,
			Vertical
		}

		public enum Blend
		{
			Override,
			Add,
			Multiply
		}

		[SerializeField]
		private Type _gradientType;

		[SerializeField]
		private Blend _blendMode;

		[SerializeField]
		private float _offset;

		[SerializeField]
		private UnityEngine.Gradient _effectGradient;

		public Blend BlendMode
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (Blend)null;
			}
			set
			{
			}
		}

		public UnityEngine.Gradient EffectGradient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type GradientType
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (Type)null;
			}
			set
			{
			}
		}

		public float Offset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper helper)
		{
		}

		private Color BlendColor(Color colorA, Color colorB)
		{
			return (Color)null;
		}
	}
}
