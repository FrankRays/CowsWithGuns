using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for gameClient.
	/// </summary>
	public class gameClient
	{
		public Socket mySocket;
		public string name;
		public bool isLocal;
		public bool isInit = false;
		public Tank[] tanks =new Tank[4];
		public StreamWriter clientWriter;
		public StreamReader clientReader;
		public Game containerGame;
		public string[] recived = new string[10];
		public Thread reciveThread;
		NetworkStream clientNetStream;
		//public gameServer myServer;

		public gameClient(Socket sk,string n)
		{
			mySocket = sk;
			clientNetStream = new NetworkStream(mySocket);
			clientWriter =new StreamWriter(clientNetStream);
			clientReader =new StreamReader(clientNetStream);
			reciveThread =new Thread(new ThreadStart(reciveString));
			reciveThread.Start();
			name = n;
			isLocal = false;
			isInit = true;
			//containerGame = g;
		}
		public gameClient(string n)
		{
			name = n;
			isLocal = true;
			isInit = true;
			//containerGame = g;
		}
		public string getDetail()
		{
			if(isLocal)
				return name +" (Local)";
			else
				return name +" ("+mySocket.LocalEndPoint.ToString() +")";
		}
		public void sendString(string sendMessage)
		{
			if(!isLocal)
			{
				clientWriter.WriteLine(sendMessage);
				clientWriter.Flush();
			}
		}
		public void reciveString()
		{
			while(true)
			{

				if(this.clientNetStream.DataAvailable)
					recived = clientReader.ReadLine().Split(',');
				if((recived[0] == "keyInput")||recived[0]!=null)
				{
					containerGame.input(recived[1]);
				}
			}

		}
	}
}
