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
	public class frmCredits : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdBack;
		private System.Windows.Forms.PictureBox picLine;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button cmdExit;
		private System.Windows.Forms.Timer tmrDisplay;
		private System.ComponentModel.IContainer components;
		private Bitmap[] displayImages = new Bitmap[10];
		private int currentImage = 0;
			frmMainMenu menu ;

		public frmCredits(frmMainMenu m)
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
				displayImages[i] = new Bitmap("C:\\Project\\Code\\cowswithguns2003\\credits\\image"+i+".bmp");
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
			this.cmdExit = new System.Windows.Forms.Button();
			this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(288, 8);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(110, 24);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Credits";
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
			// cmdExit
			// 
			this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExit.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.cmdExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExit.BackgroundImage")));
			this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmdExit.Location = new System.Drawing.Point(584, 8);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.Size = new System.Drawing.Size(96, 24);
			this.cmdExit.TabIndex = 9;
			this.cmdExit.Text = "Exit";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// tmrDisplay
			// 
			this.tmrDisplay.Interval = 5000;
			this.tmrDisplay.Tick += new System.EventHandler(this.tmrDisplay_Tick);
			// 
			// frmCredits
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(696, 494);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.picLine);
			this.Controls.Add(this.cmdBack);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCredits";
			this.Text = "Credits";
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
			Application.Exit();
		}

		private void tmrDisplay_Tick(object sender, System.EventArgs e)
		{
			if(currentImage < this.displayImages.Length-1)
				currentImage++;
			else
				currentImage = 0;

			this.BackgroundImage = displayImages[currentImage];
			this.Invalidate();
			//MessageBox.Show("new image shown");
		}
	}
}
