using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for gameClient.
	/// </summary>
	public class Server
	{
		public Socket mySocket;




		public StreamWriter clientWriter;
		public StreamReader clientReader;
		public Game containerGame;
		public string[] recived = new string[10];
		public Thread reciveThread;
		NetworkStream serverNetStream;
		//public gameServer myServer;

		public Server(NetworkStream sk,Game g)
		{
			containerGame = g;
			//mySocket = sk;
			serverNetStream = sk; //new NetworkStream(mySocket);
			clientWriter =new StreamWriter(serverNetStream);
			clientReader =new StreamReader(serverNetStream);
			reciveThread =new Thread(new ThreadStart(reciveString));
			reciveThread.Start();

		}
		public void sendString(string sendMessage)
		{
			clientWriter.WriteLine(sendMessage);
			clientWriter.Flush();
		}
		public void reciveString()
		{
			while(true)
			{

				if(this.serverNetStream.DataAvailable)
					recived = clientReader.ReadLine().Split(',');
				if(recived[0] == "keyInput")
				{
					containerGame.input(recived[1]);
				}
			}

		}
	}
}
