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
	/// This screen displays what is happening in the game and takes input
	/// 
	/// </summary>
	public class frmGameScreen : System.Windows.Forms.Form
	{
		#region Variable and object delaration
		private Game creator;
		/* skyColor is the color that is to be taken as sky this  is important 
		** to distinguish from ground. it is set to the inital background images
		**pixel 1,1
		*/
		public Color skyColor;
		/* this is the color of explotions, this is important because at the time
		 * of an explotion the explotion is also drawn to a bitmap any tested to 
		 * see if to see which if any are in the explotion
		 */
		public Color fireColor = Color.FromArgb(255,200,100,100);
		//MessageActive represents whether the announcemet message is shown.
		//private bool messageActive = false;
		/* if fullRenderOn is true the entire screen is rendered not just the 
		 * current tank and bombs. 
		 * if beemModeOn is true then the current tanks x,y co-ords are set to
		 * the x,y co-ords of the mouse
		 */
		public bool fullRenderOn = true,beemModeOn = false;
		/* the string message is the text that is shown on the screen. */
		//private string message = "";
		// messageTimer is the lenght of time the message is shown
		//private int messageTimer = 0;
		// announcementFont is the font used for
		private Font announceFont = new Font("Arial",30);
		/* xcenter and ycenter represent the center of this form, textPosX and
		 * textPosY are the position of the top left corner of the announcment.
		 */
		//private int xcenter, ycenter;//textPosX,textPosY;
		/* These bitmaps are used for the creation of the frames that will
		 * be displayed. backGround is the current back ground and is used
		 * on the back of the frame. tankImage is the image of the tanks 
		 * thes are placed on the fram in front of the background in the 
		 * appropriate positions
		 */
		// This bitmap is will eventualy be drawn to the screen
		private Bitmap frame = new Bitmap(1200,800);
		// This is the image of a tank that will be used to create the frame
		private Bitmap tankImage = new Bitmap("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\tank.gif");
		// This is the backGround; the level its self
		public Bitmap backGround;
		// This image will be the background with the tanks drawn on it, it is used for collition detection
		public Bitmap backGroundWithTanks;
		/* Background with details is an image with the land as it currently is, with all but the current tank.
		 * This is used so that the whole screen does not nead to be created every frame. also this image is used
		 * for collition detection
		 */
		// arrows
		public Bitmap leftArrow = new Bitmap(Image.FromFile("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\leftArrow.gif"));
		public Bitmap rightArrow = new Bitmap(Image.FromFile("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\rightArrow.gif"));
		// whiteScreen is an image used to reset the explostion layer
		private Bitmap whiteScreen = new Bitmap(Image.FromFile("C:\\Project\\Code\\cowswithguns2003\\backgroundimages\\white.bmp"));
		// This image is used for bombs when creating a frame
		private Bitmap bombImage = new Bitmap("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\bomb.gif");
		// this image is used when a bomb is above the screen
		private Bitmap arrowImage = new Bitmap("C:\\Project\\Code\\cowswithguns2003\\midgroundimages\\up_arrow.gif");
		private Bitmap backGroundWithTanksDetails;
		
		public bool startMessage = false;

		// this is the explotion layer it is used to test is a tank is in the blast radius
		public Bitmap explotionLayer = new Bitmap(1200,800);
		/* overHeadLables is an array of bitmaps that are ingame over head lables lables for 
		 * all inactive tanks buy only drawing once i save a load of processing
		 */
		private Bitmap[,] overHeadLables;
		// graphics class 'g' is used for drawing to frame
		private Graphics g;
		// graphics 'b' class is used for drawing to background
		//this is done when an explotion changes the land
		private Graphics b;
		/* this is used to draw to the explotion layer the explotion layer,
		 * the explotion layer it is used to test is a tank is in the blast radius.
		 */
		private Graphics e;
		// bgwtad is used to draw the BackGround With Tanks And Details
		private Graphics bgwtad;
		/* bgwt is used to draw to the backGroundWithTanks image
		 * it is important for collition detection
		 */
		private Graphics bgwt;
		/* lbltxt draws each overhead lable for each tank at the start of the game saving
		 * time.
		 */
		private Graphics lbltxt; 
		/* isEDrawn is used to prevent the explotion being drawn ever frame an explotion exitist
		 * this will shortly be removed. and the explotion layer will be drawn to by a method.
		 */
		public bool isEDrawn = false;
		//this is the color of the aiming circle and line
		private Pen aimerColor = new Pen(System.Drawing.Color.Red,2);
		// this is the color of the display box of inactive tanks
		private Brush displayBrush = new SolidBrush(System.Drawing.Color.FromArgb(150,240,240,255));
		// this is the color of the display box of the active tank
		private Brush CurrentDisplayBrush = new SolidBrush(System.Drawing.Color.FromArgb(255,240,240,255));
		// this is the color of the text in the display boxes
		private Brush textBrush = new SolidBrush(System.Drawing.Color.Black);
		// this brush is used for drawing explotions onto the forgroound and the eplotion bitmap. 
		private Brush fireBrush;
		//this Brush is used to remove land from the back ground by drawing sky over it
		private Brush skyBrush;
		//this font is used to write on the overhead display boxes
		private Font myFont = new Font("Arial",10);

		//if nothing breaks remove the following line
		//public bool fullRefresh = true;



		//GENERATED STUFF
		public System.Windows.Forms.Timer tmrPhysics; 
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Timer tmrFrame;
		private System.ComponentModel.IContainer components;
		#endregion


		public frmGameScreen(Game c,string l)
		{
			//********     BITMAPS    *************************
			// Instanciate backGround with the image at path l
			backGround                 = new Bitmap(Image.FromFile(l));
			// Instanciate backGroundWithTanks with the same attributes as backGround
			backGroundWithTanks        = new Bitmap(backGround);
			// Instanciate backGroundWithTanks with the same attributes as backGround
			backGroundWithTanksDetails = new Bitmap(backGround);

			//******* GRAPHICS OBJECTS *************************
			// Graphics classes for drawing on different Bitmaps
			g     = Graphics.FromImage(frame);
			b     = Graphics.FromImage(backGround);
			e     = Graphics.FromImage(explotionLayer);
			bgwt  = Graphics.FromImage(backGroundWithTanks);
			bgwtad= Graphics.FromImage(backGroundWithTanksDetails);

			skyColor = backGround.GetPixel(1,1);

			//*******  BRUSH OBJECTS  **************************
			//brushes to draw fire/explotions and to draw sky
			skyBrush =  new SolidBrush(skyColor);
			fireBrush = new SolidBrush(fireColor);

			/* Set the sky color as the color at pixel 1,1 this means the the
			 * game adapts to the image.*/

			// creator is the game class this is contained in
			creator = c;
//********************************************************************************************************
//                            DRAW OVER HEAD LABELS
//********************************************************************************************************
			// Create a 2D array of bitmaps for th lables (number of teams) X 4
			overHeadLables = new Bitmap[creator.gameTeams.Length,4];
			//******** ~~ Go Through all teams and tanks *********************************
			for(int loopTeam = creator.gameTeams.Length-1; loopTeam >= 0; loopTeam --){
				for(int loopTank = 3; loopTank >= 0; loopTank--){

					//create a new Bitmap on the current index
					this.overHeadLables[loopTeam,loopTank] = new Bitmap(70,50);
					//set the graphis object lbltxt to reference the current Bitmap
					lbltxt = Graphics.FromImage(overHeadLables[loopTeam,loopTank]);
					//This creates a rectangle to draw a string on to
					lbltxt.FillRectangle(displayBrush,0,0,70,30);
					//Display team name above each tank
					lbltxt.DrawString(creator.gameTeams[loopTeam].teamName,myFont,textBrush,2,2);
					//Display tank name above each tank
					lbltxt.DrawString(creator.gameTeams[loopTeam].tanks[loopTank].name,myFont,textBrush,2,16);

					}
			}
//***********************************************************************************************************
 
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmGameScreen));
			this.tmrFrame = new System.Windows.Forms.Timer(this.components);
			this.tmrPhysics = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// tmrFrame
			// 
			this.tmrFrame.Enabled = true;
			this.tmrFrame.Interval = 150;
			this.tmrFrame.Tick += new System.EventHandler(this.tmrFrame_Tick);
			// 
			// tmrPhysics
			// 
			this.tmrPhysics.Enabled = true;
			this.tmrPhysics.Interval = 150;
			this.tmrPhysics.Tick += new System.EventHandler(this.tmrPhysics_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox1.Location = new System.Drawing.Point(0, 400);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1020, 68);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// frmGameScreen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1020, 468);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Location = new System.Drawing.Point(0, 150);
			this.Name = "frmGameScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmGameScreen";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGameScreen_KeyDown);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGameScreen_MouseDown);
			this.Load += new System.EventHandler(this.frmGameScreen_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmGameScreen_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		public void showMessage(string msg,int secs)
		{
			/*
			 * This was Supposed to draw messages on the screen for a while
			 * but it didn't work out
			 */

			/*
			if((creator.myTimer.timey.minute > 0) && (creator.myTimer.timey.second > 30))
			message = msg;
			lbltxt = Graphics.FromImage(announcment);
			this.textPosX = this.xcenter - 150;
			this.textPosY = this.ycenter - 25;
			lbltxt.DrawString(message,announceFont,textBrush,0,0);
			messageTimer = 30;
			messageActive = true;
			*/
		}
		private void frmGameScreen_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (beemModeOn)
			{
				creator.beemCurrentTo(e.X,e.Y);
				beemModeOn = false;
			}
			else
			{
				creator.ShowWeapons(e.X,e.Y);
			}
		}

		private void frmGameScreen_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// this sends the keyboard input to the input method of the Game object Creater			
			creator.input(e.KeyValue.ToString());			
		}
		public void beemMode()
		{
			/* Beem mode means that if the user clicks on the screen
			 * their tank will be teleported to the mouses location
			 */
			this.beemModeOn = true;
		}
//******************************************************************************************************************
//		      DRAWING / RENDERING 
//******************************************************************************************************************
		public void resetExplotionLayer()
		{
			/* This draws white onto the explotion layer to clear damage
			 * If you draw the wight shade of red onto C:\project\code\backgrounds\white.bmp
			 * then that area will always hert. this could be good for more
			 * interesting levels
			 */
			e.DrawImage(whiteScreen,0,0);
		}
//******************************************************************************************************************
//            PRERENDER DRAWING (this is only does once in a while)
//******************************************************************************************************************
		public void drawBGWT()
		{
			bgwt.DrawImage(backGround,0,0);
			// This loops through all the teams drawing them to the screen
			for(int currentTeam = 0; currentTeam <= creator.gameTeams.Length-1; currentTeam++)
			{
				// This loops through all the tanks drawing them to the screen
				for(int currentTank = 0; currentTank <= 3; currentTank++)
				{
					if((creator.gameTeams[currentTeam].tanks[currentTank].isAlive == true)
						&&(creator.gameTeams[currentTeam].tanks[currentTank].isCurrent == false))
					{
						//Display the image of a tank
						bgwt.DrawImage(tankImage,
							creator.gameTeams[currentTeam].tanks[currentTank].x -10,
							creator.gameTeams[currentTeam].tanks[currentTank].y -20);
					}
				}
			}
			addDetails();
		}
		public void addDetails()
		{
			/* Draw the backGroundWithTanks onto bgwtad so that backGroundWithTanks is not affected and
			 * can be used for contition detection without lables becoming solid
			 */
			bgwtad.DrawImage(backGroundWithTanks,0,0);
			// Loop Through all tanks in all teams
			for(int currentTeam = 0; currentTeam <= creator.gameTeams.Length-1; currentTeam++){
				for(int currentTank = 0; currentTank <= 3; currentTank++){
					// If the tank isn't dead and it doesn't have the go do this.
					if((creator.gameTeams[currentTeam].tanks[currentTank].isAlive == true) 
						&&(creator.gameTeams[currentTeam].tanks[currentTank].isCurrent == false)){

						// this draws the background onto the BackGroundWithTanks
						bgwtad.DrawImage(overHeadLables[currentTeam,currentTank],
							creator.gameTeams[currentTeam].tanks[currentTank].x -20,
							creator.gameTeams[currentTeam].tanks[currentTank].y -70);
						//Display the health of each tank above it
						bgwtad.DrawString(creator.gameTeams[currentTeam].tanks[currentTank].health.ToString(),
							myFont,
							textBrush,
							creator.gameTeams[currentTeam].tanks[currentTank].x +20,
							creator.gameTeams[currentTeam].tanks[currentTank].y -60);
					}
				}
			}
		}
//***********************************************************************************************************************
//                     EVERY FRAME DRAWING
//***********************************************************************************************************************
		public void drawFrame()
		{
			/* The method draws all the images on that are as well as
			 * the explotion bitmap and backGroundWithTanks bitmap*/
			if(!creator.isSettled())
			{
				drawBGWT();
				// ****** ~~ to see when full render mode is on or off un-comment the following
				//g.DrawString("full render mode on",myFont,textBrush,100,100);
			}
			//draw the image backGroundWithTanksDetails onto Frame
			g.DrawImage(backGroundWithTanksDetails,0,0);

			//************** ~~ don't do this if the tank is dead ~~ ***********************************
			if(creator.isCurrentAlive() == true)
			{
				// Draw the image of the tank onto the frame image
				g.DrawImage(tankImage,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].x -10,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].y -20);
				//************** ~~        draw over head lable       ~~ ***********************************************************************
				// Draw The outer rectangle on the over head lable
				g.DrawRectangle(aimerColor,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].x -20,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].y -70,
					/*Width   : */ 50,
					/*Height  : */ 30);
				//This creates a rectangle to draw a string on to
				g.FillRectangle(CurrentDisplayBrush,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].x -20,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].y - 70,
					/* Width  : */ 50,
					/* Height : */ 30);
				//Display team name above each tank
				g.DrawString(creator.gameTeams[creator.currentTeam].teamName,
					myFont,
					textBrush,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].x -18,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].y -68);
				//Display the health of each tank above it
				g.DrawString(creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].health.ToString(),
					myFont,
					textBrush,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].x -18,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].y -56);
				//************** ~~draw the little arrow that show the tanks direction~~ ********************************************************

				if(creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].facingleft)
					g.DrawImage(leftArrow,
						creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].x -30,
						creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].y -20);
				else
					g.DrawImage(rightArrow,
						creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].x +30 ,
						creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].y -20);

				//************** ~~     draw the weapon overhead      ~~ *************************************************************************
				
				g.DrawImage(this.creator.getCurrentWeaponImage(),
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].x -10,
					creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].y -90);

				//************** ~~  draw the circle around the tank  ~~ *************************************************************************
				g.DrawEllipse(aimerColor,creator.getCurrentTankX()-20,creator.getCurrentTankY()-30,40,40);
				//************** ~~    this draws the aimer line      ~~ *************************************************************************
				//change the drawing grid so that 0,0 is now on the tank
				g.TranslateTransform(creator.getCurrentTankX(),creator.getCurrentTankY()-10);
				//rotate the drawing grid so that the y axis is aligned with the aiming direction
				g.RotateTransform(-(creator.getCurrentTankAim()));
				/* Draw the line going from 0,0 on the new grid to 0,(the power of the blast)
				 * This will draw a line traight up, because we have changed the rules of drawing
				 * streight up is now the aimer angle
				 */
				g.DrawLine(aimerColor,
					/* From : */0,0,
					/* To   : */0,creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].power * 10);
				//put everything back the way i got it
				g.ResetTransform();
				//************** ~~    draw and Handle explotions    ~~ **************************************************************************
				// Go trough all potental explotions
				for(int b = 5; b >= 0 ;b--)
				{
					// if the explotion exists
					if(creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b] != null)
					{
						/* this is in a try chatch so that if part of the explotion is off the screen
						 * you will not get an array out of bounds exeption
						 */
						try
						{
							// this draws the explotion onto the fram Bitmap so you can see the explotion
							g.FillEllipse(fireBrush,
								creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].x,
								creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].y,
								creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].size,
								creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].size);
							//**************** ~~ This Handles Drawing onto the damage layer ~~ ******************
							
							if(creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].isAtStart == true)
							// IF this has not been drawn before draw it now
							{
								//Draw an explotion onto the explotion layer so that the damage can be detected
								e.FillEllipse(fireBrush,
									creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].x,
									creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].y,
									creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].size+10,
									creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].size+10);
								//Take a Chunk out of the land	
								this.b.FillEllipse(skyBrush,
									creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].x,
									creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].y,
									creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].size,
									creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].size);
								//set the started property to true so this code doesn't run again
								//creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].blasts[b].started();
								
								isEDrawn = true;

								//Redraw the background to take into account the explotion
								creator.myGameScreen.drawBGWT();
							}
						}
							// This finally is here only because the try neads a 'catch' or a 'finally'
						finally
						{
						}        
					}
				}
				//********************* ~~  Projectile Drawing  ~~ *********************************************************		
				if((creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].shell != null)  )
				{
					
					if((creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].shell.y > 0))
						// If the shell is not above the screen Draw it.
					{
						g.DrawImage(bombImage,
							creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].shell.x-5,
							creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].shell.y-5);
					}
					else
						// If it is above the screen draw an arrow at the top of the screen.
					{
						g.DrawImage(arrowImage, 
							creator.gameTeams[creator.currentTeam].tanks[creator.gameTeams[creator.currentTeam].currentTank].shell.x,
							2);
					}
				}
			}
		}
		//*************** ~~ Applying the image to the screen ~~ *********************************
		private void frmGameScreen_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			// this draws 'frame' onto the screen
			Graphics r = e.Graphics;
			r.DrawImage(frame,0,0);
		}
//***************************************************************************************************
//                                   END OF DRAWING / RENDERING
//***************************************************************************************************
		public void debugMessage(string n)
		{
			MessageBox.Show(n);
		}


		private void tmrFrame_Tick(object sender, System.EventArgs e)
		{
			// every time this is called a frame is drawn, set as this forms bakcground,
			drawFrame();
			this.BackgroundImage = frame;
			this.Invalidate();			
		}

		private void tmrPhysics_Tick(object sender, System.EventArgs e)
		{
			/* Every time that tmrPhysics Ticks Physics are applied by using
			 * a timer this runs at the same speed on all machines and the speed
			 * can be adjusted easily.
			 */
			creator.ApplyPhysics();
		}

		private void frmGameScreen_Load(object sender, System.EventArgs e)
		{
		
		}
	}//end class
}//end namespace
