/*
 * Cows With Guns v 1.0 (for Visual C Sharp .Net 1.1)
 * Coded by: Keith Loughnane (18 - March - 03)
 */
using System;
namespace cowswithguns2003
{
	/// <summary>
	/// Team is an object that contains tanks and those other stuff;
	/// </summary>
	public class Team
	{
		public Tank[] tanks =new Tank[4];
		public Tank currentTankObject;
		public string details = "";
		public string teamName;
		public int currentTank = 0,counter;
		public bool isDead = false;
		private bool ready = false;
		public gameClient myClient;
		public static int seed = Convert.ToInt32(System.DateTime.Now.Ticks % 11);
		private Random r;
		private Game   creator;

		public Team(Game c, string tn)
		{
			r = new Random(seed);
			seed = Convert.ToInt32(System.DateTime.Now.Millisecond);
			creator = c;	
			teamName = tn;
			tanks[0] = new Tank(creator,this,"tank1",r.Next(800),r.Next(200));//these should have random X,Y s
			tanks[1] = new Tank(creator,this,"tank2",r.Next(800),r.Next(200));
			tanks[2] = new Tank(creator,this,"tank3",r.Next(800),r.Next(200));
			tanks[3] = new Tank(creator,this,"tank4",r.Next(800),r.Next(200));
		}
		public Team(Game c,gameClient g)
		{
			// Network Version Of Team
			r = new Random(seed);
			seed = Convert.ToInt32(System.DateTime.Now.Millisecond);
			creator = c;
			myClient = g;
			teamName = myClient.name;
			tanks[0] = new Tank(creator,this,"tank1",r.Next(800),r.Next(200));//these should have random X,Y s
			tanks[1] = new Tank(creator,this,"tank2",r.Next(800),r.Next(200));
			tanks[2] = new Tank(creator,this,"tank3",r.Next(800),r.Next(200));
			tanks[3] = new Tank(creator,this,"tank4",r.Next(800),r.Next(200));
		}
		public void setCreator(Game g)
		{
			// Sets the creator of each tank
			this.creator = g;
			for(int x = tanks.Length-1; x >= 0; x--)
				tanks[x].creatorGame = g;
		}
		public void powerCurrentUp()
		{
			tanks[currentTank].powerUp();
			myClient.sendString("input,powerUp");
		}
		public void powerCurrentDown()
		{
			tanks[currentTank].powerDown();
			myClient.sendString("input,powerDown");
		}
		public void moveCurrentLeft()
		{
			tanks[currentTank].moveleft();
			myClient.sendString("input,moveLeft");
		}
		public void moveCurrentRight()
		{
			tanks[currentTank].moveright();
			myClient.sendString("input,moveRight");
		}
		public void jumpCurrent()
		{
			tanks[currentTank].jump();
			myClient.sendString("input,Jump");
		}
		public void fireCurrent()
		{
			tanks[currentTank].fire();
			myClient.sendString("input,fire");
		}
		public void aimUpCurrent()
		{
			tanks[currentTank].aimUp();
			myClient.sendString("input,aimUp");
		}
		public void aimDownCurrent()
		{
			tanks[currentTank].aimDown();
			myClient.sendString("input,aimDown");
		}
		public int getCurrentX()
		{
			return tanks[currentTank].x;
		}
		public int getCurrentY()
		{
			return tanks[currentTank].y;
		}
		public int getCurrentAim()
		{
			return tanks[currentTank].aim;
		}
/*		public bool isCurrentNull()
		{
			if(tanks[currentTank]==null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		*/
		public bool isCurrentAlive()
		{
			if(tanks[currentTank].isAlive == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public void checkIfDead()
		{
			this.isDead = true;
			for(int i = 3;i>=0;i--)
			{
				if(tanks[i].health >0)
				{
					isDead = false;
					break;
				}
			}
		}
		public void nextTurn()
		{
			ready = false;
			counter = 0;
			// Keep going 'till you find a live one
			while(ready == false)
			{
				//go onto the next one, if on the last one go to the first one
				if(currentTank < 3)
					{
						currentTank++;
					}
					else
					{
						currentTank = 0;
					}
				//if its health is greater than 0 its alive and your ready
				if(tanks[currentTank].health > 0 )
				{
					ready = true;
				}
				else
				{
					// other wise go onto the next one
					counter++;
					// might as well make sure the isAlive value is good.
					tanks[currentTank].isAlive = false;
					// if it reaches 4 the whole team must be dead.
					if(counter>=4)
					{
						isDead = true;
						break;
					}
				}

			}
			currentTankObject = this.tanks[currentTank];
		}
		public void setCurrentWeapon(string weapon)
		{
			tanks[currentTank].setCurrentWeapon(weapon);
		}
		public void removeTank(Tank t)
		{
			t.isAlive = false;
			if(t.isCurrent)
			creator.nextTurn();
		}
		public void beemTo(int x, int y)
		{
			tanks[currentTank].beamto(x,y);
		}		
	}
}

