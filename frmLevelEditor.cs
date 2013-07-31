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
	/// Summary description for frmLevelEditor.
	/// </summary>
	public enum Tool
			{
				Line,Circle
			}
	public enum MouseButton
	{
		Left,Right,None
	}
	public class frmLevelEditor : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button cmdCircle;
		private System.Windows.Forms.Button cmdLine;
		private	ColorDialog cd = new ColorDialog();
		private Color[] drawColor = new Color[2];
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private Tool drawTool;
		private Graphics g;
		//private Graphics bg;
		//private int buttonColor = 0;
		private Brush[] myBrush;
		private Pen[] myPen;
		private System.Windows.Forms.TrackBar trkSize;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button cmdDrag;
		private System.Windows.Forms.Panel toolPanel;
		private Bitmap currentBmp;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.MenuItem mnuTools;
		private System.Windows.Forms.MenuItem mnuSave;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnuLine;
		private System.Windows.Forms.MenuItem mnuCircle;
		private System.Windows.Forms.MenuItem mnuOptions;
		private System.Windows.Forms.MenuItem mnuBrushColor;
		private System.Windows.Forms.MenuItem mnuBrushColor1;
		private System.Windows.Forms.MenuItem mnuLeftBrushColor;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private bool isPanelSrank = false;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.MenuItem mnuOpen;
		private System.Windows.Forms.MenuItem mnuNew;
		//private bool mouseDown = false;
		private MouseButton mouseButtonDown = MouseButton.None;


		public frmLevelEditor()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			currentBmp = new Bitmap("C:\\Project\\Code\\cowswithguns2003\\backgroundimages\\White.bmp");

			g = Graphics.FromImage(currentBmp);
			
			myBrush = new SolidBrush[2];
			myPen = new Pen[2];
			this.drawColor[0] = Color.Red;
			this.drawColor[1] = Color.Blue;

		
		SetTools();

		}
		private void SetTools()
		{

			myBrush[0] = new SolidBrush(drawColor[0]);
			myBrush[1] = new SolidBrush(drawColor[1]);
			myPen[0] = new Pen(myBrush[0]);
			myPen[1] = new Pen(myBrush[1]);
			this.BackgroundImage = this.currentBmp;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLevelEditor));
			this.toolPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.cmdDrag = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmdCircle = new System.Windows.Forms.Button();
			this.cmdLine = new System.Windows.Forms.Button();
			this.trkSize = new System.Windows.Forms.TrackBar();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuNew = new System.Windows.Forms.MenuItem();
			this.mnuOpen = new System.Windows.Forms.MenuItem();
			this.mnuSave = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.mnuTools = new System.Windows.Forms.MenuItem();
			this.mnuLine = new System.Windows.Forms.MenuItem();
			this.mnuCircle = new System.Windows.Forms.MenuItem();
			this.mnuOptions = new System.Windows.Forms.MenuItem();
			this.mnuBrushColor = new System.Windows.Forms.MenuItem();
			this.mnuBrushColor1 = new System.Windows.Forms.MenuItem();
			this.mnuLeftBrushColor = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.toolPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trkSize)).BeginInit();
			this.SuspendLayout();
			// 
			// toolPanel
			// 
			this.toolPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolPanel.Controls.Add(this.panel2);
			this.toolPanel.Controls.Add(this.cmdDrag);
			this.toolPanel.Controls.Add(this.groupBox1);
			this.toolPanel.Controls.Add(this.trkSize);
			this.toolPanel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.toolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolPanel.Location = new System.Drawing.Point(0, 614);
			this.toolPanel.Name = "toolPanel";
			this.toolPanel.Size = new System.Drawing.Size(760, 64);
			this.toolPanel.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Location = new System.Drawing.Point(720, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(32, 48);
			this.panel2.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(18, 24);
			this.button1.TabIndex = 3;
			this.button1.Text = "1";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(17, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(18, 24);
			this.button2.TabIndex = 4;
			this.button2.Text = "2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// cmdDrag
			// 
			this.cmdDrag.BackColor = System.Drawing.Color.RoyalBlue;
			this.cmdDrag.Dock = System.Windows.Forms.DockStyle.Left;
			this.cmdDrag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdDrag.Font = new System.Drawing.Font("Lucida Console", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdDrag.Location = new System.Drawing.Point(0, 0);
			this.cmdDrag.Name = "cmdDrag";
			this.cmdDrag.Size = new System.Drawing.Size(16, 62);
			this.cmdDrag.TabIndex = 6;
			this.cmdDrag.Text = "Hide";
			this.cmdDrag.Click += new System.EventHandler(this.cmdDrag_Click);
			this.cmdDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdDrag_MouseDown);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.groupBox1.Controls.Add(this.cmdCircle);
			this.groupBox1.Controls.Add(this.cmdLine);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(24, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(352, 56);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tools";
			// 
			// cmdCircle
			// 
			this.cmdCircle.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmdCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdCircle.Location = new System.Drawing.Point(8, 16);
			this.cmdCircle.Name = "cmdCircle";
			this.cmdCircle.Size = new System.Drawing.Size(40, 32);
			this.cmdCircle.TabIndex = 0;
			this.cmdCircle.Text = "circle";
			this.cmdCircle.Click += new System.EventHandler(this.cmdCircle_Click);
			// 
			// cmdLine
			// 
			this.cmdLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmdLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdLine.Location = new System.Drawing.Point(56, 16);
			this.cmdLine.Name = "cmdLine";
			this.cmdLine.Size = new System.Drawing.Size(32, 32);
			this.cmdLine.TabIndex = 1;
			this.cmdLine.Text = "line";
			this.cmdLine.Visible = false;
			this.cmdLine.Click += new System.EventHandler(this.cmdLine_Click);
			// 
			// trkSize
			// 
			this.trkSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.trkSize.BackColor = System.Drawing.Color.DarkGray;
			this.trkSize.Location = new System.Drawing.Point(432, 8);
			this.trkSize.Name = "trkSize";
			this.trkSize.Size = new System.Drawing.Size(240, 42);
			this.trkSize.TabIndex = 2;
			this.trkSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuFile,
																					  this.mnuTools,
																					  this.mnuOptions,
																					  this.menuItem2});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuNew,
																					this.mnuOpen,
																					this.mnuSave,
																					this.menuItem8,
																					this.mnuExit});
			this.mnuFile.Text = "&File";
			// 
			// mnuNew
			// 
			this.mnuNew.Index = 0;
			this.mnuNew.Text = "&New";
			this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
			// 
			// mnuOpen
			// 
			this.mnuOpen.Index = 1;
			this.mnuOpen.Text = "&Open";
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// mnuSave
			// 
			this.mnuSave.Index = 2;
			this.mnuSave.Text = "&Save";
			this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 3;
			this.menuItem8.Text = "-";
			// 
			// mnuExit
			// 
			this.mnuExit.Index = 4;
			this.mnuExit.Text = "&Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
			// 
			// mnuTools
			// 
			this.mnuTools.Index = 1;
			this.mnuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnuLine,
																					 this.mnuCircle});
			this.mnuTools.Text = "Tools";
			// 
			// mnuLine
			// 
			this.mnuLine.Index = 0;
			this.mnuLine.Text = "Line";
			// 
			// mnuCircle
			// 
			this.mnuCircle.Index = 1;
			this.mnuCircle.Text = "Circle";
			// 
			// mnuOptions
			// 
			this.mnuOptions.Index = 2;
			this.mnuOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.mnuBrushColor,
																					   this.menuItem1});
			this.mnuOptions.Text = "&Options";
			// 
			// mnuBrushColor
			// 
			this.mnuBrushColor.Index = 0;
			this.mnuBrushColor.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.mnuBrushColor1,
																						  this.mnuLeftBrushColor});
			this.mnuBrushColor.Text = "Brush Color";
			// 
			// mnuBrushColor1
			// 
			this.mnuBrushColor1.Index = 0;
			this.mnuBrushColor1.Text = "Right Button Color";
			// 
			// mnuLeftBrushColor
			// 
			this.mnuLeftBrushColor.Index = 1;
			this.mnuLeftBrushColor.Text = "Left Brush Color";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7});
			this.menuItem1.Text = "Brush Size";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.RadioCheck = true;
			this.menuItem3.Text = "1";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "3";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.Text = "5";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 3;
			this.menuItem6.Text = "10";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 4;
			this.menuItem7.Text = "15";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 3;
			this.menuItem2.Text = "";
			// 
			// frmLevelEditor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(760, 678);
			this.Controls.Add(this.toolPanel);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "frmLevelEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmLevelEditor";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLevelEditor_MouseDown);
			this.Load += new System.EventHandler(this.frmLevelEditor_Load);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLevelEditor_MouseUp);
			this.Validated += new System.EventHandler(this.frmLevelEditor_Validated);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLevelEditor_MouseMove);
			this.toolPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trkSize)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmLevelEditor_Load(object sender, System.EventArgs e)
		{
			//this.toolPanel.Height = this.Height - currentBmp.Height;
			this.resize();
			//picImage.Image = this.currentBmp;
			
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{


				
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				drawColor[1] = cd.Color;
				button2.BackColor = drawColor[1];
				this.Invalidate();
				this.SetTools();
			}
		
		}

		private void frmLevelEditor_Validated(object sender, System.EventArgs e)
		{


			
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			if(cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				drawColor[0] = cd.Color;
				button1.BackColor = drawColor[0];
				this.SetTools();
				this.Invalidate();
			}
		
		}

		private void cmdCircle_Click(object sender, System.EventArgs e)
		{
			drawTool = Tool.Circle;
			this.SetTools();
		}

		private void cmdLine_Click(object sender, System.EventArgs e)
		{
			drawTool = Tool.Line;
		}

		private void picImage_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//this.mouseDown = true;

			

		
		}

		private void frmLevelEditor_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			this.mouseButtonDown = MouseButton.Left;
			
			//this.picImage.Image = this.currentBmp;
			//this.picImage.Invalidate();
		
		}

		private void cmdDrag_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{/*
			this.toolPanel.Left = e.X;
			this.toolPanel.Top = e.Y -(toolPanel.Height/2);
			*/
		}

		private void cmdDrag_Click(object sender, System.EventArgs e)
		{
			if(isPanelSrank)
			{
				this.toolPanel.Width = this.cmdDrag.Width;
				this.toolPanel.Dock = DockStyle.None;
			}
			else
			{
				//this.toolPanel.Width = 240;
				this.toolPanel.Dock = DockStyle.Bottom;
			}

			isPanelSrank = (!isPanelSrank);
		
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			leave();

		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
		
		}

		private void mnuExit_Click_1(object sender, System.EventArgs e)
		{
			leave();
		
		}
		private void leave()
		{
			frmMainMenu mainMenu = new frmMainMenu();
			mainMenu.Show();
			this.Close();
		}

		private void frmLevelEditor_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(!(this.mouseButtonDown == MouseButton.None))
			{
				if(this.mouseButtonDown == MouseButton.Left)
				g.FillEllipse(myBrush[0],e.X-trkSize.Value*10/2,e.Y-trkSize.Value*10/2,trkSize.Value*10,	trkSize.Value*10);
				else
				g.FillEllipse(myBrush[1],e.X-trkSize.Value*10/2,e.Y-trkSize.Value*10/2,trkSize.Value*10,	trkSize.Value*10);
				this.BackgroundImage = this.currentBmp;
				this.Invalidate();
			}


		
		}

		private void frmLevelEditor_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.mouseButtonDown = MouseButton.None;
		}

		private void mnuSave_Click(object sender, System.EventArgs e)
		{	
			SaveFileDialog saveDia = new SaveFileDialog();
			saveDia.FileName = "new.lvl";
			if(saveDia.ShowDialog() == DialogResult.OK)
			{
				this.currentBmp.Save(saveDia.FileName);

			}
		}

		private void mnuOpen_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog openDia = new OpenFileDialog();
			//openDia.Filter = "Image | *.bmp ; *.jpeg ; *.jpg|cwg Level|*.lvl|all|*.*";
			openDia.Filter = "Cows With Guns Level (*.lvl)|*.lvl| all (load non lvl at your own rist) |*.*";
			if(openDia.ShowDialog() == DialogResult.OK)
			{
				this.currentBmp = new Bitmap(openDia.FileName);
			}
			g = Graphics.FromImage(currentBmp);
			this.resize();
			this.SetTools();
			//g = Graphics.FromImage(currentBmp);

		
		}

		private void mnuNew_Click(object sender, System.EventArgs e)
		{
			this.currentBmp = new Bitmap("C:\\Project\\Code\\cowswithguns2003\\backgroundimages\\White.bmp");
			g = Graphics.FromImage(currentBmp);
			this.SetTools();
		}
		private void resize()
		{
			this.Width = this.currentBmp.Width;
			this.Height = this.currentBmp.Height + this.toolPanel.Height;
		}
	}
}
