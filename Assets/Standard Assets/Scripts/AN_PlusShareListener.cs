using SA.Common.Models;
using System;
using UnityEngine;

public class AN_PlusShareListener : MonoBehaviour
{
	public delegate void PlusShareCallback(Result result);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static PlusShareCallback _003C_003E9__4_0;

		internal void _003C_002Ector_003Eb__4_0(Result _003Cp0_003E)
		{
		}
	}

	private PlusShareCallback builderCallback;

	public void AttachBuilderCallback(PlusShareCallback callback)
	{
	}

	private void OnPlusShareCallback(string res)
	{
	}
}
