/*
 * Cows With Guns v 1.0 (for Visual C Sharp .Net 1.1)
 * Coded by: Keith Loughnane (18 - March - 03)
 */
using System;

namespace cowswithguns2003
{
	/// <summary>
	/// a blast is the explotion that results from a projectile detonating.
	/// </summary>
	public class Blast
	{
		public int x,y,maxSize,size = -1,damage;
		public Tank fromTank;
		public bool isAtStart = true;

		public Blast(Tank t,int xpos,int ypos,int ms,int d)
		{
			isAtStart  = true;
			fromTank = t;
			x = xpos;
			y = ypos;
			maxSize = ms;
			size = maxSize;
			damage = d;
		}
		public virtual void started()
		{
			// Is Started is used so that the explotion is drawn on
			// the explotion layer only once
			isAtStart = false;
		}
		public virtual void blastDisapate()
		{
			/*
			 * Ever time this is call a little bit of the explotion goes away
			 */

			if(size > 0)
			{
				size -= 8;
				x += 4;
				y += 4;
			}
			else
			{
				//System.Windows.Forms.MessageBox.Show("explotion cleared");
				fromTank.killBlast(this);
			}
		}

	}
}
