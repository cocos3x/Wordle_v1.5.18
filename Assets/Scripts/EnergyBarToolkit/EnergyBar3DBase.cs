using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace EnergyBarToolkit
{
	public abstract class EnergyBar3DBase : EnergyBarBase
	{
		public new enum Pivot
		{
			Left,
			Top,
			Right,
			Bottom,
			TopLeft,
			TopRight,
			BottomRight,
			BottomLeft,
			Center
		}

		public enum BarType
		{
			Filled,
			Repeated,
			Sequence,
			Transform
		}

		public enum TextureMode
		{
			Textures,
			TextureAtlas
		}

		public enum LookAtMode
		{
			Disabled,
			CustomObject,
			MainCamera
		}

		[Serializable]
		public class AtlasTex : AbstractTex
		{
			public string spriteGUID;

			public bool Valid => false;

			public override int GetHashCode()
			{
				return 0;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static MadTransform.Predicate<MadSprite> _003C_003E9__48_0;

			internal bool _003CRebuild_003Eb__48_0(MadSprite s)
			{
				return false;
			}
		}

		public const int DepthSpace = 32;

		public MadPanel panel;

		public bool premultipliedAlpha;

		public int guiDepth;

		public GameObject anchorObject;

		public Camera anchorCamera;

		public TextureMode textureMode;

		public Tex[] texturesBackground;

		public Tex[] texturesForeground;

		public MadAtlas atlas;

		public AtlasTex[] atlasTexturesBackground;

		public AtlasTex[] atlasTexturesForeground;

		public LookAtMode lookAtMode;

		public GameObject lookAtObject;

		public MadFont labelFont;

		public float labelScale;

		public Pivot labelPivot;

		public bool editorSelectable;

		[SerializeField]
		private bool underThePanel;

		private MadText labelSprite;

		private List<MadSprite> spriteObjectsBg;

		private List<MadSprite> spriteObjectsFg;

		private List<GameObject> hiddenObjects;

		[SerializeField]
		private Pivot _pivot;

		private Transform anchorParentCache;

		private MadAnchor anchorCache;

		private Transform container;

		protected bool useAtlas => false;

		public virtual Pivot pivot
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (Pivot)null;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected override void Update()
		{
		}

		protected void UpdateContainer()
		{
		}

		private void UpdateLabel()
		{
		}

		private void UpdateAnchor()
		{
		}

		private void UpdateColors()
		{
		}

		private void UpdateTextureColors(List<MadSprite> sprites, AbstractTex[] textures)
		{
		}

		private void UpdatePivot()
		{
		}

		private void UpdateLookAt()
		{
		}

		private void ReconnectPanelIfNeeded(bool firstTime)
		{
		}

		private void UpdatePanelInfo()
		{
		}

		private void EnableAllHidden()
		{
		}

		private void DisableAllHidden()
		{
		}

		private void DestroyAllHidden(bool forceImmediate = false)
		{
		}

		protected virtual void Rebuild()
		{
		}

		protected int BuildBackgroundTextures(int depth)
		{
			return 0;
		}

		protected int BuildForegroundTextures(int depth)
		{
			return 0;
		}

		private int BuildTextures<T>(T[] textures, string prefix, int startDepth, ref List<MadSprite> sprites)
		{
			return 0;
		}

		protected int RebuildLabel(int depth)
		{
			return 0;
		}

		public Rect AnyBackgroundOrForegroundSpriteSize()
		{
			return (Rect)null;
		}

		protected void ApplyTransform(Component c)
		{
		}

		protected void ApplyTransform(GameObject go)
		{
		}

		protected void DestroyHidden(GameObject go, bool forceImmediate)
		{
		}

		protected T CreateHidden<T>(string name, [Optional] Transform parent) where T : Component
		{
			return null;
		}

		protected override bool IsVisible()
		{
			return false;
		}

		protected bool TextureValid(Texture2D tex, string atlasTex)
		{
			return false;
		}

		protected void SetTexture(MadSprite sprite, Texture2D tex, string atlasTex)
		{
		}

		protected bool AtlasTextureValid(string guid)
		{
			return false;
		}

		protected static MadSprite.PivotPoint Translate(Pivot pivot)
		{
			//IL_0003: Expected I4, but got O
			return (MadSprite.PivotPoint)null;
		}

		protected static Vector2 PivotOffset(Pivot pivot)
		{
			return (Vector2)null;
		}
	}
}
