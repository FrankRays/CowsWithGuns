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
	/// This form contains all the other forms used for the game screen
	/// it also initalises the players stats screens.
	/// </summary>
	public class frmGameContainer : System.Windows.Forms.Form
	{
				//public FrmContainerBackGround background = new FrmContainerBackGround();
		// displays is an array of forms used at give details to the player
		public frmPlayerDisplay[] displays;
		// creator is the game class that created this object, it is used to
		// call methods in its parent
		//Game creator;
		//the below is generated code
		private System.ComponentModel.Container components = null;


		public frmGameContainer(Game creator)
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
			// 
			// frmGameContainer
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(784, 542);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Name = "frmGameContainer";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Cows With Guns";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGameContainer_KeyDown);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmGameContainer_Closing);
			this.Load += new System.EventHandler(this.frmGameContainer_Load);
			this.DoubleClick += new System.EventHandler(this.frmGameContainer_DoubleClick);

		}
		#endregion

		private void frmGameContainer_Load(object sender, System.EventArgs e)
		{
		#region setting up displays


			//this.background.MdiParent = this;
			//This initalises an array of forms called displays
			displays = new frmPlayerDisplay[4];
			/* this loops trough the first 4 indexes of displays
			 * and creates a frmPlayerDisplay form
			 */
			for(int i = 0; i <= 3; i ++)
			{
				displays[i] = new frmPlayerDisplay();
			}
			//this sets diplsys[4] (the fifth index of displays) to frmTop
			//displays[4] = new frmTop();
			//this loop sets the MDI parent for all entries in displays to
			//this form, and tells them to show
			for(int i = 0; i <= 3; i ++)
			{
				displays[i].MdiParent = this;
				displays[i].Show();
			}
			/* this calculates where the left side of the right player 
			 * displays should be
			 */

			
		#endregion
			#region positioning panels
			//background.Left = 0;
			//background.Top = 0;
			//background.Width = this.Right;
			//background.Height = this.Bottom;
			//background.Show();
			int right = this.Right - displays[1].Width-4;
			/* this calculates where the top of the bottom player displays
			 * should be
			 */ 
			int bottom = this.Bottom - displays[1].Height-4;
			/* this set the position of the 2nd to 4rth display panels
			 */
			displays[1].Left = right;
			displays[2].Top = bottom;
			displays[3].Top = bottom;
			displays[3].Left = right;

			#endregion
		}

		private void frmGameContainer_DoubleClick(object sender, System.EventArgs e)
		{
			

		}



		private void frmGameContainer_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{


		}

		private void frmGameContainer_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			for(int i = 0; i <= 3; i ++)
			{
				displays[i].Close();

			}
		
		}

	}
}
