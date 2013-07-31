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
	/// Summary description for frmTeams.
	/// </summary>
	public class frmTeams : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lstTeams;
		private System.Windows.Forms.Button cmdAddTeam;
		private System.Windows.Forms.GroupBox grpTeamDetails;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTeamName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtChar1Name;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtChar1Rank;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button cmdBack;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.LinkLabel lnkPasswd;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private DBMS myDBMS = new DBMS();
		private System.ComponentModel.Container components = null;
		private string[] details;

		public frmTeams()
		{
			//
			// Required for Windows Form Designer support
			//
			//this.Opacity = 0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTeams));
			this.lstTeams = new System.Windows.Forms.ListBox();
			this.cmdAddTeam = new System.Windows.Forms.Button();
			this.grpTeamDetails = new System.Windows.Forms.GroupBox();
			this.lnkPasswd = new System.Windows.Forms.LinkLabel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.txtChar1Rank = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtChar1Name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTeamName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdBack = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.grpTeamDetails.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstTeams
			// 
			this.lstTeams.BackColor = System.Drawing.Color.Cyan;
			this.lstTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lstTeams.ForeColor = System.Drawing.Color.Black;
			this.lstTeams.HorizontalScrollbar = true;
			this.lstTeams.Items.AddRange(new object[] {
														  "Keiths Team",
														  "tims Team",
														  "Jims Team"});
			this.lstTeams.Location = new System.Drawing.Point(8, 24);
			this.lstTeams.Name = "lstTeams";
			this.lstTeams.Size = new System.Drawing.Size(208, 470);
			this.lstTeams.TabIndex = 0;
			// 
			// cmdAddTeam
			// 
			this.cmdAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdAddTeam.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddTeam.Image")));
			this.cmdAddTeam.Location = new System.Drawing.Point(8, 496);
			this.cmdAddTeam.Name = "cmdAddTeam";
			this.cmdAddTeam.Size = new System.Drawing.Size(208, 24);
			this.cmdAddTeam.TabIndex = 1;
			this.cmdAddTeam.Text = "Add Team";
			// 
			// grpTeamDetails
			// 
			this.grpTeamDetails.BackColor = System.Drawing.Color.Transparent;
			this.grpTeamDetails.Controls.Add(this.lnkPasswd);
			this.grpTeamDetails.Controls.Add(this.panel5);
			this.grpTeamDetails.Controls.Add(this.panel4);
			this.grpTeamDetails.Controls.Add(this.panel3);
			this.grpTeamDetails.Controls.Add(this.panel2);
			this.grpTeamDetails.Controls.Add(this.panel1);
			this.grpTeamDetails.Controls.Add(this.label2);
			this.grpTeamDetails.Controls.Add(this.txtTeamName);
			this.grpTeamDetails.Location = new System.Drawing.Point(224, 16);
			this.grpTeamDetails.Name = "grpTeamDetails";
			this.grpTeamDetails.Size = new System.Drawing.Size(504, 480);
			this.grpTeamDetails.TabIndex = 2;
			this.grpTeamDetails.TabStop = false;
			this.grpTeamDetails.Text = "Team details";
			this.grpTeamDetails.Enter += new System.EventHandler(this.grpTeamDetails_Enter);
			// 
			// lnkPasswd
			// 
			this.lnkPasswd.Location = new System.Drawing.Point(272, 48);
			this.lnkPasswd.Name = "lnkPasswd";
			this.lnkPasswd.Size = new System.Drawing.Size(96, 16);
			this.lnkPasswd.TabIndex = 8;
			this.lnkPasswd.TabStop = true;
			this.lnkPasswd.Text = "Password Protect";
			this.lnkPasswd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPasswd_LinkClicked);
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.pictureBox10);
			this.panel5.Controls.Add(this.textBox7);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Controls.Add(this.textBox8);
			this.panel5.Controls.Add(this.label12);
			this.panel5.Controls.Add(this.pictureBox5);
			this.panel5.Location = new System.Drawing.Point(16, 400);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(464, 72);
			this.panel5.TabIndex = 7;
			// 
			// pictureBox10
			// 
			this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(400, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(64, 72);
			this.pictureBox10.TabIndex = 7;
			this.pictureBox10.TabStop = false;
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.Color.DarkGray;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox7.Enabled = false;
			this.textBox7.Location = new System.Drawing.Point(152, 40);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(232, 20);
			this.textBox7.TabIndex = 6;
			this.textBox7.Text = "";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(80, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 16);
			this.label11.TabIndex = 5;
			this.label11.Text = "Rank";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.Lavender;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Location = new System.Drawing.Point(152, 8);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(232, 20);
			this.textBox8.TabIndex = 4;
			this.textBox8.Text = "";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(80, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 16);
			this.label12.TabIndex = 3;
			this.label12.Text = "Name";
			// 
			// pictureBox5
			// 
			this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(0, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(64, 72);
			this.pictureBox5.TabIndex = 2;
			this.pictureBox5.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.pictureBox9);
			this.panel4.Controls.Add(this.textBox5);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.textBox6);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.pictureBox4);
			this.panel4.Location = new System.Drawing.Point(16, 320);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(464, 72);
			this.panel4.TabIndex = 6;
			// 
			// pictureBox9
			// 
			this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(400, 0);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(64, 72);
			this.pictureBox9.TabIndex = 7;
			this.pictureBox9.TabStop = false;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.DarkGray;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Enabled = false;
			this.textBox5.Location = new System.Drawing.Point(152, 40);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(232, 20);
			this.textBox5.TabIndex = 6;
			this.textBox5.Text = "";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(80, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 16);
			this.label9.TabIndex = 5;
			this.label9.Text = "Rank";
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.Lavender;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Location = new System.Drawing.Point(152, 8);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(232, 20);
			this.textBox6.TabIndex = 4;
			this.textBox6.Text = "";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(80, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 16);
			this.label10.TabIndex = 3;
			this.label10.Text = "Name";
			// 
			// pictureBox4
			// 
			this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(64, 72);
			this.pictureBox4.TabIndex = 2;
			this.pictureBox4.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.pictureBox8);
			this.panel3.Controls.Add(this.textBox3);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.textBox4);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Location = new System.Drawing.Point(16, 240);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(464, 72);
			this.panel3.TabIndex = 5;
			// 
			// pictureBox8
			// 
			this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(400, -1);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(64, 72);
			this.pictureBox8.TabIndex = 7;
			this.pictureBox8.TabStop = false;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.DarkGray;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(152, 40);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(232, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(80, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 16);
			this.label7.TabIndex = 5;
			this.label7.Text = "Rank";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.Lavender;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Location = new System.Drawing.Point(152, 8);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(232, 20);
			this.textBox4.TabIndex = 4;
			this.textBox4.Text = "";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(80, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.TabIndex = 3;
			this.label8.Text = "Name";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(64, 72);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Location = new System.Drawing.Point(16, 160);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(464, 72);
			this.panel2.TabIndex = 4;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(400, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(64, 72);
			this.pictureBox7.TabIndex = 7;
			this.pictureBox7.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.DarkGray;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(152, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(232, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(80, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Rank";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Lavender;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(152, 8);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(232, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(80, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Name";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(64, 72);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.txtChar1Rank);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtChar1Name);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(16, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(464, 72);
			this.panel1.TabIndex = 3;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(400, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(64, 72);
			this.pictureBox6.TabIndex = 7;
			this.pictureBox6.TabStop = false;
			// 
			// txtChar1Rank
			// 
			this.txtChar1Rank.BackColor = System.Drawing.Color.DarkGray;
			this.txtChar1Rank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtChar1Rank.Enabled = false;
			this.txtChar1Rank.Location = new System.Drawing.Point(152, 40);
			this.txtChar1Rank.Name = "txtChar1Rank";
			this.txtChar1Rank.Size = new System.Drawing.Size(232, 20);
			this.txtChar1Rank.TabIndex = 6;
			this.txtChar1Rank.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(80, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Rank";
			// 
			// txtChar1Name
			// 
			this.txtChar1Name.BackColor = System.Drawing.Color.Lavender;
			this.txtChar1Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtChar1Name.Location = new System.Drawing.Point(152, 8);
			this.txtChar1Name.Name = "txtChar1Name";
			this.txtChar1Name.Size = new System.Drawing.Size(232, 20);
			this.txtChar1Name.TabIndex = 4;
			this.txtChar1Name.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(80, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Name";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 72);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Team Name";
			// 
			// txtTeamName
			// 
			this.txtTeamName.BackColor = System.Drawing.Color.Lavender;
			this.txtTeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTeamName.Location = new System.Drawing.Point(168, 24);
			this.txtTeamName.Name = "txtTeamName";
			this.txtTeamName.Size = new System.Drawing.Size(304, 22);
			this.txtTeamName.TabIndex = 0;
			this.txtTeamName.Text = "";
			this.txtTeamName.Leave += new System.EventHandler(this.txtTeamName_Leave);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Teams";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmdBack
			// 
			this.cmdBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBack.BackgroundImage")));
			this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdBack.Location = new System.Drawing.Point(520, 496);
			this.cmdBack.Name = "cmdBack";
			this.cmdBack.Size = new System.Drawing.Size(208, 24);
			this.cmdBack.TabIndex = 4;
			this.cmdBack.Text = "Back";
			// 
			// cmdSave
			// 
			this.cmdSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdSave.BackgroundImage")));
			this.cmdSave.Enabled = false;
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdSave.Location = new System.Drawing.Point(264, 496);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(208, 24);
			this.cmdSave.TabIndex = 5;
			this.cmdSave.Text = "Save";
			// 
			// frmTeams
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.DarkGray;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(736, 526);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.cmdBack);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grpTeamDetails);
			this.Controls.Add(this.cmdAddTeam);
			this.Controls.Add(this.lstTeams);
			this.Name = "frmTeams";
			this.Text = "Team";
			this.TransparencyKey = System.Drawing.Color.LightPink;
			this.Load += new System.EventHandler(this.frmTeams_Load);
			this.grpTeamDetails.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTeams_Load(object sender, System.EventArgs e)
		{
			cmdSave.Hide();

			/* for(int i = 0; i <= 100; i += 20)
			{
				this.Opacity = i;
			}
			*/
		}

		private void lnkPasswd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
		
		}

		private void grpTeamDetails_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void txtTeamName_Leave(object sender, System.EventArgs e)
		{
			details = myDBMS.getTeam(txtTeamName.Text);
			MessageBox.Show(details[1]);
			this.textBox2.Text = details[1];
		}
	}
}
