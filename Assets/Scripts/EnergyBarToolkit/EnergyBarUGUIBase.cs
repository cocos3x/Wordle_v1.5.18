using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EnergyBarToolkit
{
	public abstract class EnergyBarUGUIBase : EnergyBarBase
	{
		[Serializable]
		public class SpriteTex : AbstractTex
		{
			public Sprite sprite;

			public Material material;

			public SpriteTex()
			{
			}

			public SpriteTex(Sprite sprite)
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		[Serializable]
		public class SpriteBind
		{
			public Image image;

			public int index;

			public SpriteBind(Image image, int index)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static MadTransform.Predicate<Transform> _003C_003E9__28_0;

			internal bool _003CRemoveCreatedChildren_003Eb__28_0(Transform c)
			{
				return false;
			}
		}

		public List<SpriteTex> spritesBackground;

		public List<SpriteTex> spritesForeground;

		public Text label;

		public bool labelInheritOpacity;

		public SpriteTex effectBurnSprite;

		public bool debugMode;

		[SerializeField]
		protected List<GameObject> createdChildren;

		[SerializeField]
		protected List<SpriteBind> backgroundBinds;

		[SerializeField]
		protected List<SpriteBind> foregroundBinds;

		protected RectTransform rectTransform;

		public override Rect DrawAreaRect => (Rect)null;

		public abstract void SetNativeSize();

		protected override void OnEnable()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateBackgroundForegroundColor()
		{
		}

		private void UpdateColor(List<SpriteBind> binds, List<SpriteTex> sprites)
		{
		}

		private void UpdateLabel()
		{
		}

		protected void BuildBackgroundImages()
		{
		}

		protected void BuildForegroundImages()
		{
		}

		private void BuildImagesFromList(List<SpriteTex> sprites, string prefix, ref List<SpriteBind> store)
		{
		}

		protected virtual Image.Type GetImageType()
		{
			//IL_0003: Expected I4, but got O
			return (Image.Type)null;
		}

		protected T CreateChild<T>(string childName) where T : Component
		{
			return null;
		}

		protected T CreateChild<T>(string childName, Transform parent) where T : Component
		{
			return null;
		}

		public static T CreateChild<T>(Transform parent, string name, bool disabled = false) where T : Component
		{
			return null;
		}

		private void SetAsLastGenerated(Transform child)
		{
		}

		private int NonGeneratedLowestIndex()
		{
			return 0;
		}

		private bool IsGenerated(Transform child)
		{
			return false;
		}

		protected void RemoveCreatedChildren()
		{
		}

		protected void SetSize(RectTransform rt, float w, float h)
		{
		}

		protected void SetSize(RectTransform rt, Vector2 size)
		{
		}

		protected override bool IsVisible()
		{
			return false;
		}

		protected void MoveLabelToTop()
		{
		}

		private void UpdateDebugMode(bool value)
		{
		}

		private void ApplyDebugMode(GameObject gameObject, bool enabled)
		{
		}
	}
}
