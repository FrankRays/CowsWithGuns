using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for Form4.
	/// </summary>
	public class frmLoadScreen : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblLoad1;
		private System.Windows.Forms.Label lblLoad2;
		private System.Windows.Forms.Label lblLoad3;
		private System.Windows.Forms.Label lblLoad4;
		private System.Windows.Forms.Label lblLoad5;
		private System.Windows.Forms.Label lblLoad6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLoadScreen()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLoadScreen));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblLoad1 = new System.Windows.Forms.Label();
			this.lblLoad2 = new System.Windows.Forms.Label();
			this.lblLoad3 = new System.Windows.Forms.Label();
			this.lblLoad4 = new System.Windows.Forms.Label();
			this.lblLoad5 = new System.Windows.Forms.Label();
			this.lblLoad6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(8, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(464, 232);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblLoad1
			// 
			this.lblLoad1.BackColor = System.Drawing.Color.Black;
			this.lblLoad1.ForeColor = System.Drawing.Color.Lime;
			this.lblLoad1.Location = new System.Drawing.Point(16, 32);
			this.lblLoad1.Name = "lblLoad1";
			this.lblLoad1.Size = new System.Drawing.Size(280, 16);
			this.lblLoad1.TabIndex = 1;
			// 
			// lblLoad2
			// 
			this.lblLoad2.BackColor = System.Drawing.Color.Black;
			this.lblLoad2.ForeColor = System.Drawing.Color.Lime;
			this.lblLoad2.Location = new System.Drawing.Point(16, 56);
			this.lblLoad2.Name = "lblLoad2";
			this.lblLoad2.Size = new System.Drawing.Size(280, 16);
			this.lblLoad2.TabIndex = 2;
			// 
			// lblLoad3
			// 
			this.lblLoad3.BackColor = System.Drawing.Color.Black;
			this.lblLoad3.ForeColor = System.Drawing.Color.Lime;
			this.lblLoad3.Location = new System.Drawing.Point(16, 80);
			this.lblLoad3.Name = "lblLoad3";
			this.lblLoad3.Size = new System.Drawing.Size(280, 16);
			this.lblLoad3.TabIndex = 3;
			// 
			// lblLoad4
			// 
			this.lblLoad4.BackColor = System.Drawing.Color.Black;
			this.lblLoad4.ForeColor = System.Drawing.Color.Lime;
			this.lblLoad4.Location = new System.Drawing.Point(16, 104);
			this.lblLoad4.Name = "lblLoad4";
			this.lblLoad4.Size = new System.Drawing.Size(280, 16);
			this.lblLoad4.TabIndex = 4;
			// 
			// lblLoad5
			// 
			this.lblLoad5.BackColor = System.Drawing.Color.Black;
			this.lblLoad5.ForeColor = System.Drawing.Color.Lime;
			this.lblLoad5.Location = new System.Drawing.Point(16, 128);
			this.lblLoad5.Name = "lblLoad5";
			this.lblLoad5.Size = new System.Drawing.Size(280, 16);
			this.lblLoad5.TabIndex = 5;
			// 
			// lblLoad6
			// 
			this.lblLoad6.BackColor = System.Drawing.Color.Black;
			this.lblLoad6.ForeColor = System.Drawing.Color.Lime;
			this.lblLoad6.Location = new System.Drawing.Point(16, 152);
			this.lblLoad6.Name = "lblLoad6";
			this.lblLoad6.Size = new System.Drawing.Size(280, 16);
			this.lblLoad6.TabIndex = 6;
			// 
			// frmLoadScreen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(480, 266);
			this.Controls.Add(this.lblLoad6);
			this.Controls.Add(this.lblLoad5);
			this.Controls.Add(this.lblLoad4);
			this.Controls.Add(this.lblLoad3);
			this.Controls.Add(this.lblLoad2);
			this.Controls.Add(this.lblLoad1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmLoadScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loading Game";
			this.Load += new System.EventHandler(this.frmLoadScreen_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmLoadScreen_Load(object sender, System.EventArgs e)
		{

			//Load Terane
			lblLoad1.Text = "Loading Stuff";
			//Load Teams
			lblLoad2.Text = "Loading Stuff";
			//Load other Things
			lblLoad3.Text = "Loading Stuff";
			lblLoad4.Text = "Loading Stuff";
			lblLoad5.Text = "Loading Stuff";
			lblLoad6.Text = "Loading Stuff";
			this.Hide();
			frmIngame gameScreen = new frmIngame();

			gameScreen.Show();


		}
	}
}
