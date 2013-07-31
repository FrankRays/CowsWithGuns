using System;

namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for Player.
	/// </summary>
	public class Player
	{
		string name;
		string location;
		int playerno;
		Team myTeam;

		public Player(string n,string l,int no,string t)
		{
			name = n;
			location = l;
			playerno = no;
			//myTeam = DBMS.getTeam("test team");

		}
	}
}
