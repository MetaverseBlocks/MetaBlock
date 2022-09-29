using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using ArduinoBluetoothAPI;

public class hapticBluetoothManager : MonoBehaviour
{

	static BluetoothHelper bluetoothHelper;
	string deviceName = "PASTTA";

	static string send_message;
	string received_message;
	static Boolean reconnect = false;

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

	// Update is called once per frame
	void Update()
	{

	}


	public static void sendData(string str)
	{
		Debug.Log("sendData func call");
		send_message = str;
		if (bluetoothHelper.isConnected())
		{
			bluetoothHelper.SendData(str);
		}
		else
		{
			Debug.Log("연결 안 되어있음");
			reconnect = true;
			bluetoothHelper.Connect(); // tries to connect
		}

	}


	void OnConnected()
	{
		try
		{
			bluetoothHelper.StartListening();
			Debug.Log("HAPTIC Bluetooth Connected");

			if (reconnect == true)
			{
				Debug.Log(send_message+"reconnect후 send");
				bluetoothHelper.SendData(send_message);
				reconnect = false;
			}
		}
		catch (Exception ex)
		{
			Debug.Log("haptic Bluetooth ConnectedFail");
			Debug.Log(ex.Message);
		}

	}


	void OnScanEnded(BluetoothHelper helper, LinkedList<BluetoothDevice> devices)
	{

		if (helper.isDevicePaired()) //we did found our device (with BLE) or we already paired the device (for Bluetooth Classic)
			helper.Connect();
		else
			helper.ScanNearbyDevices(); //we didn't
	}


	void OnConnectionFailed()
	{
		Debug.Log("haptic Bluetooth ConnectedFail");
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

	void OnMessageReceived()
	{
		received_message = bluetoothHelper.Read();
		Debug.Log(received_message);

	}
}
