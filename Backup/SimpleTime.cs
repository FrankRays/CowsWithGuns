/*
 * Cows With Guns v 1.0 (for Visual C Sharp .Net 1.1)
 * Coded by: Keith Loughnane (18 - March - 03)
 */

using System;

namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for SimpleTime.
	/// </summary>
	public class SimpleTime
	{
		public int second = 0;
		public int minute = 0;
		public SimpleTime()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public void addSecond()
		{
			second ++;
			if(second >= 60)
			{
				second = 0;
				minute++;
			}

		}

	}
}
