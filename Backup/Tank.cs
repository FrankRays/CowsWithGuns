/*
 * Cows With Guns v 1.0 (for Visual C Sharp .Net 1.1)
 * Coded by: Keith Loughnane (18 - March - 03)
 */

using System;


namespace cowswithguns2003
{
	/// Tank is a class to contain variables and
	/// methods that relate to tank solids.
	public class Tank : Solid
	{
		public bool facingleft = true, active = false, firing = false,isCurrent = false;
		public int aim = 0,ratio,shellXVel,shellYVel;
		public Blast[] blasts = new Blast[6];
		public float power         =    2;
		public int damage          =   40;
		public int bombsLeft       =   -1;
		public int torchLeft       =   10;
		public int teleportsLeft   =    4;
		public int fireSheildsLeft =    3;
		public string name,currentWeapon = "bomb";
		public  Projectile    shell;
		public  Blast         boom;
		public Game          creatorGame;
		private Team          myTeam;

		public Tank(Game cg,Team t,string n,int initx, int inity)
		{
			name = n;
			creatorGame = cg;
			myTeam = t;
			x = initx;
			y = inity;
		}
		public override string ToString()
		{
			return health + ","+ x + "," + "y";
		}
		public void moveleft()
		{
			if((creator.myGameScreen.backGroundWithTanks.GetPixel(x-3,y-20) == creator.myGameScreen.skyColor))
				if(jumping == false)
				{
					facingleft = true;
					x-=3;
				}
		}
		public void moveright()
		{
			if((creator.myGameScreen.backGroundWithTanks.GetPixel(x+3,y-20) == creator.myGameScreen.skyColor))
				if(jumping == false)
				{
					facingleft = false;
					x+=3;
				}
		}
		public void jump()
		{
			if(jumping == false)
			{
				y -= 5;
				yvel = -20;
				if (facingleft == true)
				{
					xvel = -10;
				}
				else
				{
					xvel = 10;
				}
				jumping = true;
			}
		}
		public void aimUp()
		{
			if(aim <= 360)
				aim+=5;
			else
				aim = 1;
		}
		public void aimDown()
		{
			if(aim > 1)
				aim-=5;
			else
				aim = 360;
		}
		public void powerUp()
		{
			if(power <= 3f)
			{
				power = power + 0.5f;
			}
		}
		public void powerDown()
		{
			if(power >= .5f)
			{
				power = power - 0.5f;
			}
		}
		public void beamto(int toX, int toY)
		{
			if(firing == false)
			{
				x = toX;
				y = toY;
				creatorGame.nextTurn();
			}
			this.teleportsLeft--;
		}
		public string getTankDetails()
		{
			string info;
			info = " is left " + facingleft.ToString() + " is active " + active.ToString();
			info += " health " + health.ToString() + "X,Y " + x.ToString() + "," + y.ToString() + "\r\n";
			return info;
		}
		public void setCurrentWeapon(string weapon)
		{
			currentWeapon = weapon;
		}
		public void fire()
		{
			if(firing == false)
			{
				switch(currentWeapon)
				{
					case("bomb"):
					{
						fireBomb();
						
						break;
					}
					case("torch"):
					{
						useTorch();
						break;
					}
					case("beamer"):
					{
						System.Windows.Forms.MessageBox.Show("To Use The Beamer : \n 1) Select it from the weapon menu \n 2) CLICK were you want to go.");
						break;
					}
					case("shield"):
					{
						fireShield();
						break;
					}
					default:
					{
						System.Windows.Forms.MessageBox.Show("Invalid Weapon : " + currentWeapon);
						break;
					}
				}
			}
		}
		public void useTorch()
		{
			
			damage = creator.bombDamage;
			for(int b =blasts.Length -1; b >= 0; b--)
			{
				if(this.facingleft)
					blasts[b] = new Blast(this,x - (30*(b+3)),y-40,60,0);
				else
					blasts[b] = new Blast(this,x + (30*b+2),y-40,60,0);
			}

			stopTurn();
			this.bombsLeft--;
		}
		public void fireShield()
		{
			damage = creator.sheildDamage;
			blasts[0] = new Blast(this,x - 60,y-40,60,0);
			blasts[1] = new Blast(this,x,y-40,60,0);
			blasts[2] = new Blast(this,x-30,y-70,60,0);
			blasts[3] = new Blast(this,x-30,y,60,0);

			blasts[4] = new Blast(this,x - 120,y-40,60,0);
			blasts[5] = new Blast(this,x+60,y-40,60,0);
			stopTurn();
			fireSheildsLeft--;
		}
		public void fireBomb()
		{
			//this is called to fire a bomb
			ratio = aim/5;
			// This works out the ratio between y velosity and x velosity from the angle aim
			if(ratio <= 18 && ratio != 0)
			{
				shellYVel = (18 - ratio);
				shellXVel = (ratio);
			}
			else if(ratio >18 && ratio <= 36)
			{
				ratio -= 18;
				shellYVel = -(ratio);
				shellXVel = (18 - ratio );
			}
			else if(ratio >36 && ratio <= 54)
			{
				ratio -= 36;
				shellYVel = -(18 - ratio);
				shellXVel = -(ratio );
			}
			else if(ratio >54 && ratio <= 72)
			{
				ratio -= 54;
				shellYVel = (ratio);
				shellXVel = -(18 - ratio);
			}
			this.damage = creator.bombDamage;
			firing = true;
			shell = new Projectile(this,x,y-10,
				Convert.ToInt32(Convert.ToSingle(shellXVel) * power),
				Convert.ToInt32(Convert.ToSingle(shellYVel) * power));
			stopTurn();
		}
		public void stopTurn()
		{
			creatorGame.stopTimer();
			creatorGame.myGameScreen.fullRenderOn = true;
		}
		public void killShell()
		{
			//this is what happens when a shell explodes
			if(shell != null)
			{
				blasts[1] = new Blast(this,shell.x-40,shell.y-40,80,35);
				shell = null;
				creatorGame.myGameScreen.drawFrame();
				creatorGame.myGameScreen.resetExplotionLayer();
			}
		}
		public void nullifyAllExplotions()
		{
				for(int i = blasts.Length-1; i >= 0; i --)
				{
						blasts[i] = null;
				}
				creatorGame.nextTurn();
				creatorGame.startTimer();
				firing = false;
				creatorGame.myGameScreen.drawBGWT();
		}
		public void killBlast(Object b)
		{
			// this is called when a blast goes
			creatorGame.applyDamage(damage);
			b = null;
			nullifyAllExplotions();
    	}
		public override void die()
		{
			myTeam.removeTank(this);
		}
	}
}

