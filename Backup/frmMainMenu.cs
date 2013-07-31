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
	/// Summary description for frmMainMenu.
	/// </summary>
	public class frmMainMenu : System.Windows.Forms.Form
	{
		frmSplashScreen splash = new frmSplashScreen();
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Button cmdTeams;
		private System.Windows.Forms.Button cmdPlayGame;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button cmdLevel;
		private System.Windows.Forms.LinkLabel button1;
		private System.Windows.Forms.LinkLabel button2;
		private System.ComponentModel.IContainer components;
		private int R,G,B;
		private Color backColor = Color.FromArgb(255,255,255);
		

		public frmMainMenu()
		{
			//this.Visible = false;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			R = 255;
			G = 255;
			B = 255;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			//frmSplashScreen mySplash = new frmSplashScreen(this);
			//mySplash.Show();

		}
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMainMenu());
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMainMenu));
			this.cmdExit = new System.Windows.Forms.Button();
			this.cmdTeams = new System.Windows.Forms.Button();
			this.cmdLevel = new System.Windows.Forms.Button();
			this.cmdPlayGame = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.LinkLabel();
			this.button2 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// cmdExit
			// 
			this.cmdExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmdExit.BackColor = System.Drawing.Color.Lavender;
			this.cmdExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExit.BackgroundImage")));
			this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdExit.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.cmdExit.Location = new System.Drawing.Point(256, 400);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(120, 100);
			this.cmdExit.TabIndex = 1;
			this.cmdExit.Text = "Exit";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// cmdTeams
			// 
			this.cmdTeams.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cmdTeams.BackColor = System.Drawing.Color.Lavender;
			this.cmdTeams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdTeams.BackgroundImage")));
			this.cmdTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdTeams.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdTeams.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.cmdTeams.Location = new System.Drawing.Point(496, 200);
			this.cmdTeams.Name = "cmdTeams";
			this.cmdTeams.Size = new System.Drawing.Size(120, 100);
			this.cmdTeams.TabIndex = 2;
			this.cmdTeams.Text = "Teams";
			this.cmdTeams.Click += new System.EventHandler(this.cmdTeams_Click);
			// 
			// cmdLevel
			// 
			this.cmdLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmdLevel.BackColor = System.Drawing.Color.Lavender;
			this.cmdLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLevel.Image = ((System.Drawing.Image)(resources.GetObject("cmdLevel.Image")));
			this.cmdLevel.Location = new System.Drawing.Point(8, 208);
			this.cmdLevel.Name = "cmdLevel";
			this.cmdLevel.Size = new System.Drawing.Size(120, 100);
			this.cmdLevel.TabIndex = 3;
			this.cmdLevel.Text = "LevelEditor";
			this.cmdLevel.Click += new System.EventHandler(this.button4_Click);
			// 
			// cmdPlayGame
			// 
			this.cmdPlayGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cmdPlayGame.BackColor = System.Drawing.Color.Lavender;
			this.cmdPlayGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPlayGame.BackgroundImage")));
			this.cmdPlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdPlayGame.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdPlayGame.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.cmdPlayGame.Image = ((System.Drawing.Image)(resources.GetObject("cmdPlayGame.Image")));
			this.cmdPlayGame.Location = new System.Drawing.Point(240, 0);
			this.cmdPlayGame.Name = "cmdPlayGame";
			this.cmdPlayGame.Size = new System.Drawing.Size(120, 100);
			this.cmdPlayGame.TabIndex = 0;
			this.cmdPlayGame.Text = "Play Game";
			this.cmdPlayGame.Click += new System.EventHandler(this.cmdPlayGame_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(152, 96);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(312, 304);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(384, 480);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(232, 16);
			this.button1.TabIndex = 5;
			this.button1.TabStop = true;
			this.button1.Text = "Credits";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(8, 480);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(240, 16);
			this.button2.TabIndex = 6;
			this.button2.TabStop = true;
			this.button2.Text = "User Manual";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// frmMainMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(624, 502);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cmdLevel);
			this.Controls.Add(this.cmdTeams);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.cmdPlayGame);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMainMenu";
			this.Text = "frmMainMenu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMainMenu_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdPlayGame_Click(object sender, System.EventArgs e)
		{
			frmGameStart preGameScreen = new frmGameStart();
			this.Hide();
			preGameScreen.Show();
		}

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();


		}

		private void cmdTeams_Click(object sender, System.EventArgs e)
		{
			frmTeams teamsScreen = new frmTeams();
			this.Hide();
			teamsScreen.Show();

		}

		private void frmMainMenu_Load(object sender, System.EventArgs e)
		{

			//splash.Show();
			//this.tmrSplashShow.Enabled = true;

		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			frmLevelEditor myEditor = new frmLevelEditor();
			this.Hide();
			myEditor.Show();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			//this.splash.Close();
			//this.tmrSplashShow.Enabled = false;
			R--;
			G--;
			B--;
			backColor = Color.FromArgb(R,G,B);
			this.backColor = backColor;
			this.Invalidate();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			frmCredits credits = new frmCredits(this);
			credits.Show();
			this.Hide();
		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			frmManual manual = new frmManual(this);
			manual.Show();
			this.Hide();
		
		}
	}
}
