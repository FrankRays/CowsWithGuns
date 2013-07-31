/*
 * Cows With Guns v 1.0 (for Visual C Sharp .Net 1.1)
 * Coded by: Keith Loughnane (18 - March - 03)
 */
using System;

namespace cowswithguns2003
{
	/// <summary>
	/// Solid is a class that represents anything on the field that has weight
	/// and can have momentom.
	/// </summary>
	public class Solid
	{
		public int x; // this is the x position of the solid
		public int y; // this is the y position of the solid
		public int xvel; // this is the solids velosity in the x direction
		public int yvel;
		public int health = 100;
		public bool jumping = false,alter = false,isAlive = true;
		public Game creator;

		public Solid()
		{
			xvel = 0;
			yvel = 0;
		}

		public Solid(int initx, int inity)
		{
			x = initx;
			y = inity;
			xvel = 0;
			yvel = 0;
		}
		public Solid(int initx, int inity, int initxvel, int inityvel)
		{
			x = initx;
			y = inity;
			xvel = initxvel;
			yvel = inityvel;
		}
		public void ApplyPhysics(Game c)
		{
			creator = c;
			if(isAlive == true)
			{
				
			




				//try
				//{
				if(y > 6)
				{
				

					if((creator.myGameScreen.backGroundWithTanks.GetPixel(x,y) != creator.myGameScreen.skyColor)&&(creator.myGameScreen.backGround.GetPixel(x,y-5) == creator.myGameScreen.skyColor))
					{
						groundColide();
						stop();
					}
					else if((creator.myGameScreen.backGround.GetPixel(x,y) != creator.myGameScreen.skyColor)||(creator.myGameScreen.backGround.GetPixel(x,y-5) != creator.myGameScreen.skyColor))
					{
						// this is used if a solid has hit the ground
						y -= 4;
						groundColide();
						stop();

					}

					else //(((creator.myGameScreen.backGround.GetPixel(x-5,y) == creator.myGameScreen.skyColor)||(creator.myGameScreen.backGround.GetPixel(x+5,y) == creator.myGameScreen.skyColor)))
					{
						yvel += 2;

					}
				}
				else
				{
					yvel += 2;
				}
				
				//if((creator.myGameScreen.backGround.GetPixel(x+xvel,y+yvel) != creator.myGameScreen.skyColor))
				//{
				
				//}	

				//this stops solids going off the edge



				if(x+xvel <= 5)
				{
					//die();
					x=1017;
					//x= 20;
				}
				else if(x+xvel >= 1017)
				{
					//die();
					x=5;
					//x-=20;
				}
				if(y+yvel <= 30||y <=30)
				{
					//die();
					//y= 30;
				}
				else if((y+yvel >= 430)||y >= 430 )
				{
					//y=415;
					//die();
					//y = 400;
					applyDamage(100);
					groundColide();


				}
			 /*
				if(y >0&&x >0)
				{
					if((creator.myGameScreen.backGround.GetPixel(x+3,y-20) == creator.myGameScreen.skyColor)&&(creator.myGameScreen.backGround.GetPixel(x-3,y-20) == creator.myGameScreen.skyColor))
					{
						x+=(xvel/2);
					}
					else
					{
						stop();
						groundColide();

					}
				}
				else
				{
				*/
					x+=(xvel/2);
				//}

				y+=(yvel/2);

			}
			
			//catch(Exception e)
			//{
				//die(this);
				//creator.nextTurn();

			//}

		}
		public virtual void groundColide()
		{

		}
		public virtual void die()
		{	
			isAlive = false;
			creator.kill(this);


		}
		public void applyDamage(int d)
		{
			//System.Windows.Forms.MessageBox.Show("damage = " + d);
			health = health - d;
			if(health <= 0 )
			{
				die();
			}
			creator.updateDisplay();
			//yvel = -20;

		}
		public void stop()
		{
			yvel = 0;
			xvel = 0;
			jumping = false;
		}

	}

}
