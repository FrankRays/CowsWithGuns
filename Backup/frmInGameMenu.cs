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
	/// Summary description for frmInGameMenu.
	/// </summary>
	public class frmInGameMenu : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Button cmdX;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmInGameMenu()
		{
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmInGameMenu));
			this.cmdExit = new System.Windows.Forms.Button();
			this.cmdX = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdExit
			// 
			this.cmdExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExit.BackgroundImage")));
			this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdExit.Location = new System.Drawing.Point(8, 152);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(128, 24);
			this.cmdExit.TabIndex = 0;
			this.cmdExit.Text = "Exit";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// cmdX
			// 
			this.cmdX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdX.BackgroundImage")));
			this.cmdX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdX.Location = new System.Drawing.Point(112, 8);
			this.cmdX.Name = "cmdX";
			this.cmdX.Size = new System.Drawing.Size(24, 24);
			this.cmdX.TabIndex = 1;
			this.cmdX.Text = "X";
			this.cmdX.Click += new System.EventHandler(this.cmdX_Click);
			// 
			// frmInGameMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(146, 182);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.cmdX);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(438, 148);
			this.Name = "frmInGameMenu";
			this.Opacity = 0.2;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmInGameMenu";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.White;
			this.Load += new System.EventHandler(this.frmInGameMenu_Load);
			this.Deactivate += new System.EventHandler(this.frmInGameMenu_Deactivate);
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void cmdX_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void frmInGameMenu_Deactivate(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmInGameMenu_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{

		}
	}
}
