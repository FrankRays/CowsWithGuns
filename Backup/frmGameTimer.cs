/*
 * Cows With Guns v 1.0 (for Visual C Sharp .Net 1.1)
 * Coded by: Keith Loughnane (18 - March - 03)
 */

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for frmGameTimer.
	/// </summary>
	public class frmGameTimer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Timer clock;
		private System.ComponentModel.IContainer components;
		public int time = 60;
		private Game creator;
		private System.Windows.Forms.Label lblTotalTime;
		public SimpleTime timey = new SimpleTime();

		public frmGameTimer(Game c)
		{
			creator = c;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmGameTimer));
			this.lblTime = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.clock = new System.Windows.Forms.Timer(this.components);
			this.lblTotalTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTime
			// 
			this.lblTime.BackColor = System.Drawing.Color.Black;
			this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTime.ForeColor = System.Drawing.Color.Gold;
			this.lblTime.Location = new System.Drawing.Point(8, 16);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(136, 88);
			this.lblTime.TabIndex = 0;
			this.lblTime.Text = "60";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Time Remaining";
			// 
			// clock
			// 
			this.clock.Enabled = true;
			this.clock.Interval = 1000;
			this.clock.Tick += new System.EventHandler(this.clock_Tick);
			// 
			// lblTotalTime
			// 
			this.lblTotalTime.BackColor = System.Drawing.Color.Transparent;
			this.lblTotalTime.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTotalTime.Location = new System.Drawing.Point(8, 112);
			this.lblTotalTime.Name = "lblTotalTime";
			this.lblTotalTime.Size = new System.Drawing.Size(136, 24);
			this.lblTotalTime.TabIndex = 2;
			this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTotalTime.Click += new System.EventHandler(this.label2_Click);
			// 
			// frmGameTimer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(150, 144);
			this.Controls.Add(this.lblTotalTime);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(437, 618);
			this.Name = "frmGameTimer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmGameTimer";
			this.Load += new System.EventHandler(this.frmGameTimer_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmGameTimer_Load(object sender, System.EventArgs e)
		{
		
		}

		private void clock_Tick(object sender, System.EventArgs e)
		{
			time--;
			lblTime.Text = time.ToString();
			if(time == 0)
			{
				creator.nextTurn();

			}

			//creator.myGameScreen.messageTick();

			timey.addSecond();
			if(timey.minute > 0)
				if(timey.second >=10)
					lblTotalTime.Text = timey.minute.ToString() + " : " + timey.second.ToString();
				else
					lblTotalTime.Text = timey.minute.ToString() + " : 0" + timey.second.ToString();
			else
				lblTotalTime.Text = timey.second.ToString();
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void totalTime_Tick(object sender, System.EventArgs e)
		{



		}
	}
}
