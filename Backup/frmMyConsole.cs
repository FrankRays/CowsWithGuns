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
	/// Summary description for frmMyConsole.
	/// </summary>
	public class frmMyConsole : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdOk;
		private System.Windows.Forms.RichTextBox rtbConsole;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMyConsole()
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
			this.cmdOk = new System.Windows.Forms.Button();
			this.rtbConsole = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// cmdOk
			// 
			this.cmdOk.Location = new System.Drawing.Point(112, 288);
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Size = new System.Drawing.Size(224, 24);
			this.cmdOk.TabIndex = 0;
			this.cmdOk.Text = "Ok, go away";
			// 
			// rtbConsole
			// 
			this.rtbConsole.Location = new System.Drawing.Point(8, 8);
			this.rtbConsole.Name = "rtbConsole";
			this.rtbConsole.Size = new System.Drawing.Size(408, 272);
			this.rtbConsole.TabIndex = 1;
			this.rtbConsole.Text = "";
			// 
			// frmMyConsole
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 318);
			this.Controls.Add(this.rtbConsole);
			this.Controls.Add(this.cmdOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmMyConsole";
			this.Text = "Console";
			this.Load += new System.EventHandler(this.frmMyConsole_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmMyConsole_Load(object sender, System.EventArgs e)
		{
		
		}

		public void addError(string err)
		{
			rtbConsole.Text += err;
			

		}
	}
}
