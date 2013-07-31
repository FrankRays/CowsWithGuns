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
	/// Summary description for weaponsMenu.
	/// </summary>
	public class frmWeaponsMenu : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdGernade;
		private System.Windows.Forms.Button cmdMissil;
		private System.Windows.Forms.Button cmdTorch;
		private Color activeColor;
		private Color inactiveColor;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button cmdBeem;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button cmdFireSheild;
		private System.Windows.Forms.Button cmdBomb;
		private Game creator;

		public frmWeaponsMenu(Game c)
		{
			creator =c;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			inactiveColor = Color.Blue;
			activeColor = Color.Red;
			this.Invalidate();
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
			this.cmdGernade = new System.Windows.Forms.Button();
			this.cmdMissil = new System.Windows.Forms.Button();
			this.cmdTorch = new System.Windows.Forms.Button();
			this.cmdBeem = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.cmdFireSheild = new System.Windows.Forms.Button();
			this.cmdBomb = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdGernade
			// 
			this.cmdGernade.Enabled = false;
			this.cmdGernade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdGernade.Location = new System.Drawing.Point(8, 56);
			this.cmdGernade.Name = "cmdGernade";
			this.cmdGernade.Size = new System.Drawing.Size(96, 24);
			this.cmdGernade.TabIndex = 2;
			this.cmdGernade.Text = "gernade";
			this.cmdGernade.Visible = false;
			// 
			// cmdMissil
			// 
			this.cmdMissil.BackColor = System.Drawing.Color.RoyalBlue;
			this.cmdMissil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdMissil.Enabled = false;
			this.cmdMissil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdMissil.Location = new System.Drawing.Point(8, 32);
			this.cmdMissil.Name = "cmdMissil";
			this.cmdMissil.Size = new System.Drawing.Size(96, 24);
			this.cmdMissil.TabIndex = 0;
			this.cmdMissil.Text = "Missil";
			this.cmdMissil.Visible = false;
			// 
			// cmdTorch
			// 
			this.cmdTorch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cmdTorch.BackColor = System.Drawing.Color.Red;
			this.cmdTorch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmdTorch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdTorch.Location = new System.Drawing.Point(8, 128);
			this.cmdTorch.Name = "cmdTorch";
			this.cmdTorch.Size = new System.Drawing.Size(96, 24);
			this.cmdTorch.TabIndex = 3;
			this.cmdTorch.Text = "Torch";
			this.cmdTorch.Click += new System.EventHandler(this.cmdTorch_Click);
			// 
			// cmdBeem
			// 
			this.cmdBeem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cmdBeem.BackColor = System.Drawing.Color.Red;
			this.cmdBeem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdBeem.Location = new System.Drawing.Point(8, 104);
			this.cmdBeem.Name = "cmdBeem";
			this.cmdBeem.Size = new System.Drawing.Size(96, 24);
			this.cmdBeem.TabIndex = 4;
			this.cmdBeem.Text = "Beem To";
			this.cmdBeem.Click += new System.EventHandler(this.cmdBeem_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblTitle.Location = new System.Drawing.Point(8, 8);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(96, 16);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "SelectWeapon";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmdFireSheild
			// 
			this.cmdFireSheild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cmdFireSheild.BackColor = System.Drawing.Color.Red;
			this.cmdFireSheild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdFireSheild.Location = new System.Drawing.Point(8, 152);
			this.cmdFireSheild.Name = "cmdFireSheild";
			this.cmdFireSheild.Size = new System.Drawing.Size(96, 24);
			this.cmdFireSheild.TabIndex = 6;
			this.cmdFireSheild.Text = "Fire Sheild";
			this.cmdFireSheild.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// cmdBomb
			// 
			this.cmdBomb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cmdBomb.BackColor = System.Drawing.Color.Red;
			this.cmdBomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdBomb.Location = new System.Drawing.Point(8, 80);
			this.cmdBomb.Name = "cmdBomb";
			this.cmdBomb.Size = new System.Drawing.Size(96, 24);
			this.cmdBomb.TabIndex = 7;
			this.cmdBomb.Text = "bomb";
			this.cmdBomb.Click += new System.EventHandler(this.cmdBomb_Click);
			// 
			// frmWeaponsMenu
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(112, 184);
			this.Controls.Add(this.cmdBomb);
			this.Controls.Add(this.cmdFireSheild);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.cmdBeem);
			this.Controls.Add(this.cmdTorch);
			this.Controls.Add(this.cmdGernade);
			this.Controls.Add(this.cmdMissil);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmWeaponsMenu";
			this.Load += new System.EventHandler(this.weaponsMenu_Load);
			this.Activated += new System.EventHandler(this.frmWeaponsMenu_Activated);
			this.Leave += new System.EventHandler(this.frmWeaponsMenu_Leave);
			this.ResumeLayout(false);

		}
		#endregion

		private void weaponsMenu_Load(object sender, System.EventArgs e)
		{

		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void frmWeaponsMenu_Leave(object sender, System.EventArgs e)
		{
			this.Hide();
		}
		private void cmdTorch_Click(object sender, System.EventArgs e)
		{
			creator.setCurrentWeapon("torch");
			this.Hide();
		
		}
		private void cmdBeem_Click(object sender, System.EventArgs e)
		{
			creator.myGameScreen.beemMode();
			creator.setCurrentWeapon("beamer");
			this.Hide();
		}
		private void button1_Click_1(object sender, System.EventArgs e)
		{
			creator.setCurrentWeapon("shield");
			this.Hide();
		
		}
		private void cmdBomb_Click(object sender, System.EventArgs e)
		{
			creator.setCurrentWeapon("bomb");
			this.Hide();		
		}
		private void frmWeaponsMenu_Activated(object sender, System.EventArgs e)
		{
		}
		public void updateValues()
		{
			if(creator.currentTeamObject.currentTankObject.bombsLeft == 0)
			{
				cmdBomb.Enabled = false;
				cmdBomb.BackColor = inactiveColor;
			}
			else
			{
				cmdBomb.Enabled = true;
				cmdBomb.BackColor = activeColor;
			}
			cmdBomb.Text = "Bomb " + creator.currentTeamObject.currentTankObject.bombsLeft.ToString();

			if(creator.currentTeamObject.currentTankObject.fireSheildsLeft == 0)
			{
				cmdFireSheild.Enabled = false;
				cmdFireSheild.BackColor = inactiveColor;
			}
			else
			{
				cmdFireSheild.Enabled = true;
				cmdFireSheild.BackColor = activeColor;

			}
			cmdFireSheild.Text = "Fire Sheild " + creator.currentTeamObject.currentTankObject.fireSheildsLeft.ToString();

			if(creator.currentTeamObject.currentTankObject.torchLeft == 0)
			{
				
				cmdTorch.Enabled = false;
				cmdTorch.BackColor = inactiveColor;
			}
			else
			{
				cmdTorch.Enabled = true;
				cmdTorch.BackColor = activeColor;

			}
			cmdTorch.Text = "Torch " + creator.currentTeamObject.currentTankObject.torchLeft.ToString();
		}
			

	}
}




