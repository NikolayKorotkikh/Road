using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

/// <summary>
/// Synchronous network between Unity and Python
/// </summary>
public class Network : MonoBehaviour {

    private TcpClient _tcpClient;
    private NetworkStream _networkStream;
    private StreamWriter _streamWriter;
    private StreamReader _streamReader;
    private bool _runningThread;
    private bool _socketReady;
    private Thread thread;

    public string host = "127.0.0.1";
    public int port = 9999;
    public int sleepTime = 3000;

    void Start () {
        SetupSocket();
    }

    void Update () {
    }

    private void SetupSocket() {
        try {
            _tcpClient = new TcpClient(host, port);
            _networkStream = _tcpClient.GetStream();
            _streamWriter = new StreamWriter(_networkStream);
            _streamReader = new StreamReader(_networkStream);
            _socketReady = true;

            thread = new Thread(new ThreadStart(Send));
            _runningThread = true;
            thread.IsBackground = true;
            thread.Start();
        } catch (Exception ex) {
            Debug.Log("Socket startup error: " + ex.Message);
        }
    }

    private void Send() {
        try {
            while (_runningThread) {
                if (!_socketReady)
                    return;
                Environment env = new Environment();
                string message = JsonUtility.ToJson(env);
                _streamWriter.Write(message);
                _streamWriter.Flush();
                Thread.Sleep(sleepTime);
            }
        } catch (Exception ex) {
            _streamWriter.Close();
            Debug.Log("Write to socker error: " + ex.Message);
        }
    }

    private string Read() {
        try {
            if (!_socketReady)
                return string.Empty;
            if (_networkStream.DataAvailable)
                return _streamReader.ReadLine();
        } catch (Exception ex) {
            _streamReader.Close();
            Debug.Log("Read from socker error: " + ex.Message);
        }
        return string.Empty;
    }

    private void CloseSocket() {
        if (_socketReady)
            return;
        _networkStream.Close();
        _tcpClient.Close();
        _socketReady = false;
    }

    void OnApplicationQuit()
    {
        _runningThread = false;
        try
        {
            _tcpClient.Close();
            _streamWriter.Close();
            _streamReader.Close();
            thread.Abort();
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}

[Serializable]
public class Environment {
    public byte countCars;
    public byte contPeople;
}
