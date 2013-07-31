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
	/// Summary description for frmTop.
	/// </summary>
	public class frmTop : System.Windows.Forms.Form
	{
		private System.Windows.Forms.LinkLabel lnkMenu;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTop()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTop));
			this.lnkMenu = new System.Windows.Forms.LinkLabel();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lnkMenu
			// 
			this.lnkMenu.BackColor = System.Drawing.Color.Transparent;
			this.lnkMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lnkMenu.Location = new System.Drawing.Point(0, 134);
			this.lnkMenu.Name = "lnkMenu";
			this.lnkMenu.Size = new System.Drawing.Size(150, 16);
			this.lnkMenu.TabIndex = 1;
			this.lnkMenu.TabStop = true;
			this.lnkMenu.Text = "Menu";
			this.lnkMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lnkMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMenu_LinkClicked);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDisplay.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblDisplay.Location = new System.Drawing.Point(0, 0);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(150, 136);
			this.lblDisplay.TabIndex = 2;
			this.lblDisplay.Text = "CWG";
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTop
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(150, 150);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.lnkMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(437, 0);
			this.Name = "frmTop";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmTop";
			this.ResumeLayout(false);

		}
		#endregion

		private void lnkMenu_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			frmInGameMenu menu = new frmInGameMenu();
			menu.MdiParent = this.MdiParent;
			menu.Show();
		}
		public void display(string message)
		{
			lblDisplay.Text = message.ToString();
		}
		public void reset()
		{
			lblDisplay.Text = "CWG";
		}
	}

}
