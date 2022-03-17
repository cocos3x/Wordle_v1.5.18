using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class GooglePlayEvents : Singleton<GooglePlayEvents>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<GooglePlayResult> _003C_003E9__9_0;

		internal void _003C_002Ector_003Eb__9_0(GooglePlayResult _003Cp0_003E)
		{
		}
	}

	public Action<GooglePlayResult> OnEventsLoaded;

	private List<GP_Event> _Events;

	public List<GP_Event> Events => null;

	private void Awake()
	{
	}

	public void LoadEvents()
	{
	}

	public void SumbitEvent(string eventId)
	{
	}

	public void SumbitEvent(string eventId, int count)
	{
	}

	private void OnGPEventsLoaded(string data)
	{
	}
}
