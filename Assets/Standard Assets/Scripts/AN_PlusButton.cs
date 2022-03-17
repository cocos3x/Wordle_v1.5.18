using System;
using UnityEngine;

public class AN_PlusButton
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__6_0;

		internal void _003C_002Ector_003Eb__6_0()
		{
		}
	}

	private int _ButtonId;

	private TextAnchor _anchor;

	private int _x;

	private int _y;

	private bool _IsShowed;

	public Action ButtonClicked;

	private static int _nextId;

	public int ButtonId => 0;

	public int x => 0;

	public int y => 0;

	public bool IsShowed => false;

	public TextAnchor anchor => (TextAnchor)null;

	public GoogleGravity gravity => (GoogleGravity)null;

	private static int nextId => 0;

	public AN_PlusButton(string url, AN_PlusBtnSize btnSize, AN_PlusBtnAnnotation annotation)
	{
	}

	public void SetGravity(TextAnchor btnAnchor)
	{
	}

	public void SetPosition(int btnX, int btnY)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Refresh()
	{
	}

	public void FireClickAction()
	{
	}
}
