using SA.Common.Models;
using SA.Fitness;
using System.Collections.Generic;
using UnityEngine;

public class GoogleFitExample : AndroidNativeExampleBase
{
	public GameObject avatar;

	public Texture2D pieIcon;

	public DefaultPreviewButton connectButton;

	public DefaultPreviewButton scoreSubmit;

	public SA_Label playerLabel;

	public DefaultPreviewButton[] ConnectionDependedntButtons;

	public SA_Label a_id;

	public SA_Label a_name;

	public SA_Label a_descr;

	public SA_Label a_type;

	public SA_Label a_state;

	public SA_Label a_steps;

	public SA_Label a_total;

	public SA_Label b_id;

	public SA_Label b_name;

	public SA_Label b_all_time;

	private List<DataSource> dataSources;

	private const string SESSION_ID = "9a4104ae-3e43-stepcounter";

	private void Start()
	{
	}

	private void UpdateButtons()
	{
	}

	private void ConncetButtonPress()
	{
	}

	private void requestSensors()
	{
	}

	private void registerSensorsListeners()
	{
	}

	private void listSubscriptions()
	{
	}

	private void subscribe()
	{
	}

	private void unsubscribe()
	{
	}

	public void readSession()
	{
	}

	public void insertSession()
	{
	}

	public void startSession()
	{
	}

	public void stopSession()
	{
	}

	public void readData()
	{
	}

	public void readDailyTotal()
	{
	}

	public void insertData()
	{
	}

	public void updateData()
	{
	}

	public void deleteData()
	{
	}

	private void Request_OnReadHistoryFinished(ReadHistoryResult result)
	{
	}

	private void Request_OnReadDailyTotalRequestFinished(ReadDailyTotalResult result)
	{
	}

	private void Request_OnSessionReadFinished(ReadSessionResult result)
	{
	}

	private void SA_Fitness_Connection_Instance_OnConnectionFinished(ConnectionResult result)
	{
	}

	private void Request_OnRequestFinished(SensorRequestResult result)
	{
	}

	private void Listener_OnRegisterSuccess(int id)
	{
	}

	private void Listener_OnRegisterFail(int id)
	{
	}

	private void Listener_OnDataPointReceived(int id, DataPoint dataPoint)
	{
	}

	private void Request_OnRequestFinished1(SubscriptionsRequestResult result)
	{
	}

	private void Request_OnSubscribeFinished(Result result)
	{
	}

	private void Request_OnUnsubscribeFinished(Result result)
	{
	}

	private void Request_OnSessionStarted(Result result)
	{
	}

	private void Request_OnSessionStopped(StopSessionResult result)
	{
	}
}
