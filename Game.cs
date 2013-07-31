/*
 * Cows With Guns v 1.0 (for Visual C Sharp .Net 1.1)
 * Coded by: Keith Loughnane (18 - March - 03)
 */

using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace cowswithguns2003
{
	/* This class initialises, organisases and deligates to 
	 * the other class class in vaolved in the ctual playing of
	 * the game.
	 */
	public class Game
	{
//****************PUBLIC VARIABLES AND OBJECTS ***************************************							
		// this boolean propertie reflects if the weapon menu is shown or not
		public bool weaponsMenuShown = false;
		// how long a round lasts
		public const int roundTime     = 60;
		// how much damage each weapon uses
		public  int bombDamage    = 40;
		public  int sheildDamage  = 40;
		public  int torchDamage   = 20;
		// this integer propertie reflects which team has this turn
		public  int currentTeam   =  0;
		// This code declares the forms that make up the in game screen
		public frmWeaponsMenu   weaponsMenu;
		public frmGameScreen    myGameScreen;
		public frmGameTimer     myTimer;
		public frmTop           top = new frmTop();
		// This form is the mdi container that contains the other forms
		public frmGameContainer inGame;
		// Teams used in the game 
		public Team[]           gameTeams;
		// Object Representing the current Team
		public Team             currentTeamObject;
//****************PRIVATE VARIABLES AND OBJECTS ***************************************
		private int          deadTeamCounter         ;
		private bool         paused            = true;
		private string       tmpString;
		private frmGameStart startMenu;

//**************NETWORKS****************************************************
		private bool fireDone,iAmClient = false;
		private string output,serverInput;
		private System.IO.StreamWriter toServerWriter;
		private Server myServer;
//**************************************************************************
        System.Drawing.Bitmap currentWeaponImage = 
			new System.Drawing.Bitmap("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\bomb.bmp");

		public Game(frmGameStart s,Team[] t,string l)
		{
			// Start Menu The menu that Spawned this
			startMenu = s;
			// Game Teams The Teams that are playing this game
			gameTeams = t;
			// This initalises the formes neaded to producec the game screen
			weaponsMenu = new   frmWeaponsMenu(this);
			myTimer     = new   frmGameTimer(this);
			// This initalises the mdi container form for the game screen
			inGame      = new   frmGameContainer(this);
			//this initalises game level wich contains details on the level
			myGameScreen= new   frmGameScreen(this,l);			
			//this sets the mdiParent the forms composing the game screen 
			//to the inGame container form
			weaponsMenu.MdiParent  =      inGame;
			myGameScreen.MdiParent =      inGame;
			myTimer.MdiParent      =      inGame;
			top.MdiParent          =      inGame;
			//this tells the forms to show			
			myGameScreen.Show();
			myTimer.Show();
			inGame.Show();
			top.Show();
			// this sets up the displays needed to show details
			for(int teamOn = 0; teamOn <= gameTeams.Length-1; teamOn++)
			{
				inGame.displays[teamOn].setTeamName(gameTeams[teamOn].teamName);
				this.gameTeams[teamOn].setCreator(this);
			}
			//this gives the myGameScreen object focus
			myGameScreen.Activate();
			nextTurn();
			nextTurn();
//***************** ~~  NETWORKING ATTEMPT  ~~ ************************************************
			/*for(int t = this.gameTeams.Length-1;t >=0 ;t--)
			{
				if(!gameTeams[t].myClient.isLocal)
					myServers[t] = new gameServer(this,gameTeams[t].myClient.mySocket,t);
			}
			if(myServer == null)
			{
				this.iAmClient = false;
			}
			else
			{
				iAmClient = true;
				this.ServerNetStream = myServer.GetStream();
				this.toServerWriter = new StreamWriter(ServerNetStream);
				this.fromServerReader = new StreamReader(ServerNetStream);

			}*/
//*********************************************************************************************
			updateDisplay();
		}
//******************** ~~ This Contructor is only used for Networks ~~ ************************
		public Game(frmGameStart s,Team[] t,System.Net.Sockets.NetworkStream sns,string l)
		{
			/*//this is for a server or local game;
			//level = l;
			startMenu = s;
			for(int i = t.Length-1;i>=0;i--)
			{
				gameTeams[i] = t[i];
			}


			// This initalises the formes neaded to producec the game screen
			weaponsMenu = new frmWeaponsMenu(this);

			myTimer = new frmGameTimer(this);
			// This initalises the mdi container form for the game screen
			inGame = new frmGameContainer(this);
			//this initalises game level wich contains details on the level
			gameLevel = new Level();
			//this code initalises and populates the gameTeams array
			//which contains team objects
			//gameTeams = new Team[2];
			myGameScreen = new frmGameScreen(this,l);
			
			//this sets the mdiParent the forms composing the game screen 
			//to the inGame container form
			weaponsMenu.MdiParent = inGame;
			myGameScreen.MdiParent = inGame;
			myTimer.MdiParent = inGame;
			//this tells the forms to show			
			myGameScreen.Show();
			myTimer.Show();
			inGame.Show();
			for(int teamOn = 0; teamOn <= 1; teamOn++)
			{
				inGame.displays[teamOn].setTeamName(gameTeams[teamOn].teamName);
				this.gameTeams[teamOn].setCreator(this);
			}
			//this gives the myGameScreen object focus
			//myViewer.Show();
			top.MdiParent = inGame;
			top.Show();
			myGameScreen.Activate();
			nextTurn();
			nextTurn();
			*/
			/*for(int t = this.gameTeams.Length-1;t >=0 ;t--)
			{
				if(!gameTeams[t].myClient.isLocal)
					myServers[t] = new gameServer(this,gameTeams[t].myClient.mySocket,t);
			}
			*/
			/*if(myServer == null)
			{
				this.iAmClient = false;
			}
			else
			{
				iAmClient = true;
				this.ServerNetStream = myServer.GetStream();
				this.toServerWriter = new StreamWriter(ServerNetStream);
				this.fromServerReader = new StreamReader(ServerNetStream);

			}
			*/		
			updateDisplay();
			//initViewControls();
			myServer = new Server(sns,this); 
			startMenu = s;			
			gameTeams = t;
			//gameTeams[1] = gameTeam2;
			// This initalises the formes neaded to producec the game screen
			weaponsMenu = new frmWeaponsMenu(this);
			myTimer = new frmGameTimer(this);
			// This initalises the mdi container form for the game screen
			inGame = new frmGameContainer(this);
			//this initalises game level wich contains details on the level
			//gameLevel = new Level();
			//this code initalises and populates the gameTeams array
			//which contains team objects
			//gameTeams = new Team[2];
			myGameScreen = new frmGameScreen(this,l);			
			//this sets the mdiParent the forms composing the game screen 
			//to the inGame container form
			weaponsMenu.MdiParent = inGame;
			myGameScreen.MdiParent = inGame;
			myTimer.MdiParent = inGame;
			//this tells the forms to show
			inGame.Show();
			myGameScreen.Show();
			myTimer.Show();
			inGame.Show();
			for(int teamOn = 0; teamOn <= 1; teamOn++)
			{
				inGame.displays[teamOn].setTeamName(gameTeams[teamOn].teamName);
				this.gameTeams[teamOn].setCreator(this);
			}
			//this gives the myGameScreen object focus
			//myViewer.Show();
			top.MdiParent = inGame;
			top.Show();
			myGameScreen.Activate();
			nextTurn();
			nextTurn();
			//myThreadStart = new ThreadStart(this.serverComm);
			//System.IAsyncResult m = null;
			//m = myThreadStart.BeginInvoke(new AsyncCallback(caller),null);
			this.gameTeams = t;
			iAmClient = true;
			

		}
//********************** END OF NETWORK ATTEPT **************************************
		public void caller(System.IAsyncResult ar)
		{
		}
		public void ShowWeapons(int x, int y)
		{
			/* this shows or hides the weapons menu depending on wheater or
			 * not the weapon menu shown is true or false
			 */
			if( weaponsMenuShown == false )
			{
				//this changes displays the menu and changes the weapon menu value
				weaponsMenuShown = true;
				//weaponsMenu.updateValues();
				weaponsMenu.Show();
				//this sets the current position of the menu
				weaponsMenu.Left = x; 
				weaponsMenu.Top = y;  	
			}
			else
			{
				//this changes displays the menu and changes the weapon menu value
				weaponsMenu.Hide();
				weaponsMenuShown = false;
			}			
		}
		public void setCurrentWeapon(String weapon)
		{
			/* 
			 * This method sets the current wepaon in the current tank
			 * as well as changing the weapon image
			 */			 
			gameTeams[currentTeam].setCurrentWeapon(weapon);
			switch(weapon)
			{
				case("bomb"):
				{
					currentWeaponImage = new System.Drawing.Bitmap("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\bomb.bmp");
					break;
				}
				case("shield"):
				{
					currentWeaponImage = new System.Drawing.Bitmap("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\sheild.bmp");
					break;
				}
				case("torch"):
				{
					currentWeaponImage = new System.Drawing.Bitmap("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\torch.bmp");
					break;
				}
				case("beamer"):
				{
					currentWeaponImage = new System.Drawing.Bitmap("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\beamer.bmp");
					break;
				}					
			}
		}
		public System.Drawing.Bitmap getCurrentWeaponImage()
		{
			// This gets the current weapon image
			return currentWeaponImage;
		}
		public void stopTimer()
		{
			/* This stops the timer so that the turn will not
			 * end untill it is supposed to. */			
			myTimer.clock.Enabled = false;
		}
		public void startTimer()
		{
			// This Starts The timer again
			myTimer.clock.Enabled = true;
		}
		public void beemCurrentTo(int x,int y)
		{
			// this is used to teleport a tank to a location.
			gameTeams[currentTeam].beemTo(x,y);
		}

		public void input(string i)
		{
			if(this.currentTeamObject.myClient.isLocal)
				// This method handles the keyboard input, usualy from frmGameScreen
				switch(i)
				{
					case( "100"):
					case("37"):
					{
						/* if key 100 is presses (4 on the numpad) call the moveCurrentLeft
						 * in the current team, which in turn will call a method in the current
						 * tank for that team */
						
						gameTeams[currentTeam].moveCurrentLeft();
						if(iAmClient == true)
						{
							sendToServer("left_left");

						}
						break;
					}
					case("102"):
					case("39"):
					{
						/* if key 102 is presses (6 on the numpad) call the moveCurrentRight
						 * in the current team, which in turn will call a method in the current
						 * tank for that team */
						
						gameTeams[currentTeam].moveCurrentRight();
						if(iAmClient == true)
						{
							sendToServer("left_right");
						}
						break;
					}
					case("13"):
					{
						/* if key 13 is presses (enter on the numpad) call the jumpCurrent in 
						 * the current team, which in turn will call a method in the current
						 * tank for that team */
						
						gameTeams[currentTeam].jumpCurrent();
						if(iAmClient == true)
						{
							sendToServer("jump");
						}
						break;
					}
					case("104"):
					case("38"):
					{
						/* if key 104 is presses (8 on the numpad) call the aimUpCurrent in 
						 * the current team, which in turn will call a method in the current
						 * tank for that team */
						
						gameTeams[currentTeam].aimUpCurrent();
						if(iAmClient == true)
						{
							sendToServer("aim_up");
						}
						break;
					}
					case("98"):
					case("40"):
					{
						/* if key 98 is presses (2 on the numpad) call the aimUpCurrent in 
						 * the current team, which in turn will call a method in the current
						 * tank for that team */
						
						gameTeams[currentTeam].aimDownCurrent();
						if(iAmClient == true)
						{
							sendToServer("aim_down");
						}
						break;
					}
					case("32"):
					{
						/* if key 13 is presses (enter on the numpad) call the jumpCurrent in 
						 * the current team, which in turn will call a method in the current
						 * tank for that team */
						
						gameTeams[currentTeam].fireCurrent();
						if(iAmClient == true)
						{
							sendToServer("fire");
						}
						break;
					}
					case("19"):
					case("80"):
					{
						//pause
						paused = !paused;
						myGameScreen.tmrPhysics.Enabled = paused;
						myGameScreen.tmrFrame.Enabled = paused;
						myTimer.clock.Enabled = paused;
						if(paused==false)
						{
							top.display("PAUSED");
						}
						else
							top.reset();
						
						break;
					}
					case("33"):
					{
						gameTeams[currentTeam].powerCurrentUp();
						if(iAmClient == true)
						{
							sendToServer("power_up");
						}
						break;
					}
					case("34"):
					{
						gameTeams[currentTeam].powerCurrentDown();
						if(iAmClient == true)
						{
							sendToServer("power_down");
						}
						break;
					}
				}
		
		}
		public void nextTurn()
		{
			/* This calls nextTurn in the current team and increments the 
			 * the current team, so that it is the next teams turn and a 
			 * different tank will be contraoled when this team has a go
			 * again*/

//**********************  UNLOAD LAST TURN  *******************************************
			//Reset beemMode so that if the last player was trying to beem
			 // You will not be beemed now*/
			myGameScreen.beemModeOn = false;
			// Reset the turn time
			myTimer.time = roundTime;
			/* This method makes the player display screen to reflect the current turn
			 * in this instance it is making it display no active player since one one
			 * on THIS TEAM has a turn. */
        	inGame.displays[currentTeam].setActive(5);
			//This makes the tank not current
			gameTeams[currentTeam].tanks[gameTeams[currentTeam].currentTank].isCurrent = false;
			// Call nextTurn in the current team. this will make the current team go onto its next tank.
			gameTeams[currentTeam].nextTurn();
			// Test to see if the game is over		
			isGameOver();
//***********************  LOAD THIS TURN  **********************************************
			/* This will go onto the next team untill it finds one that is alive. note without the above
			 * Line this could go into an infinate loop*/
			do
			{
				// go onto the next team unless it's at the last one in that case go back to the first
				if(currentTeam < gameTeams.Length-1)
					currentTeam++;
				else
					currentTeam = 0;
			}
			while(gameTeams[currentTeam].isDead);
			// This sets the current tank on the current team to be active so it can have its go.
			gameTeams[currentTeam].tanks[gameTeams[currentTeam].currentTank].isCurrent = true;
			// This makes the displays reflect the current turn.
			inGame.displays[currentTeam].setActive(gameTeams[currentTeam].currentTank);
			// Start the timer again.
			startTimer();
			// This sets up a currentTeamObject to make it easier to access (i wish i had done this earlier)
			currentTeamObject = gameTeams[currentTeam];
			// Set the current weapon so the image changes when the turn changes
			this.setCurrentWeapon(gameTeams[currentTeam].tanks[gameTeams[currentTeam].currentTank].currentWeapon);
//**************** END OF TURN CHANGE ********************************************************
		}
		public int getCurrentTankX()
		{
			return gameTeams[currentTeam].getCurrentX();
		}
		public int getCurrentTankY()
		{
			return gameTeams[currentTeam].getCurrentY();
		}
		public int getCurrentTankAim()
		{
			return gameTeams[currentTeam].getCurrentAim();
		}
		public bool isCurrentAlive()
		{
			//tests to see if the tank with the turn is alive
			return gameTeams[currentTeam].isCurrentAlive();
		}
		public void kill(Solid s)
		{
			/* 
			 * If the tank that has just died has the turn then go on to the next turn.
			 */
			if(s == gameTeams[currentTeam].tanks[gameTeams[currentTeam].currentTank])
				nextTurn();
		}
		public void updateDisplay()
		{
			/* This method updates the health of each tank in the team display screens
			 * 
			 */
			for(int teamOn = 0; teamOn < this.gameTeams.Length; teamOn++)
			{
				for(int tankOn = 0; tankOn <= 3; tankOn++)
				{
					inGame.displays[teamOn].displayTank(tankOn,gameTeams[teamOn].tanks[tankOn].name,gameTeams[teamOn].tanks[tankOn].health);
				}
			}
		}
		public void sendToServer(string i)
		{
			// This does not work yet
			this.myServer.sendString("input,"+i);
		}
		public void serverComm()
		{
			while(true)
			{

				if(serverInput == "get_input")
				{
					toServerWriter.WriteLine(output);
					toServerWriter.Flush();					    
				}
			}
		}
		public bool isSettled()
		{
			/* this loops through all teams and tanks test to see
			 * if all the tanks that do not currently have a turn
			 * are settled ie. not moving. this is only called during
			 * explotion to see if it can return to just rendering
			 * the current tank. all the same it will be cleaned up
			 * so that it uses a method in team instead of testing 
			 * directly.
			 */
			for(int teamOn = 0; teamOn <= this.gameTeams.Length-1; teamOn++)
			{
				for(int tankOn = 0; tankOn <= 3; tankOn++) 
				{
					if((gameTeams[teamOn].tanks[tankOn].isCurrent == false)&&gameTeams[teamOn].tanks[tankOn].isAlive==true)
					{
						if(!(((gameTeams[teamOn].tanks[tankOn].xvel == 0)&&(gameTeams[teamOn].tanks[tankOn].yvel == 0))))
						{
							return false;
						}
					}
				}
			}
			// if any of the tanks are active it should not make it this far.
			return true;
		}
		public void ApplyPhysics()
		{
			/* This Method calls the apply physics in in tanks and other
			 * solids so that they will react to the laws of physics
			 */ 
		
			for(int teamNow = gameTeams.Length -1; teamNow >= 0; teamNow--)
			{
				//this loop goes through all teams
				for(int tankNow = 0; tankNow <= 3; tankNow++) 
				{
					//This loops through each tank in the current team
					if(gameTeams[teamNow].tanks[tankNow] != null)
					{
						//this line calls ApplyPhysics for each tank
						gameTeams[teamNow].tanks[tankNow].ApplyPhysics(this);
						if(gameTeams[teamNow].tanks[tankNow].shell != null)
						{
							//if a projectile (shell) exists apply physics to it
							gameTeams[teamNow].tanks[tankNow].shell.ApplyPhysics(this);
						}
						for(int b = 5; b >= 0 ;b--)
						{
							if(gameTeams[teamNow].tanks[tankNow].blasts[b] != null)
							{
								//if a blast exists make it Disapate
								gameTeams[teamNow].tanks[tankNow].blasts[b].blastDisapate();
							}
						}
					}					
				}
			}
		}		
		public void applyDamage(int d)
		{
			/* This method calls the applyDamage Method on each Living
			 * Tank in the blast Radius
			 */
			for(int teamOn = 0; teamOn <= this.gameTeams.Length -1; teamOn++)
			{
				// this loops through each team
				for(int tankOn = 0; tankOn <= 3; tankOn++) 
				{
					// this loops through each tank in each team
					if((gameTeams[teamOn].tanks[tankOn].isAlive == true)
						&&(myGameScreen.explotionLayer.GetPixel(gameTeams[teamOn].tanks[tankOn].x,
						gameTeams[teamOn].tanks[tankOn].y)== myGameScreen.fireColor))
					{
							/*
						     * but what is does is test to see if the current tank is alive and in the blast radius
							 * if it is it calls apply damage.
							 */
						gameTeams[teamOn].tanks[tankOn].applyDamage(d);
					}
				}

			}
			updateDisplay();
		}
		public void isGameOver()
		{
			/* This tests to see if the game has ended. if it has it
			 * calls endGame with the parameter of the winning team
			 */
			deadTeamCounter = 0; //this is used to count the number of dead teams
			Team winner = new Team(this,"Error");
			/* Although it does not make much sence initalising the above tank here
			 * if it CANNOT be passed to endgame, but it will not compile otherwise
			 */
			for(int t = gameTeams.Length -1;t >= 0;t--)
			{
				//this loops through all the teams
				gameTeams[t].checkIfDead();
				if(gameTeams[t].isDead)
				{
					//this test if the current team is dead if so add one to the counter
					deadTeamCounter ++;
				}
				else
				{
					//set winner to the current alive tank
					winner = gameTeams[t];
				}
			}
			// if all but one of the Teams are dead call end game with the winner
			if(deadTeamCounter >= gameTeams.Length - 1)
				endGame(winner);
		}
		public void endGame(Team winnerName)
		{
			// this is called if somone wins.

			// this closes the varius windows
			myGameScreen.Close();
			myTimer.Close();
			top.Close();
			/* for some reason mdiContainers don't close so you have to
			 * make it not an mdiContainer
			 */
			inGame.IsMdiContainer = false;
			inGame.Close();
			/* from here the closing process is handed over to startMenu,
			 * startMenu contains this object
			 */
			startMenu.endGame(winnerName);
		}
		//******************************************************************************************************************
		//                             THE FOLLOWING IS ANOTHER ATTEMPT AT NETWORK SUPPORT
		//******************************************************************************************************************
		public void netInput(string r)
		{
			switch(/*this.netString[this.currentTeam]*/ r)
			{
				case("moveLeft"):
				{
					gameTeams[currentTeam].moveCurrentLeft();
					fireDone = true;
					break;
				}
				case("moveRight"):
				{
					gameTeams[currentTeam].moveCurrentRight();
					fireDone = true;
					break;
				}
				case("jump"):
				{
					gameTeams[currentTeam].jumpCurrent();
					fireDone = true;
					break;
				}
				case("aimUp"):
				{
					gameTeams[currentTeam].aimUpCurrent();
					fireDone = true;
					break;
				}
				case("aimDown"):
				{
					gameTeams[currentTeam].aimDownCurrent();
					fireDone = true;
					break;
				}
				case("fire"):
				{
					gameTeams[currentTeam].fireCurrent();
					fireDone = true;
					break;
				}
				case("pause"):
				{
					//pause
					paused = !paused;
					myGameScreen.tmrPhysics.Enabled = paused;
					myGameScreen.tmrFrame.Enabled = paused;
					myTimer.clock.Enabled = paused;
					if(paused==false)
					{
						top.display("PAUSED");
					}
					else
						top.reset();
					fireDone = true;
					break;
				}
				case("powerUp"):
				{
					gameTeams[currentTeam].powerCurrentUp();
					fireDone = true;
					break;
				}
				case("powerDown"):
				{
					gameTeams[currentTeam].powerCurrentDown();
					fireDone = true;
					break;
				}
			}
		}
		public void getNetInput()
		{
			while(true)
			{
				if(!currentTeamObject.myClient.isLocal)
				{
					NetworkStream networkStream = new NetworkStream(this.currentTeamObject.myClient.mySocket);

					StreamWriter streamWriter = new StreamWriter(networkStream);
					StreamReader streamReader = new StreamReader(networkStream);
					streamWriter.WriteLine("get_input");
					streamWriter.Flush();
					//System.Windows.Forms.MessageBox.Show("reading line");
					tmpString = streamReader.ReadLine();
					//System.Windows.Forms.MessageBox.Show("Getting Input");
					if((tmpString != "")&& (!currentTeamObject.myClient.isLocal))
					{
						fireDone = false;
						//System.Windows.Forms.MessageBox.Show("recieved input : "+ tmpString);
						while(fireDone == false)
							this.netInput(tmpString);
					}
				}
			}
		}
	}
}


