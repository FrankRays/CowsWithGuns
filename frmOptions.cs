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
	/// Summary description for frmOptions.
	/// </summary>
	public class frmOptions : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdHelp;
		private System.Windows.Forms.Panel pnlJoin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmOptions()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmOptions));
			this.cmdHelp = new System.Windows.Forms.Button();
			this.pnlJoin = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label19 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlJoin.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdHelp
			// 
			this.cmdHelp.BackColor = System.Drawing.Color.Lavender;
			this.cmdHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdHelp.BackgroundImage")));
			this.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdHelp.Location = new System.Drawing.Point(520, 8);
			this.cmdHelp.Name = "cmdHelp";
			this.cmdHelp.Size = new System.Drawing.Size(32, 24);
			this.cmdHelp.TabIndex = 13;
			this.cmdHelp.Text = "?";
			// 
			// pnlJoin
			// 
			this.pnlJoin.BackColor = System.Drawing.Color.Transparent;
			this.pnlJoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlJoin.Controls.Add(this.panel2);
			this.pnlJoin.Controls.Add(this.panel1);
			this.pnlJoin.Location = new System.Drawing.Point(8, 248);
			this.pnlJoin.Name = "pnlJoin";
			this.pnlJoin.Size = new System.Drawing.Size(728, 208);
			this.pnlJoin.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 24);
			this.button1.TabIndex = 11;
			this.button1.Text = "Back";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(544, 2);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(184, 8);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(216, 24);
			this.label19.TabIndex = 15;
			this.label19.Text = "Options";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(48, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 80);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Location = new System.Drawing.Point(560, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(32, 80);
			this.panel2.TabIndex = 1;
			// 
			// frmOptions
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(776, 518);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cmdHelp);
			this.Controls.Add(this.pnlJoin);
			this.Controls.Add(this.button1);
			this.Name = "frmOptions";
			this.Text = "Options";
			this.Load += new System.EventHandler(this.frmOptions_Load);
			this.pnlJoin.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmOptions_Load(object sender, System.EventArgs e)
		{
		
		}

		private void pnlCreate_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
	}
}
