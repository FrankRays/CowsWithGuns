using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for horisontalBarGraph.
	/// </summary>
	public class horisontalBarGraph : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Graphics g;
		private Bitmap b;
		private int percentage;
		public Color drawColor = Color.Blue;
		private Brush myBrush;

		public horisontalBarGraph()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			b = new Bitmap(this.Width,this.Height);
			g = Graphics.FromImage(b);
			myBrush = new SolidBrush(drawColor);


		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// horisontalBarGraph
			// 
			this.Name = "horisontalBarGraph";
			this.Size = new System.Drawing.Size(392, 32);
			this.Load += new System.EventHandler(this.horisontalBarGraph_Load);

		}
		#endregion

		private void horisontalBarGraph_Load(object sender, System.EventArgs e)
		{
		
		}
		private void redraw()
		{
			g.FillRectangle(this.myBrush,0,0,(this.Width/100)*percentage,this.Height);
			this.BackgroundImage = b;
			
		}
		public void setPercentage(int p)
		{
			this.percentage = p;
			redraw();
		}
		public void setByValue(int number, int outOf)
		{
			this.percentage = (outOf / number) * 100;
			redraw();
		}
	}
}
