using SA.Common.Animation;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using UnityEngine;

public static class SA_UnityExtensions
{
	private static readonly Regex _regex;

	public static void MoveTo(this GameObject go, Vector3 position, float time, EaseType easeType = EaseType.linear, [Optional] Action OnCompleteAction)
	{
	}

	public static void ScaleTo(this GameObject go, Vector3 scale, float time, EaseType easeType = EaseType.linear, [Optional] Action OnCompleteAction)
	{
	}

	public static Bounds GetRealBounds(this GameObject go)
	{
		return (Bounds)null;
	}

	public static Bounds GetRealBounds(this Component go)
	{
		return (Bounds)null;
	}

	public static Bounds GetRendererBounds(this GameObject go)
	{
		return (Bounds)null;
	}

	public static Vector3 GetVertex(this GameObject go, VertexX x, VertexY y, VertexZ z)
	{
		return (Vector3)null;
	}

	public static void Reset(this GameObject go)
	{
	}

	public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
	{
		return false;
	}

	public static void Reset(this Transform t)
	{
	}

	public static Bounds GetRendererBounds(this Transform t)
	{
		return (Bounds)null;
	}

	public static Vector3 GetVertex(this Transform t, VertexX x, VertexY y, VertexZ z)
	{
		return (Vector3)null;
	}

	public static Transform Clear(this Transform transform)
	{
		return null;
	}

	public static Vector3 GetVertex(this Bounds bounds, VertexX x, VertexY y, VertexZ z)
	{
		return (Vector3)null;
	}

	public static void SetAlpha(this Material material, float value)
	{
	}

	public static Sprite ToSprite(this Texture2D texture)
	{
		return null;
	}

	public static Texture2D Rotate(this Texture2D texture, float angle)
	{
		return null;
	}

	public static Vector3 Reset(this Vector3 vec)
	{
		return (Vector3)null;
	}

	public static Vector3 ResetXCoord(this Vector3 vec)
	{
		return (Vector3)null;
	}

	public static Vector3 ResetYCoord(this Vector3 vec)
	{
		return (Vector3)null;
	}

	public static Vector3 ResetZCoord(this Vector3 vec)
	{
		return (Vector3)null;
	}

	public static Vector3 Average(this Vector3[] f)
	{
		return (Vector3)null;
	}

	public static string GetLast(this string source, int count)
	{
		return "";
	}

	public static string GetFirst(this string source, int count)
	{
		return "";
	}

	public static void CopyToClipboard(this string source)
	{
	}

	public static Uri CovertToURI(this string source)
	{
		return null;
	}

	public static Dictionary<string, string> ParseQueryString(this Uri uri)
	{
		return null;
	}

	public static Bounds CalculateBounds(GameObject obj)
	{
		return (Bounds)null;
	}
}
