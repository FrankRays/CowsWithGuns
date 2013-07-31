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
	/// Summary description for frmPlayerDisplay.
	/// </summary>
	public class frmPlayerDisplay : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblTeamName;
		private System.Windows.Forms.PictureBox pictureBox1;
		//private System.Windows.Forms.Label[] tankLabels = new System.Windows.Forms.Label[4];
		private System.Windows.Forms.Label label0;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private int[] healths = new int[4];
		private System.Windows.Forms.ProgressBar teamHealth;
		private int totalHealth;
		private Color trans;
		private Color selected;

		public frmPlayerDisplay()
		{
			trans = System.Drawing.Color.FromArgb(0,0,0,0);
			selected = System.Drawing.Color.FromArgb(150,0,0,255);


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPlayerDisplay));
			this.teamHealth = new System.Windows.Forms.ProgressBar();
			this.lblTeamName = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label0 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// teamHealth
			// 
			this.teamHealth.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.teamHealth.Location = new System.Drawing.Point(0, 134);
			this.teamHealth.Name = "teamHealth";
			this.teamHealth.Size = new System.Drawing.Size(437, 16);
			this.teamHealth.TabIndex = 0;
			// 
			// lblTeamName
			// 
			this.lblTeamName.BackColor = System.Drawing.Color.Transparent;
			this.lblTeamName.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTeamName.ForeColor = System.Drawing.Color.Blue;
			this.lblTeamName.Location = new System.Drawing.Point(0, 0);
			this.lblTeamName.Name = "lblTeamName";
			this.lblTeamName.Size = new System.Drawing.Size(440, 48);
			this.lblTeamName.TabIndex = 1;
			this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTeamName.Click += new System.EventHandler(this.lblTeamName_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(440, 8);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label0
			// 
			this.label0.BackColor = System.Drawing.Color.Transparent;
			this.label0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label0.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label0.Location = new System.Drawing.Point(8, 56);
			this.label0.Name = "label0";
			this.label0.Size = new System.Drawing.Size(208, 32);
			this.label0.TabIndex = 4;
			this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label0.Visible = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 32);
			this.label1.TabIndex = 5;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Visible = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(224, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(208, 32);
			this.label2.TabIndex = 6;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(224, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(208, 32);
			this.label3.TabIndex = 7;
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Visible = false;
			// 
			// frmPlayerDisplay
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(437, 150);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label0);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblTeamName);
			this.Controls.Add(this.teamHealth);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmPlayerDisplay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmPlayerDisplay";
			this.Load += new System.EventHandler(this.frmPlayerDisplay_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmPlayerDisplay_Load(object sender, System.EventArgs e)
		{
		}
		public void displayTank(int id,string name,int health)
		{
			if(id == 0)
			{
				label0.Text = name + "       "+ health;
			}
		
			if(id == 1)
			{
				label1.Text = name + "        "+ health;
			}
			if(id == 2)
			{
				label2.Text = name + "        "+ health;
			}
			if(id == 3)
			{
				label3.Text = name + "        "+ health;
			}
			healths[id] = health;
			totalHealth = 0;
			for(int i = 0;i <= 3;i++)
			{
				totalHealth += healths[i];
			}
			if(totalHealth >= 0)
				teamHealth.Value = totalHealth / 4;
			else
			{
				teamHealth.Value = 0;
				teamHealth.Enabled = false;
			}


		}
		public void setTeamName(string team)
		{
			lblTeamName.Text = team;
			this.enable();
		}
		public void enable()
		{
			label0.Visible = true;
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
		}
		public void setActive(int a)
		{
			label0.BackColor=trans;
			label1.BackColor=trans;
			label2.BackColor=trans;
			label3.BackColor=trans;
			
			if(a == 0)
				label0.BackColor=selected;
			else if(a == 1)
				label1.BackColor=selected;
			else if(a == 2)
				label2.BackColor=selected;
			else if(a == 3)
				label3.BackColor=selected;
				
		}

		private void lblTeamName_Click(object sender, System.EventArgs e)
		{
		
		}

	}
}
