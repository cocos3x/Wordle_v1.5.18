namespace UnityEngine.UI.Extensions
{
	public class TableLayoutGroup : LayoutGroup
	{
		public enum Corner
		{
			UpperLeft,
			UpperRight,
			LowerLeft,
			LowerRight
		}

		[SerializeField]
		protected Corner startCorner;

		[SerializeField]
		protected float[] columnWidths;

		[SerializeField]
		protected float minimumRowHeight;

		[SerializeField]
		protected bool flexibleRowHeight;

		[SerializeField]
		protected float columnSpacing;

		[SerializeField]
		protected float rowSpacing;

		private float[] preferredRowHeights;

		public Corner StartCorner
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (Corner)null;
			}
			set
			{
			}
		}

		public float[] ColumnWidths
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float MinimumRowHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool FlexibleRowHeight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float ColumnSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RowSpacing
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void CalculateLayoutInputHorizontal()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}
	}
}
