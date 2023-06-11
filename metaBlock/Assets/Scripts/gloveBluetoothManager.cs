using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ArduinoBluetoothAPI;

public class gloveBluetoothManager : MonoBehaviour
{

	// Use this for initialization
	static BluetoothHelper bluetoothHelper;
	string deviceName = "PASTA";

	string received_message;
	static string send_message;
	static Boolean reconnect = false;

	// Start is called before the first frame update
	void Start()
	{

		try
		{
			BluetoothHelper.BLE = false;
			bluetoothHelper = BluetoothHelper.GetInstance(deviceName);
			bluetoothHelper.OnConnected += OnConnected;
			bluetoothHelper.OnConnectionFailed += OnConnectionFailed;
			bluetoothHelper.OnDataReceived += OnMessageReceived; //read the data
																 //	bluetoothHelper.OnScanEnded += OnScanEnded;

			bluetoothHelper.setTerminatorBasedStream("\n");

			if (!bluetoothHelper.ScanNearbyDevices())
			{
				//scan didnt start (on windows desktop (not UWP))
				//try to connect
				bluetoothHelper.Connect();//this will work only for bluetooth classic.
										  //scanning is mandatory before connecting for BLE.

			}
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);

		}

	}

	public static void sendData(string str)
	{
		//Debug.Log("sendfunc call");
		send_message = str;
		if (bluetoothHelper.isConnected())
		{
			bluetoothHelper.SendData(str);
		}
		else
		{
			reconnect = true;
			bluetoothHelper.Connect(); // tries to connect
		}

	}

	void OnMessageReceived()
	{
		received_message = bluetoothHelper.Read();
		//Debug.Log(received_message);
		if (received_message.Contains("G"))
		{
			Debug.Log("Grapping Block Motion");
		}

	}

	void OnConnected()
	{
		try
		{
			bluetoothHelper.StartListening();
			Debug.Log("glove Bluetooth Connected");

			if (reconnect == true)
			{
				bluetoothHelper.SendData(send_message);
				reconnect = false;
			}
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message);
		}



	}

	/*

	void OnGUI()
	{

		if (isDebugOn)
		{
			if (bluetoothHelper != null)
				bluetoothHelper.DrawGUI();
			else
				return;

			// Screen Debug
			GUIStyle myStyle = new GUIStyle();
			myStyle.fontSize = 18;
			myStyle.normal.textColor = Color.blue;
			GUI.Label(new Rect(10, 10, 1080, 1920), myLog, myStyle);
		}
	}

	*/

	void OnScanEnded(BluetoothHelper helper, LinkedList<BluetoothDevice> devices)
	{

		if (helper.isDevicePaired()) //we did found our device (with BLE) or we already paired the device (for Bluetooth Classic)
			helper.Connect();
		else
			helper.ScanNearbyDevices(); //we didn't
	}


	void OnConnectionFailed()
	{
		//Debug.Log("Connection Failed");
	}


	void OnDestroy()
	{
		if (bluetoothHelper != null)
			bluetoothHelper.Disconnect();
	}

	void OnApplicationQuit()
	{

		if (bluetoothHelper != null)
			bluetoothHelper.Disconnect();
	}

	/*

	// Screen Debug
	bool isDebugOn = true;
	string myLog;
	Queue myLogQueue = new Queue();

	void OnEnable()
	{
		Application.logMessageReceived += HandleLog;
	}
	void OnDisable()
	{
		Application.logMessageReceived -= HandleLog;
	}

	void HandleLog(string logString, string stackTrace, LogType type)
	{

		if (myLogQueue.Count > 4)
		{
			myLogQueue.Clear();
		}

		myLog = logString;
		//	string newString = "[" + type + "] : " + myLog + "\n";

		string newString = "# " + myLog + "\n";

		myLogQueue.Enqueue(newString);
		if (type == LogType.Exception)
		{
			newString = "\n" + stackTrace;
			myLogQueue.Enqueue(newString);
		}
		myLog = string.Empty;
		foreach (string mylog in myLogQueue)
		{
			myLog += mylog;
		}
	}

	*/
}

