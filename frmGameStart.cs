/*
 * Cows With Guns v 1.0 (for Visual C Sharp .Net 1.1)
 * Coded by: Keith Loughnane (18 - March - 03)
 */

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace cowswithguns2003
{
	/// <summary>
	/// Summary description for frmGameStart.
	/// </summary>
	public class frmGameStart : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel pnlhead;
		private System.Windows.Forms.Button cmdBack;
		private System.Windows.Forms.Button cmdHelp;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Button cmdPlay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTeamName1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTeam1Tank1;
		private System.Windows.Forms.TextBox txtTeam1Tank2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTeam1Tank3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTeam1Tank4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTeam2Tank4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTeam2Tank3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTeam2Tank2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTeam2Tank1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtTeamName2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox chkDebug;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox grpNetwork;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox grpTeamDebug;
		private System.Windows.Forms.Button cmdRemove;
		private System.Windows.Forms.PictureBox picLevel;
		private System.Windows.Forms.Label lblPrint;
		private System.Windows.Forms.ListBox lstTeams;
		private System.Windows.Forms.Button cmdFindClients;


		private System.Windows.Forms.ListBox lstReadyTeams;
		private System.Windows.Forms.GroupBox grpTeam;
		private System.Windows.Forms.ListBox lstLocalTeams;
		private System.Windows.Forms.Button cmdBeClient;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdLevel;
		/// <summary>
		/// Required designer variable.
		/// </summary>

		private	Game myGame;
		private bool debug = false;
		private bool levelReady = false;
		private bool teamsReady = false;

		//number of clients ready
		private int currentClient = 0;
		//the selected level
		private Bitmap level;
		//the path to the selected level
		string Level;
		//the Teams that will be passed to the game
		private Team[] gameTeams;

		private System.ComponentModel.IContainer components;
//*************************** Network Stuff *********************************
		private bool amIClient = false;
		protected TcpListener serverListener;
		protected int port = 1706;
		private NetworkStream networkStream ;
		private StreamReader streamReader ;
		private StreamWriter streamWriter ;
		private System.Net.Sockets.TcpClient myServer;
		private string linein;
		private Socket[] mySocket = new Socket[30];
		private gameClient[] myClients = new gameClient[4];
		private string tmpString;
//***************************************************************************
		public frmGameStart()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			this.grpTeamDebug.Visible = debug;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmGameStart));
			this.pnlhead = new System.Windows.Forms.Panel();
			this.cmdBack = new System.Windows.Forms.Button();
			this.cmdHelp = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.cmdPlay = new System.Windows.Forms.Button();
			this.grpTeamDebug = new System.Windows.Forms.GroupBox();
			this.txtTeam2Tank4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTeam2Tank3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTeam2Tank2 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTeam2Tank1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtTeamName2 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtTeam1Tank4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTeam1Tank3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTeam1Tank2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTeam1Tank1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTeamName1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lstTeams = new System.Windows.Forms.ListBox();
			this.cmdFindClients = new System.Windows.Forms.Button();
			this.lblPrint = new System.Windows.Forms.Label();
			this.lstReadyTeams = new System.Windows.Forms.ListBox();
			this.grpTeam = new System.Windows.Forms.GroupBox();
			this.cmdRemove = new System.Windows.Forms.Button();
			this.lstLocalTeams = new System.Windows.Forms.ListBox();
			this.cmdBeClient = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmdLevel = new System.Windows.Forms.Button();
			this.picLevel = new System.Windows.Forms.PictureBox();
			this.chkDebug = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.grpNetwork = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnlhead.SuspendLayout();
			this.grpTeamDebug.SuspendLayout();
			this.grpTeam.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.grpNetwork.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlhead
			// 
			this.pnlhead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlhead.BackColor = System.Drawing.Color.Transparent;
			this.pnlhead.Controls.Add(this.cmdBack);
			this.pnlhead.Controls.Add(this.cmdHelp);
			this.pnlhead.Controls.Add(this.label19);
			this.pnlhead.Location = new System.Drawing.Point(0, 0);
			this.pnlhead.Name = "pnlhead";
			this.pnlhead.Size = new System.Drawing.Size(808, 48);
			this.pnlhead.TabIndex = 7;
			// 
			// cmdBack
			// 
			this.cmdBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdBack.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBack.BackgroundImage")));
			this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdBack.Location = new System.Drawing.Point(16, 16);
			this.cmdBack.Name = "cmdBack";
			this.cmdBack.Size = new System.Drawing.Size(96, 24);
			this.cmdBack.TabIndex = 3;
			this.cmdBack.Text = "Back";
			this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
			// 
			// cmdHelp
			// 
			this.cmdHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdHelp.BackColor = System.Drawing.Color.Lavender;
			this.cmdHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdHelp.BackgroundImage")));
			this.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdHelp.Location = new System.Drawing.Point(768, 16);
			this.cmdHelp.Name = "cmdHelp";
			this.cmdHelp.Size = new System.Drawing.Size(32, 24);
			this.cmdHelp.TabIndex = 5;
			this.cmdHelp.Text = "?";
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(176, 24);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(520, 16);
			this.label19.TabIndex = 4;
			this.label19.Text = "Please select the type of game you would like :";
			// 
			// cmdPlay
			// 
			this.cmdPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdPlay.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPlay.BackgroundImage")));
			this.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdPlay.Location = new System.Drawing.Point(704, 530);
			this.cmdPlay.Name = "cmdPlay";
			this.cmdPlay.Size = new System.Drawing.Size(96, 24);
			this.cmdPlay.TabIndex = 3;
			this.cmdPlay.Text = "Start Game";
			this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
			// 
			// grpTeamDebug
			// 
			this.grpTeamDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.grpTeamDebug.Controls.Add(this.txtTeam2Tank4);
			this.grpTeamDebug.Controls.Add(this.label7);
			this.grpTeamDebug.Controls.Add(this.txtTeam2Tank3);
			this.grpTeamDebug.Controls.Add(this.label8);
			this.grpTeamDebug.Controls.Add(this.txtTeam2Tank2);
			this.grpTeamDebug.Controls.Add(this.label9);
			this.grpTeamDebug.Controls.Add(this.txtTeam2Tank1);
			this.grpTeamDebug.Controls.Add(this.label10);
			this.grpTeamDebug.Controls.Add(this.label11);
			this.grpTeamDebug.Controls.Add(this.txtTeamName2);
			this.grpTeamDebug.Controls.Add(this.label12);
			this.grpTeamDebug.Controls.Add(this.txtTeam1Tank4);
			this.grpTeamDebug.Controls.Add(this.label6);
			this.grpTeamDebug.Controls.Add(this.txtTeam1Tank3);
			this.grpTeamDebug.Controls.Add(this.label5);
			this.grpTeamDebug.Controls.Add(this.txtTeam1Tank2);
			this.grpTeamDebug.Controls.Add(this.label4);
			this.grpTeamDebug.Controls.Add(this.txtTeam1Tank1);
			this.grpTeamDebug.Controls.Add(this.label3);
			this.grpTeamDebug.Controls.Add(this.label2);
			this.grpTeamDebug.Controls.Add(this.txtTeamName1);
			this.grpTeamDebug.Controls.Add(this.label1);
			this.grpTeamDebug.Location = new System.Drawing.Point(264, 320);
			this.grpTeamDebug.Name = "grpTeamDebug";
			this.grpTeamDebug.Size = new System.Drawing.Size(536, 200);
			this.grpTeamDebug.TabIndex = 9;
			this.grpTeamDebug.TabStop = false;
			this.grpTeamDebug.Text = "Debug Team Entry";
			// 
			// txtTeam2Tank4
			// 
			this.txtTeam2Tank4.BackColor = System.Drawing.Color.Aqua;
			this.txtTeam2Tank4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeam2Tank4.Location = new System.Drawing.Point(344, 152);
			this.txtTeam2Tank4.Name = "txtTeam2Tank4";
			this.txtTeam2Tank4.Size = new System.Drawing.Size(184, 20);
			this.txtTeam2Tank4.TabIndex = 21;
			this.txtTeam2Tank4.Text = "";
			this.txtTeam2Tank4.TextChanged += new System.EventHandler(this.txtTeam2Tank4_TextChanged);
			this.txtTeam2Tank4.Leave += new System.EventHandler(this.txtTeam2Tank4_Leave);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(272, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 24);
			this.label7.TabIndex = 20;
			this.label7.Text = "Tank 4 Name";
			// 
			// txtTeam2Tank3
			// 
			this.txtTeam2Tank3.BackColor = System.Drawing.Color.Aqua;
			this.txtTeam2Tank3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeam2Tank3.Location = new System.Drawing.Point(344, 128);
			this.txtTeam2Tank3.Name = "txtTeam2Tank3";
			this.txtTeam2Tank3.Size = new System.Drawing.Size(184, 20);
			this.txtTeam2Tank3.TabIndex = 19;
			this.txtTeam2Tank3.Text = "";
			this.txtTeam2Tank3.Leave += new System.EventHandler(this.txtTeam2Tank3_Leave);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(272, 128);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 24);
			this.label8.TabIndex = 18;
			this.label8.Text = "Tank 3 Name";
			// 
			// txtTeam2Tank2
			// 
			this.txtTeam2Tank2.BackColor = System.Drawing.Color.Aqua;
			this.txtTeam2Tank2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeam2Tank2.Location = new System.Drawing.Point(344, 104);
			this.txtTeam2Tank2.Name = "txtTeam2Tank2";
			this.txtTeam2Tank2.Size = new System.Drawing.Size(184, 20);
			this.txtTeam2Tank2.TabIndex = 17;
			this.txtTeam2Tank2.Text = "";
			this.txtTeam2Tank2.TextChanged += new System.EventHandler(this.txtTeam2Tank2_TextChanged);
			this.txtTeam2Tank2.Leave += new System.EventHandler(this.txtTeam2Tank2_Leave);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(272, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 24);
			this.label9.TabIndex = 16;
			this.label9.Text = "Tank 2 Name";
			// 
			// txtTeam2Tank1
			// 
			this.txtTeam2Tank1.BackColor = System.Drawing.Color.Aqua;
			this.txtTeam2Tank1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeam2Tank1.Location = new System.Drawing.Point(344, 80);
			this.txtTeam2Tank1.Name = "txtTeam2Tank1";
			this.txtTeam2Tank1.Size = new System.Drawing.Size(184, 20);
			this.txtTeam2Tank1.TabIndex = 15;
			this.txtTeam2Tank1.Text = "";
			this.txtTeam2Tank1.Leave += new System.EventHandler(this.txtTeam2Tank1_Leave);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(272, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 24);
			this.label10.TabIndex = 14;
			this.label10.Text = "Tank 1 Name";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(360, 24);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 24);
			this.label11.TabIndex = 13;
			this.label11.Text = "Team 1";
			// 
			// txtTeamName2
			// 
			this.txtTeamName2.BackColor = System.Drawing.Color.Aqua;
			this.txtTeamName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeamName2.Location = new System.Drawing.Point(344, 48);
			this.txtTeamName2.Name = "txtTeamName2";
			this.txtTeamName2.Size = new System.Drawing.Size(184, 20);
			this.txtTeamName2.TabIndex = 12;
			this.txtTeamName2.Text = "";
			this.txtTeamName2.TextChanged += new System.EventHandler(this.txtTeamName2_TextChanged);
			this.txtTeamName2.Leave += new System.EventHandler(this.txtTeamName2_Leave);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(272, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 24);
			this.label12.TabIndex = 11;
			this.label12.Text = "Team Name";
			// 
			// txtTeam1Tank4
			// 
			this.txtTeam1Tank4.BackColor = System.Drawing.Color.Aqua;
			this.txtTeam1Tank4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeam1Tank4.Location = new System.Drawing.Point(88, 152);
			this.txtTeam1Tank4.Name = "txtTeam1Tank4";
			this.txtTeam1Tank4.Size = new System.Drawing.Size(184, 20);
			this.txtTeam1Tank4.TabIndex = 10;
			this.txtTeam1Tank4.Text = "";
			this.txtTeam1Tank4.Leave += new System.EventHandler(this.txtTeam1Tank4_Leave);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 24);
			this.label6.TabIndex = 9;
			this.label6.Text = "Tank 4 Name";
			// 
			// txtTeam1Tank3
			// 
			this.txtTeam1Tank3.BackColor = System.Drawing.Color.Aqua;
			this.txtTeam1Tank3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeam1Tank3.Location = new System.Drawing.Point(88, 128);
			this.txtTeam1Tank3.Name = "txtTeam1Tank3";
			this.txtTeam1Tank3.Size = new System.Drawing.Size(184, 20);
			this.txtTeam1Tank3.TabIndex = 8;
			this.txtTeam1Tank3.Text = "";
			this.txtTeam1Tank3.Leave += new System.EventHandler(this.txtTeam1Tank3_Leave);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 24);
			this.label5.TabIndex = 7;
			this.label5.Text = "Tank 3 Name";
			// 
			// txtTeam1Tank2
			// 
			this.txtTeam1Tank2.BackColor = System.Drawing.Color.Aqua;
			this.txtTeam1Tank2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeam1Tank2.Location = new System.Drawing.Point(88, 104);
			this.txtTeam1Tank2.Name = "txtTeam1Tank2";
			this.txtTeam1Tank2.Size = new System.Drawing.Size(184, 20);
			this.txtTeam1Tank2.TabIndex = 6;
			this.txtTeam1Tank2.Text = "";
			this.txtTeam1Tank2.Leave += new System.EventHandler(this.txtTeam1Tank2_Leave);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 24);
			this.label4.TabIndex = 5;
			this.label4.Text = "Tank 2 Name";
			// 
			// txtTeam1Tank1
			// 
			this.txtTeam1Tank1.BackColor = System.Drawing.Color.Aqua;
			this.txtTeam1Tank1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeam1Tank1.Location = new System.Drawing.Point(88, 80);
			this.txtTeam1Tank1.Name = "txtTeam1Tank1";
			this.txtTeam1Tank1.Size = new System.Drawing.Size(184, 20);
			this.txtTeam1Tank1.TabIndex = 4;
			this.txtTeam1Tank1.Text = "";
			this.txtTeam1Tank1.TextChanged += new System.EventHandler(this.txtTeam1Tank1_TextChanged);
			this.txtTeam1Tank1.Leave += new System.EventHandler(this.txtTeam1Tank1_Leave);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tank 1 Name";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(104, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Team 1";
			// 
			// txtTeamName1
			// 
			this.txtTeamName1.BackColor = System.Drawing.Color.Aqua;
			this.txtTeamName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTeamName1.Location = new System.Drawing.Point(88, 48);
			this.txtTeamName1.Name = "txtTeamName1";
			this.txtTeamName1.Size = new System.Drawing.Size(184, 20);
			this.txtTeamName1.TabIndex = 1;
			this.txtTeamName1.Text = "";
			this.txtTeamName1.Leave += new System.EventHandler(this.txtTeamName1_Leave);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Team Name";
			// 
			// lstTeams
			// 
			this.lstTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstTeams.Location = new System.Drawing.Point(-120, 56);
			this.lstTeams.Name = "lstTeams";
			this.lstTeams.Size = new System.Drawing.Size(120, 223);
			this.lstTeams.TabIndex = 10;
			this.lstTeams.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstTeams_MouseDown);
			this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
			// 
			// cmdFindClients
			// 
			this.cmdFindClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdFindClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdFindClients.Location = new System.Drawing.Point(0, 56);
			this.cmdFindClients.Name = "cmdFindClients";
			this.cmdFindClients.Size = new System.Drawing.Size(120, 24);
			this.cmdFindClients.TabIndex = 11;
			this.cmdFindClients.Text = "Serve";
			this.cmdFindClients.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// lblPrint
			// 
			this.lblPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblPrint.Location = new System.Drawing.Point(16, 24);
			this.lblPrint.Name = "lblPrint";
			this.lblPrint.Size = new System.Drawing.Size(216, 16);
			this.lblPrint.TabIndex = 12;
			this.lblPrint.Text = "label1";
			// 
			// lstReadyTeams
			// 
			this.lstReadyTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lstReadyTeams.BackColor = System.Drawing.Color.Aqua;
			this.lstReadyTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstReadyTeams.Location = new System.Drawing.Point(3, 16);
			this.lstReadyTeams.MultiColumn = true;
			this.lstReadyTeams.Name = "lstReadyTeams";
			this.lstReadyTeams.Size = new System.Drawing.Size(258, 210);
			this.lstReadyTeams.TabIndex = 0;
			this.lstReadyTeams.TabStop = false;
			// 
			// grpTeam
			// 
			this.grpTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.grpTeam.Controls.Add(this.cmdRemove);
			this.grpTeam.Controls.Add(this.lstReadyTeams);
			this.grpTeam.Location = new System.Drawing.Point(544, 56);
			this.grpTeam.Name = "grpTeam";
			this.grpTeam.Size = new System.Drawing.Size(264, 264);
			this.grpTeam.TabIndex = 14;
			this.grpTeam.TabStop = false;
			this.grpTeam.Text = "Team Entry";
			// 
			// cmdRemove
			// 
			this.cmdRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdRemove.Location = new System.Drawing.Point(3, 238);
			this.cmdRemove.Name = "cmdRemove";
			this.cmdRemove.Size = new System.Drawing.Size(258, 23);
			this.cmdRemove.TabIndex = 1;
			this.cmdRemove.Text = "Remove";
			this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
			// 
			// lstLocalTeams
			// 
			this.lstLocalTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lstLocalTeams.BackColor = System.Drawing.Color.Aqua;
			this.lstLocalTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstLocalTeams.Items.AddRange(new object[] {
															   "Ian",
															   "Keith",
															   "Jones",
															   "someGuy"});
			this.lstLocalTeams.Location = new System.Drawing.Point(8, 64);
			this.lstLocalTeams.Name = "lstLocalTeams";
			this.lstLocalTeams.Size = new System.Drawing.Size(248, 405);
			this.lstLocalTeams.TabIndex = 1;
			this.lstLocalTeams.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstLocalTeams_MouseDown);
			this.lstLocalTeams.SelectedIndexChanged += new System.EventHandler(this.lstLocalTeams_SelectedIndexChanged);
			// 
			// cmdBeClient
			// 
			this.cmdBeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdBeClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdBeClient.Location = new System.Drawing.Point(136, 56);
			this.cmdBeClient.Name = "cmdBeClient";
			this.cmdBeClient.Size = new System.Drawing.Size(112, 24);
			this.cmdBeClient.TabIndex = 16;
			this.cmdBeClient.Text = "Cly";
			this.cmdBeClient.Click += new System.EventHandler(this.cmdBeClient_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cmdLevel);
			this.groupBox1.Controls.Add(this.picLevel);
			this.groupBox1.Location = new System.Drawing.Point(264, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 264);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Level";
			// 
			// cmdLevel
			// 
			this.cmdLevel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.cmdLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdLevel.Location = new System.Drawing.Point(3, 237);
			this.cmdLevel.Name = "cmdLevel";
			this.cmdLevel.Size = new System.Drawing.Size(266, 24);
			this.cmdLevel.TabIndex = 2;
			this.cmdLevel.Text = "choose";
			this.cmdLevel.Click += new System.EventHandler(this.cmdLevel_Click);
			// 
			// picLevel
			// 
			this.picLevel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picLevel.Location = new System.Drawing.Point(3, 16);
			this.picLevel.Name = "picLevel";
			this.picLevel.Size = new System.Drawing.Size(266, 245);
			this.picLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLevel.TabIndex = 18;
			this.picLevel.TabStop = false;
			// 
			// chkDebug
			// 
			this.chkDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chkDebug.Location = new System.Drawing.Point(240, 8);
			this.chkDebug.Name = "chkDebug";
			this.chkDebug.Size = new System.Drawing.Size(192, 16);
			this.chkDebug.TabIndex = 18;
			this.chkDebug.Text = "Debug Mode Team Entry";
			this.chkDebug.Visible = false;
			this.chkDebug.CheckStateChanged += new System.EventHandler(this.chkDebug_CheckStateChanged);
			this.chkDebug.CheckedChanged += new System.EventHandler(this.chkDebug_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(0, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(232, 16);
			this.checkBox1.TabIndex = 19;
			this.checkBox1.Text = "View Network Atempt";
			this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// grpNetwork
			// 
			this.grpNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.grpNetwork.Controls.Add(this.cmdBeClient);
			this.grpNetwork.Controls.Add(this.cmdFindClients);
			this.grpNetwork.Controls.Add(this.lblPrint);
			this.grpNetwork.Location = new System.Drawing.Point(8, 472);
			this.grpNetwork.Name = "grpNetwork";
			this.grpNetwork.Size = new System.Drawing.Size(248, 80);
			this.grpNetwork.TabIndex = 20;
			this.grpNetwork.TabStop = false;
			this.grpNetwork.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.chkDebug);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(264, 528);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(432, 32);
			this.panel1.TabIndex = 21;
			// 
			// frmGameStart
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(808, 560);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.grpNetwork);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lstLocalTeams);
			this.Controls.Add(this.grpTeam);
			this.Controls.Add(this.lstTeams);
			this.Controls.Add(this.grpTeamDebug);
			this.Controls.Add(this.cmdPlay);
			this.Controls.Add(this.pnlhead);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmGameStart";
			this.Text = "frmGameStart";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.pnlhead.ResumeLayout(false);
			this.grpTeamDebug.ResumeLayout(false);
			this.grpTeam.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.grpNetwork.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdBack_Click(object sender, System.EventArgs e)
		{
			//this just puts you back to the main menu;
			this.Close();
			frmMainMenu mainMenu = new frmMainMenu();
			mainMenu.Show();
		}

		private void cmdPlay_Click(object sender, System.EventArgs e)
		{
			startGame();
		}
		public void startGameAsClient()
		{
			// This is not used and some is hard coded but i have left it for you to see
			gameTeams[0] = new Team(myGame,this.myClients[0]);
			gameTeams[1] = new Team(myGame,this.myClients[1]);
			myGame = new Game(this,gameTeams,this.networkStream,this.Level);
			this.Hide();
		}
		public void startGame()
		{
			if(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width != 1024)
				// If the resulution is wrong tell the user.
				MessageBox.Show("Please Set You Screen Resulution to 1240 X 780");
            else
			{
				// If teams and level are ready do the following
				if((levelReady && teamsReady)||this.debug)
				{
//********************  DEBUG MODE ONLY  *************************************************
					if(debug == true)
					{
						gameTeams[0] = new Team(myGame,"temp");
						gameTeams[1] = new Team(myGame,"temp");

						gameTeams[0].teamName = this.txtTeamName1.Text;
						gameTeams[0].tanks[0].name = this.txtTeam1Tank1.Text;
						gameTeams[0].tanks[1].name = this.txtTeam1Tank2.Text;
						gameTeams[0].tanks[2].name = this.txtTeam1Tank3.Text;
						gameTeams[0].tanks[3].name = this.txtTeam1Tank4.Text;

						gameTeams[1].teamName = this.txtTeamName2.Text;
						gameTeams[1].tanks[0].name = this.txtTeam2Tank1.Text;
						gameTeams[1].tanks[1].name = this.txtTeam2Tank2.Text;
						gameTeams[1].tanks[2].name = this.txtTeam2Tank3.Text;
						gameTeams[1].tanks[3].name = this.txtTeam2Tank4.Text;
					}
//*****************************************************************************************
					else
					{
						//create an array of teams with a lenght to match the numbers in lstReadyTeams
						gameTeams = new Team[lstReadyTeams.Items.Count];

						for(int i = lstReadyTeams.Items.Count-1 ; i >= 0 ; i-- )
						{
							if(myClients[i]!= null)
							{
								/* enter each team into game teams that is not null
								 * I think that it will still work without the IF
								 * but better safe then sorry */
								gameTeams[i] = new Team(myGame,this.myClients[i]);
							}
						}
						collectDetailsStuff();
                    }
					this.Hide();
					if(!amIClient)
						myGame = new Game(this,gameTeams,this.Level);
					//else
					//myGame = new ClientGame(this,gameTeams);
				}
				else
				{
					MessageBox.Show("Invalid Details or Level");
				}
			}
		}
		public void collectDetailsStuff()
		{
//******************* ~~  Network Attempt  ~~ ******************************************************
			/* 
			 * This Bit Works; it gets the team and tank names from each remote client
			 */
			for(int cl = 0;cl <2;cl++)
			{
				if((myClients != null)&&!myClients[cl].isLocal && myClients[cl].mySocket.Connected)
				{
					NetworkStream networkStream = new NetworkStream(myClients[cl].mySocket);
					StreamWriter streamWriter   = new StreamWriter(networkStream);
					StreamReader streamReader   = new StreamReader(networkStream);
					
					// Send a message to the client asking form details
					streamWriter.WriteLine("get_tanks");
					streamWriter.Flush();

					// Recive The Teams Name
					tmpString = streamReader.ReadLine();
					gameTeams[cl].teamName = tmpString;
					for(int tl = 0;tl<4;tl++) //loop through each tank
					{
						// keep looping until it recives info
						while(true)
						{
							tmpString = streamReader.ReadLine();
							if(tmpString != "")
							{
								// when you recive info input set it as the team name
								gameTeams[cl].tanks[tl].name = tmpString;
								break;
							}							
						}
					}
				}
			}
			this.cmdFindClients.Enabled = true;
//************************************************************************************************
		}
		public void endGame(Team winnerName)
		{
			frmEndGame endStatsDisplay = new frmEndGame(winnerName,this);
			endStatsDisplay.Show();
			myGame = null;
		}

		private void frmGameStart_Load(object sender, System.EventArgs e)
		{
			//SetStyle(ControlStyles.DoubleBuffer, true);

		}
//*************  ~~ ERROR CHECKING FOR DEBUG MODE ~~  ********************************************
		private void txtTeamName1_Leave(object sender, System.EventArgs e)
		{
			if(txtTeamName1.Text == "")
				txtTeamName1.Text = "Team 1";
		}
		private void txtTeam1Tank3_Leave(object sender, System.EventArgs e)
		{
			if(txtTeam1Tank3.Text == "")
				txtTeam1Tank3.Text = "Tank 3";
		}
		private void txtTeam1Tank1_TextChanged(object sender, System.EventArgs e)
		{

		}
		private void txtTeam1Tank2_Leave(object sender, System.EventArgs e)
		{
			if(txtTeam1Tank2.Text == "")
				txtTeam1Tank2.Text = "Tank 2";
		}
		private void txtTeam1Tank4_Leave(object sender, System.EventArgs e)
		{
			if(txtTeam1Tank4.Text == "")
				txtTeam1Tank4.Text = "Tank 4";
		}
		private void txtTeamName2_Leave(object sender, System.EventArgs e)
		{
			if(txtTeamName2.Text == "")
				txtTeamName2.Text = "Team 2";
		}
		private void txtTeam1Tank1_Leave(object sender, System.EventArgs e)
		{
			if(txtTeam1Tank1.Text == "")
				txtTeam1Tank1.Text = "Tank 1";
		}
		private void txtTeamName2_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		private void txtTeam2Tank1_Leave(object sender, System.EventArgs e)
		{
			if(txtTeam2Tank1.Text == "")
				txtTeam2Tank1.Text = "Tank 1";
		}
		private void txtTeam2Tank2_TextChanged(object sender, System.EventArgs e)
		{
			if(txtTeam2Tank2.Text == "")
				txtTeam2Tank2.Text = "Tank 2";
		}
		private void txtTeam2Tank3_Leave(object sender, System.EventArgs e)
		{
			if(txtTeam2Tank3.Text == "")
				txtTeam2Tank3.Text = "Tank 3";
		}
		private void txtTeam2Tank4_TextChanged(object sender, System.EventArgs e)
		{

		}
		private void txtTeam2Tank2_Leave(object sender, System.EventArgs e)
		{
			if(txtTeam2Tank2.Text == "")
				txtTeam2Tank2.Text = "Tank 2";
		}
		private void txtTeam2Tank4_Leave(object sender, System.EventArgs e)
		{
			if(txtTeam2Tank4.Text == "")
				txtTeam2Tank4.Text = "Tank 4";
		} 
		private void button1_Click(object sender, System.EventArgs e)
		{
		}
//*********** END OF DEBUG ERROR CHECKING *****************************************************


//***********          SERVER             ***************************************************** 
		public void doServerStuff()
		{
			/* disable the Client button so you cannot be a server and a client at 
			/*                        the same time                             */
			this.cmdFindClients.Enabled = false;
			// cl is the current client
			int cl = 0;
			// This starts a listener using port "Port"
			serverListener = new TcpListener(Dns.GetHostByName(Dns.GetHostName()).AddressList[0],port);
			serverListener.Start();
			// Collect up to 10 clients
			while(cl < 10)
			{

				mySocket[cl] =  serverListener.AcceptSocket();
				//lstTeams.ge
				this.lstTeams.Items.Add( serverListener.LocalEndpoint.ToString());
				cl++;
			
			
				//loopReceive();
				if(mySocket[cl].Connected)
				{

					NetworkStream networkStream = new NetworkStream(mySocket[0]);
				

					StreamWriter streamWriter = new StreamWriter(networkStream);
					StreamReader streamReader = new StreamReader(networkStream);
					/*while(true)
					{
					*/
					
					string line = streamReader.ReadLine();
					lblPrint.Text += line;
					this.Invalidate();
					//streamWriter.Flush(); 
					/*if(line == "test")
							break;*/

					//}
				}
			}
			this.cmdFindClients.Enabled = true;
		}
		//This is include 'cause i think i ned it for threading
		public void caller(System.IAsyncResult ar)
		{
			//this.lblPrint.Text = ar.ToString();
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			//start a new thread running doServerStuff()
			ThreadStart myThreadStart = new ThreadStart(doServerStuff);
			System.IAsyncResult m = null;
			m = myThreadStart.BeginInvoke(new AsyncCallback(caller),null);
		}
//***********************END OF SERVER STUFF***************************************************
		


		private void lstTeams_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}


		private void lstTeams_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			/* 
			 * If you click on lstTeams the team you click on will be added to myclients
			 */
			 if(mySocket[this.lstTeams.SelectedIndex] != null)
			{
				myClients[currentClient] = new gameClient(this.mySocket[this.lstTeams.SelectedIndex],"test");
				updateCurrentTeams();
			}
			nextClient();
		}
		private void nextClient()
		{
			if(currentClient <= 3)
				currentClient++;
			if(currentClient >= 2)
				teamsReady = true;
		}
		private void updateCurrentTeams()
		{
			this.lstReadyTeams.Items.Clear();
			for(int i = 0;i<4;i++)
			{
				if(myClients[i] != null)
					this.lstReadyTeams.Items.Add(myClients[i].getDetail());
			}
		}
		private void lstLocalTeams_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(this.lstLocalTeams.SelectedItem != null && currentClient<4)
			{
				myClients[currentClient] = new gameClient(lstLocalTeams.SelectedItem.ToString());
				//MessageBox.Show(lstLocalTeams.SelectedItem.ToString());
				updateCurrentTeams();
				nextClient();
			}
		}
		private void cmdBeClient_Click(object sender, System.EventArgs e)
		{
//***********************  Client Attempt ******************************************
			//amIClient = true;
			cmdFindClients.Enabled = false;
			ThreadStart myThreadStart = new ThreadStart(client);
			System.IAsyncResult m = null;
			m = myThreadStart.BeginInvoke(new AsyncCallback(caller),null);

		}
		
		private void client()
		{
			
			this.amIClient = true;
			myServer = new TcpClient("localhost",1706);
			networkStream = myServer.GetStream();
			streamReader = new StreamReader(networkStream);
			streamWriter = new StreamWriter(networkStream);

			while(true)
			{
				linein = streamReader.ReadLine();

				if(linein == "get_tanks")
				{
					//MessageBox.Show("sending tanks");
					streamWriter.WriteLine("team name");
					streamWriter.Flush();
					streamWriter.WriteLine("1um");
					streamWriter.Flush();
					streamWriter.WriteLine("2are");
					streamWriter.Flush();								
					streamWriter.WriteLine("3ahh");
					streamWriter.Flush();
					streamWriter.WriteLine("4eye");
					streamWriter.Flush();
					this.startGameAsClient();
				}


			}
		}
//***********************************************************************************************

		private void cmdLevel_Click(object sender, System.EventArgs e)
		{
			// this gets a level from a file
			OpenFileDialog openDia = new OpenFileDialog();
			/* allow users to open only .lvl files this is so the
			 * user will not open rediclus unplayable levels */
			openDia.Filter = "Cows With Guns Level | *.lvl";
			if(openDia.ShowDialog() == DialogResult.OK)
			{
				this.Level = openDia.FileName;
				level = new Bitmap(Level);
				this.levelReady = true;
				this.picLevel.Image = level;
				//cmdLevel.Image = level.GetThumbnailImage(cmdLevel.Width,cmdLevel.Height,
			}
		}

		private void lstLocalTeams_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void chkDebug_CheckedChanged(object sender, System.EventArgs e)
		{

		
		}

		private void chkDebug_CheckStateChanged(object sender, System.EventArgs e)
		{
						this.debug = (this.chkDebug.CheckState == CheckState.Checked);
			this.grpTeamDebug.Visible = (this.chkDebug.CheckState == CheckState.Checked);
		
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void checkBox1_CheckStateChanged(object sender, System.EventArgs e)
		{
			this.grpNetwork.Visible = (this.checkBox1.CheckState == CheckState.Checked);
		}

		private void cmdRemove_Click(object sender, System.EventArgs e)
		{
			/* This removes all teams from those ready, i would like this to just remove
			 * the selected client, ahh well.
			 */

			/*
			this.myClients[this.lstReadyTeams.SelectedIndex] = null;
			for(int t = this.lstReadyTeams.SelectedIndex;t>myClients.Length;t--)
			{
				myClients[t] =  myClients[t+1];
			}
			//sortList();
			this.currentClient--;

			*/
			myClients = new gameClient[4];
			this.updateCurrentTeams();
			this.currentClient = 0;
		}
	}
}



