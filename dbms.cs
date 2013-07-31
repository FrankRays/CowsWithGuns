using System;
using System.Xml;
using System.IO;
using System.Text;

namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for DBMS.
	/// </summary>
	public class DBMS
	{
		string[] teams = new string[10];
		string[] details = new string[10];
		System.IO.StreamReader into  = new StreamReader("C:\\Project\\Code\\cowswithguns2003\\teams\\teams.txt");
		public DBMS()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public void getTanks()
		{

			

		}

		public string[] getTeam(string teamName)
		{
			//stuff here to get details from a DB
			//and create a team object from it
			//Team currentTeam = new Team(,"test team");
			//return currentTeam;
			System.Windows.Forms.MessageBox.Show(into.Read().ToString());
			teams = into.Read().ToString().Split(';');
			for(int i = teams.Length -1;i>=0;i--)
			{
				details = teams[i].Split(',');
				if(details[0]==teamName)
					return details;
				//break;
			}
			details = new string[10];
			return details;


		}
	}
}
