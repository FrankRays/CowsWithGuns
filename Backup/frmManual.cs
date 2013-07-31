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
	/// Summary description for frmCredits.
	/// </summary>
	public class frmManual : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdBack;
		private System.Windows.Forms.PictureBox picLine;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Timer tmrDisplay;
		private System.ComponentModel.IContainer components;
		private Bitmap[] displayImages = new Bitmap[10];
		private int currentImage = 0;
		private System.Windows.Forms.Button cmdNext;
		private System.Windows.Forms.Button cmdPrevius;
		private System.Windows.Forms.Button cmdTimerToggle;
			frmMainMenu menu ;

		public frmManual(frmMainMenu m)
		{
			menu = m;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			for(int i = displayImages.Length - 1; i >=0;i--)
			{
				displayImages[i] = new Bitmap("C:\\Project\\Code\\cowswithguns2003\\manual\\image"+i+".bmp");
			}

			//MessageBox.Show("Images Loaded");

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCredits));
			this.lblTitle = new System.Windows.Forms.Label();
			this.cmdBack = new System.Windows.Forms.Button();
			this.picLine = new System.Windows.Forms.PictureBox();
			this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
			this.cmdNext = new System.Windows.Forms.Button();
			this.cmdPrevius = new System.Windows.Forms.Button();
			this.cmdTimerToggle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(136, 8);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(110, 24);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Manual";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdBack
			// 
			this.cmdBack.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdBack.BackgroundImage")));
			this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdBack.Location = new System.Drawing.Point(16, 8);
			this.cmdBack.Name = "cmdBack";
			this.cmdBack.Size = new System.Drawing.Size(96, 24);
			this.cmdBack.TabIndex = 4;
			this.cmdBack.Text = "Back";
			this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
			// 
			// picLine
			// 
			this.picLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picLine.Image = ((System.Drawing.Image)(resources.GetObject("picLine.Image")));
			this.picLine.Location = new System.Drawing.Point(0, 40);
			this.picLine.Name = "picLine";
			this.picLine.Size = new System.Drawing.Size(664, 2);
			this.picLine.TabIndex = 5;
			this.picLine.TabStop = false;
			// 
			// tmrDisplay
			// 
			this.tmrDisplay.Interval = 5000;
			this.tmrDisplay.Tick += new System.EventHandler(this.tmrDisplay_Tick);
			// 
			// cmdNext
			// 
			this.cmdNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdNext.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdNext.BackgroundImage")));
			this.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdNext.Location = new System.Drawing.Point(576, 8);
			this.cmdNext.Name = "cmdNext";
			this.cmdNext.Size = new System.Drawing.Size(104, 24);
			this.cmdNext.TabIndex = 9;
			this.cmdNext.Text = "Next Page >>";
			this.cmdNext.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// cmdPrevius
			// 
			this.cmdPrevius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdPrevius.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdPrevius.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPrevius.BackgroundImage")));
			this.cmdPrevius.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdPrevius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdPrevius.Location = new System.Drawing.Point(368, 8);
			this.cmdPrevius.Name = "cmdPrevius";
			this.cmdPrevius.Size = new System.Drawing.Size(104, 24);
			this.cmdPrevius.TabIndex = 10;
			this.cmdPrevius.Text = "<< Previus Page";
			this.cmdPrevius.Click += new System.EventHandler(this.cmdPrevius_Click);
			// 
			// cmdTimerToggle
			// 
			this.cmdTimerToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdTimerToggle.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdTimerToggle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdTimerToggle.BackgroundImage")));
			this.cmdTimerToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdTimerToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdTimerToggle.Location = new System.Drawing.Point(472, 8);
			this.cmdTimerToggle.Name = "cmdTimerToggle";
			this.cmdTimerToggle.Size = new System.Drawing.Size(104, 24);
			this.cmdTimerToggle.TabIndex = 11;
			this.cmdTimerToggle.Text = "Stop Timer";
			this.cmdTimerToggle.Click += new System.EventHandler(this.cmdTimerToggle_Click);
			// 
			// frmCredits
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(696, 494);
			this.Controls.Add(this.cmdTimerToggle);
			this.Controls.Add(this.cmdPrevius);
			this.Controls.Add(this.cmdNext);
			this.Controls.Add(this.picLine);
			this.Controls.Add(this.cmdBack);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCredits";
			this.Text = "Stop Timer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Resize += new System.EventHandler(this.frmCredits_Resize);
			this.Load += new System.EventHandler(this.frmCredits_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmCredits_Load(object sender, System.EventArgs e)
		{
			this.tmrDisplay.Enabled = true;
			this.BackgroundImage = this.displayImages[this.displayImages.Length-1];
		}

		private void frmCredits_Resize(object sender, System.EventArgs e)
		{
            picLine.Width = this.Width;
			lblTitle.Left = (this.Width / 2) - (lblTitle.Width / 2);


		}

		private void cmdBack_Click(object sender, System.EventArgs e)
		{
			//frmMainMenu menu = new frmMainMenu();
			menu.Show();
			this.Close();
        }

		private void cmdExit_Click(object sender, System.EventArgs e)
		{
			nextPage();
		}

		private void tmrDisplay_Tick(object sender, System.EventArgs e)
		{
			nextPage();
			//MessageBox.Show("new image shown");
		}
		private void nextPage()
		{
			if(currentImage < this.displayImages.Length-1)
				currentImage++;
			else
				currentImage = 0;

			this.BackgroundImage = displayImages[currentImage];
			this.Invalidate();
		}

		private void cmdTimerToggle_Click(object sender, System.EventArgs e)
		{
			tmrDisplay.Enabled = (!tmrDisplay.Enabled);

		}

		private void cmdPrevius_Click(object sender, System.EventArgs e)
		{
			if(currentImage <= 0)
				currentImage = this.displayImages.Length-1;
			else
				currentImage--;

			this.BackgroundImage = displayImages[currentImage];
			this.Invalidate();
		
		}
	}
}
