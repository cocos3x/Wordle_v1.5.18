using SA.Common.Models;
using SA.Common.Pattern;
using System;
using System.Collections.Generic;

public class iCloudManager : Singleton<iCloudManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		internal void _003C_002Ecctor_003Eb__32_0(Result _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__32_1(iCloudData _003Cp0_003E)
		{
		}

		internal void _003C_002Ecctor_003Eb__32_2(List<iCloudData> _003Cp0_003E)
		{
		}
	}

	private Dictionary<string, List<Action<iCloudData>>> s_requestDataCallbacks;

	public static event Action<Result> OnCloudInitAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<iCloudData> OnCloudDataReceivedAction
	{
		add
		{
		}
		remove
		{
		}
	}

	public static event Action<List<iCloudData>> OnStoreDidChangeExternally
	{
		add
		{
		}
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void setString(string key, string val)
	{
	}

	public void SetString(string key, string val)
	{
	}

	public void setFloat(string key, float val)
	{
	}

	public void SetFloat(string key, float val)
	{
	}

	public void setData(string key, byte[] val)
	{
	}

	public void SetData(string key, byte[] val)
	{
	}

	public void SetObject(string key, object val)
	{
	}

	public void SetInt(string key, int val)
	{
	}

	public void SetLong(string key, long val)
	{
	}

	public void SetUlong(string key, ulong val)
	{
	}

	public void SetArray(string key, List<object> val)
	{
	}

	public void SetDictionary(string key, Dictionary<object, object> val)
	{
	}

	public void requestDataForKey(string key)
	{
	}

	public void RequestDataForKey(string key)
	{
	}

	public void RequestDataForKey(string key, Action<iCloudData> callback)
	{
	}

	private void OnCloudInit()
	{
	}

	private void OnCloudInitFail()
	{
	}

	private void OnCloudDataChanged(string data)
	{
	}

	private void OnCloudData(string array)
	{
	}

	private void OnCloudDataEmpty(string array)
	{
	}
}
