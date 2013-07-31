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
	/// Summary description for frmEndGame.
	/// </summary>
	public class frmEndGame : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label txtWinner;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblTank1;
		private System.Windows.Forms.Label lblTank2;
		private System.Windows.Forms.Label lblTank4;
		private System.Windows.Forms.Label lblTank3;
		private System.Windows.Forms.Button cmdDone;
		private frmGameStart creator;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.ProgressBar progressBar4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmEndGame(Team winner,frmGameStart f)
		{
			creator = f;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.txtWinner.Text ="the winner is " + winner.teamName;
			this.lblTank1.Text = winner.tanks[0].name;
			this.lblTank2.Text = winner.tanks[1].name;
			this.lblTank3.Text = winner.tanks[2].name;
			this.lblTank4.Text = winner.tanks[3].name;

			this.label1.Text = "remaining health : " + winner.tanks[0].health.ToString();
			this.label2.Text = "remaining health : " + winner.tanks[1].health.ToString();
			this.label3.Text = "remaining health : " + winner.tanks[2].health.ToString();
			this.label4.Text = "remaining health : " + winner.tanks[3].health.ToString();

			this.progressBar1.Value = winner.tanks[0].health;
			this.progressBar2.Value = winner.tanks[1].health;
			this.progressBar3.Value = winner.tanks[2].health;
			this.progressBar4.Value = winner.tanks[3].health;



			//horisontalBarGraph1 = new horisontalBarGraph();
			//horisontalBarGraph1.setByValue(winner.tanks[0].health);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmEndGame));
			this.txtWinner = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTank4 = new System.Windows.Forms.Label();
			this.lblTank3 = new System.Windows.Forms.Label();
			this.lblTank2 = new System.Windows.Forms.Label();
			this.lblTank1 = new System.Windows.Forms.Label();
			this.cmdDone = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtWinner
			// 
			this.txtWinner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtWinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtWinner.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtWinner.ForeColor = System.Drawing.Color.Blue;
			this.txtWinner.Location = new System.Drawing.Point(0, 0);
			this.txtWinner.Name = "txtWinner";
			this.txtWinner.Size = new System.Drawing.Size(640, 56);
			this.txtWinner.TabIndex = 0;
			this.txtWinner.Text = "The Winner Is";
			this.txtWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.progressBar4);
			this.groupBox1.Controls.Add(this.progressBar3);
			this.groupBox1.Controls.Add(this.progressBar2);
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblTank4);
			this.groupBox1.Controls.Add(this.lblTank3);
			this.groupBox1.Controls.Add(this.lblTank2);
			this.groupBox1.Controls.Add(this.lblTank1);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(520, 327);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "The Winning Team Was";
			// 
			// lblTank4
			// 
			this.lblTank4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTank4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTank4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTank4.Location = new System.Drawing.Point(48, 252);
			this.lblTank4.Name = "lblTank4";
			this.lblTank4.Size = new System.Drawing.Size(144, 23);
			this.lblTank4.TabIndex = 3;
			this.lblTank4.Text = "lblTank1";
			this.lblTank4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTank3
			// 
			this.lblTank3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTank3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTank3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTank3.Location = new System.Drawing.Point(48, 180);
			this.lblTank3.Name = "lblTank3";
			this.lblTank3.Size = new System.Drawing.Size(144, 23);
			this.lblTank3.TabIndex = 2;
			this.lblTank3.Text = "label2";
			this.lblTank3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTank2
			// 
			this.lblTank2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTank2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTank2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTank2.Location = new System.Drawing.Point(48, 108);
			this.lblTank2.Name = "lblTank2";
			this.lblTank2.Size = new System.Drawing.Size(144, 23);
			this.lblTank2.TabIndex = 1;
			this.lblTank2.Text = "lblTank1";
			this.lblTank2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTank1
			// 
			this.lblTank1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTank1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTank1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTank1.Location = new System.Drawing.Point(48, 36);
			this.lblTank1.Name = "lblTank1";
			this.lblTank1.Size = new System.Drawing.Size(144, 23);
			this.lblTank1.TabIndex = 0;
			this.lblTank1.Text = "lblTank1";
			this.lblTank1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdDone
			// 
			this.cmdDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdDone.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdDone.BackgroundImage")));
			this.cmdDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdDone.Location = new System.Drawing.Point(536, 367);
			this.cmdDone.Name = "cmdDone";
			this.cmdDone.Size = new System.Drawing.Size(96, 24);
			this.cmdDone.TabIndex = 9;
			this.cmdDone.Text = "Done";
			this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Location = new System.Drawing.Point(200, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.Location = new System.Drawing.Point(200, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(264, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.Location = new System.Drawing.Point(200, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(264, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.Location = new System.Drawing.Point(200, 252);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(264, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "label4";
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.progressBar1.Location = new System.Drawing.Point(44, 60);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(424, 32);
			this.progressBar1.TabIndex = 8;
			// 
			// progressBar2
			// 
			this.progressBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.progressBar2.Location = new System.Drawing.Point(44, 132);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(424, 32);
			this.progressBar2.TabIndex = 9;
			// 
			// progressBar3
			// 
			this.progressBar3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.progressBar3.Location = new System.Drawing.Point(44, 204);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(424, 32);
			this.progressBar3.TabIndex = 10;
			// 
			// progressBar4
			// 
			this.progressBar4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.progressBar4.Location = new System.Drawing.Point(44, 276);
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(424, 32);
			this.progressBar4.TabIndex = 11;
			// 
			// frmEndGame
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(640, 397);
			this.Controls.Add(this.cmdDone);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtWinner);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmEndGame";
			this.Text = "End Game";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmEndGame_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmEndGame_Load(object sender, System.EventArgs e)
		{
		
		}

		private void cmdDone_Click(object sender, System.EventArgs e)
		{
			this.Close();
			creator.Show();
		}

		private void horisontalBarGraph1_Load(object sender, System.EventArgs e)
		{
			
		}
	}
}
