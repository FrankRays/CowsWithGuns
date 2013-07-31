using System;

namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for Projectile.
	/// </summary>
	public class Projectile : Solid
	{
		Tank fromTank;
		public Projectile(Tank t, int fromX,int fromY,int initXvel,int initYvel)
		{
			fromTank = t;
			x = fromX;
			y = fromY;
			xvel = initXvel;
			yvel = initYvel;
			//
			// TODO: Add constructor logic here
			//
		}

		public override void groundColide() // this should over write groundColide in solid
		{
			detonate();

		}
		public void detonate()
		{
			fromTank.killShell();
		}
		public override void die()
		{
			detonate();
		}

		
	}
}
