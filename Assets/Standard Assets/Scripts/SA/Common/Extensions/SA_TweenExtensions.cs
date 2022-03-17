using SA.Common.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SA.Common.Extensions
{
	public static class SA_TweenExtensions
	{
		public static void MoveTo(this GameObject go, Vector3 position, float time, EaseType easeType = EaseType.linear, [Optional] Action OnCompleteAction)
		{
		}

		public static void ScaleTo(this GameObject go, Vector3 scale, float time, EaseType easeType = EaseType.linear, [Optional] Action OnCompleteAction)
		{
		}
	}
}
