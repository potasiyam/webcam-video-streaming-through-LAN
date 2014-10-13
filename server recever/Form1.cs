using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Data;
using Voice;

namespace Conference_System
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        //private System.Windows.Forms.TextBox text_SendingPort;
        private System.Windows.Forms.TextBox text_ReceiveingPORT2;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox text_Camera_rec_port;
        private System.Windows.Forms.TextBox text_Camera_rec_port2;
        private System.Windows.Forms.Timer Capturing;
        private WebCam_Capture.WebCamCapture WebCamCapture;
        private Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox text_Camera_rec_port3;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox text_Camera_rec_port4;
        private Label label7;
        private Label label8;
     
		private System.ComponentModel.IContainer components;

		public Form1()
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
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.text_ReceiveingPORT2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Camera_rec_port = new System.Windows.Forms.TextBox();
            this.text_Camera_rec_port2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Capturing = new System.Windows.Forms.Timer(this.components);
            this.WebCamCapture = new WebCam_Capture.WebCamCapture();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.text_Camera_rec_port3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.text_Camera_rec_port4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // text_ReceiveingPORT2
            // 
            this.text_ReceiveingPORT2.Location = new System.Drawing.Point(0, 0);
            this.text_ReceiveingPORT2.Name = "text_ReceiveingPORT2";
            this.text_ReceiveingPORT2.Size = new System.Drawing.Size(100, 20);
            this.text_ReceiveingPORT2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(234, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 150);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Camera#1";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(231, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Camera#2";
            // 
            // text_Camera_rec_port
            // 
            this.text_Camera_rec_port.Location = new System.Drawing.Point(116, 201);
            this.text_Camera_rec_port.Name = "text_Camera_rec_port";
            this.text_Camera_rec_port.Size = new System.Drawing.Size(86, 20);
            this.text_Camera_rec_port.TabIndex = 24;
            this.text_Camera_rec_port.Text = "8000";
            this.text_Camera_rec_port.Visible = false;
            // 
            // text_Camera_rec_port2
            // 
            this.text_Camera_rec_port2.Location = new System.Drawing.Point(330, 201);
            this.text_Camera_rec_port2.Name = "text_Camera_rec_port2";
            this.text_Camera_rec_port2.Size = new System.Drawing.Size(87, 20);
            this.text_Camera_rec_port2.TabIndex = 24;
            this.text_Camera_rec_port2.Text = "8010";
            this.text_Camera_rec_port2.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Receiveing Port";
            this.label6.Visible = false;
            // 
            // WebCamCapture
            // 
            this.WebCamCapture.CaptureHeight = 240;
            this.WebCamCapture.CaptureWidth = 320;
            this.WebCamCapture.FrameNumber = ((ulong)(0ul));
            this.WebCamCapture.Location = new System.Drawing.Point(17, 17);
            this.WebCamCapture.Name = "WebCamCapture";
            this.WebCamCapture.Size = new System.Drawing.Size(342, 252);
            this.WebCamCapture.TabIndex = 0;
            this.WebCamCapture.TimeToCapture_milliseconds = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(16, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(231, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Receiveing Port";
            this.label1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(451, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 150);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // text_Camera_rec_port3
            // 
            this.text_Camera_rec_port3.Location = new System.Drawing.Point(551, 199);
            this.text_Camera_rec_port3.Name = "text_Camera_rec_port3";
            this.text_Camera_rec_port3.Size = new System.Drawing.Size(86, 20);
            this.text_Camera_rec_port3.TabIndex = 31;
            this.text_Camera_rec_port3.Text = "8020";
            this.text_Camera_rec_port3.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(448, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Receiveing Port";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(448, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Camera#3";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(670, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 150);
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // text_Camera_rec_port4
            // 
            this.text_Camera_rec_port4.Location = new System.Drawing.Point(773, 199);
            this.text_Camera_rec_port4.Name = "text_Camera_rec_port4";
            this.text_Camera_rec_port4.Size = new System.Drawing.Size(86, 20);
            this.text_Camera_rec_port4.TabIndex = 35;
            this.text_Camera_rec_port4.Text = "8030";
            this.text_Camera_rec_port4.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(667, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Receiveing Port";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(667, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Camera#4";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(890, 237);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.text_Camera_rec_port4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.text_Camera_rec_port3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_Camera_rec_port);
            this.Controls.Add(this.text_Camera_rec_port2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam receiver";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		


        
		//********************************************************************************//
		
		
		
        NetworkStream myns, myns2, myns3, myns4;
        Thread myth, myth2, myth3, myth4;
        TcpListener mytcpl, mytcpl2, mytcpl3, mytcpl4;				
		Socket mysocket,mysocket2,mysocket3,mysocket4;
        NetworkStream ns, ns2, ns3, ns4;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			myth= new Thread  (new System.Threading .ThreadStart(Start_Receiving_Video_Conference)); // Start Thread Session
			myth.Start (); // Start Receiveing Camera
            myth2 = new Thread(new System.Threading.ThreadStart(Start_Receiving_Video_Conference2)); // Start Thread2 Session
            myth2.Start();
            myth3 = new Thread(new System.Threading.ThreadStart(Start_Receiving_Video_Conference3)); // Start Thread3 Session
            myth3.Start();
            myth4 = new Thread(new System.Threading.ThreadStart(Start_Receiving_Video_Conference4)); // Start Thread4 Session
            myth4.Start();
        }


        private void Start_Receiving_Video_Conference()
		{
			try
			{
             
				// Open The Port
				mytcpl = new TcpListener (int.Parse(text_Camera_rec_port.Text));	
				mytcpl.Start ();						 // Start Listening on That Port
				mysocket = mytcpl.AcceptSocket ();		 // Accept Any Request From Client and Start a Session
				ns = new NetworkStream (mysocket);	 // Receives The Binary Data From Port

				pictureBox1.Image = Image.FromStream(ns);
				mytcpl.Stop();							 // Close TCP Session
				
				if (mysocket.Connected ==true)		     // Looping While Connected to Receive Another Message 
				{
					while (true)
					{
						Start_Receiving_Video_Conference ();				 // Back to First Method
					}
				}
				myns.Flush();
				
			}
			catch (Exception){}
		}

        private void Start_Receiving_Video_Conference2()
        {
            try
            {

                // Open The Port
                mytcpl2 = new TcpListener(int.Parse(text_Camera_rec_port2.Text));
                mytcpl2.Start();						 // Start Listening on That Port
                mysocket2 = mytcpl2.AcceptSocket();		 // Accept Any Request From Client and Start a Session
                ns2 = new NetworkStream(mysocket2);	 // Receives The Binary Data From Port

                pictureBox2.Image = Image.FromStream(ns2);
                mytcpl2.Stop();							 // Close TCP Session

                if (mysocket2.Connected == true)		     // Looping While Connected to Receive Another Message 
                {
                    while (true)
                    {
                        Start_Receiving_Video_Conference2();				 // Back to First Method
                    }
                }
                myns2.Flush();

            }
            catch (Exception) { }
        }
        private void Start_Receiving_Video_Conference3()
        {
            try
            {

                // Open The Port
                mytcpl3 = new TcpListener(int.Parse(text_Camera_rec_port3.Text));
                mytcpl3.Start();						 // Start Listening on That Port
                mysocket3 = mytcpl3.AcceptSocket();		 // Accept Any Request From Client and Start a Session
                ns3 = new NetworkStream(mysocket3);	 // Receives The Binary Data From Port

                pictureBox3.Image = Image.FromStream(ns3);
                mytcpl3.Stop();							 // Close TCP Session

                if (mysocket3.Connected == true)		     // Looping While Connected to Receive Another Message 
                {
                    while (true)
                    {
                        Start_Receiving_Video_Conference3();				 // Back to First Method
                    }
                }
                myns3.Flush();

            }
            catch (Exception) { }
        }

        private void Start_Receiving_Video_Conference4()
        {
            try
            {

                // Open The Port
                mytcpl4 = new TcpListener(int.Parse(text_Camera_rec_port4.Text));
                mytcpl4.Start();						 // Start Listening on That Port
                mysocket4 = mytcpl4.AcceptSocket();		 // Accept Any Request From Client and Start a Session
                ns4 = new NetworkStream(mysocket4);	 // Receives The Binary Data From Port

                pictureBox4.Image = Image.FromStream(ns4);
                mytcpl4.Stop();							 // Close TCP Session

                if (mysocket4.Connected == true)		     // Looping While Connected to Receive Another Message 
                {
                    while (true)
                    {
                        Start_Receiving_Video_Conference4();				 // Back to First Method
                    }
                }
                myns4.Flush();

            }
            catch (Exception) { }
        }
		
		
		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				myth.Abort ();
				mytcpl.Stop ();
				ns.Flush();
				ns.Close();
				myns.Close ();

                myth2.Abort();
                mytcpl2.Stop();
                ns2.Flush();
                ns2.Close();
                myns2.Close();

                myth3.Abort();
                mytcpl3.Stop();
                ns3.Flush();
                ns3.Close();
                myns3.Close();

                myth4.Abort();
                mytcpl4.Stop();
                ns4.Flush();
                ns4.Close();
                myns4.Close();
				
			}
			catch(Exception){}
		}

		

	}
}
