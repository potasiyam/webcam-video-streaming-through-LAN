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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Timer Capturing;
		private System.Windows.Forms.TextBox text_Camera_send_port;
        private WebCam_Capture.WebCamCapture WebCamCapture;
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
            this.text_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Capturing = new System.Windows.Forms.Timer(this.components);
            this.text_Camera_send_port = new System.Windows.Forms.TextBox();
            this.WebCamCapture = new WebCam_Capture.WebCamCapture();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_IP
            // 
            this.text_IP.Location = new System.Drawing.Point(77, 12);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(95, 20);
            this.text_IP.TabIndex = 10;
            this.text_IP.Text = "192.168.0.47";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Server IP";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "My Camera";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(207, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Video Port";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(243, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 24);
            this.button3.TabIndex = 26;
            this.button3.Text = "Stop Camera";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(149, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 24);
            this.button4.TabIndex = 25;
            this.button4.Text = "Start Camera";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Capturing
            // 
            this.Capturing.Tick += new System.EventHandler(this.Capturing_Tick);
            // 
            // text_Camera_send_port
            // 
            this.text_Camera_send_port.Location = new System.Drawing.Point(271, 12);
            this.text_Camera_send_port.Name = "text_Camera_send_port";
            this.text_Camera_send_port.Size = new System.Drawing.Size(61, 20);
            this.text_Camera_send_port.TabIndex = 27;
            this.text_Camera_send_port.Text = "8080";
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
            this.WebCamCapture.ImageCaptured += new WebCam_Capture.WebCamCapture.WebCamEventHandler(this.WebCamCapture_ImageCaptured);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(346, 347);
            this.Controls.Add(this.text_Camera_send_port);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam Client";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		
		private bool connected = false;
		
		TcpClient myclient;
		MemoryStream ms;
		NetworkStream myns;
		BinaryWriter  mysw;
		Thread myth;
		TcpListener mytcpl;
        NetworkStream ns;
		Socket mysocket;


		private void Form1_Load(object sender, System.EventArgs e)
		{
            
            // Video Thread
			myth= new Thread  (new System.Threading .ThreadStart(Start_Receiving_Video_Conference)); // Start Thread Session
            myth.IsBackground = true;
            myth.Start (); // Start Receiveing Camera
		}

		private void Start_Receiving_Video_Conference()
		{
			try
			{

				// Open The Port
				mytcpl = new TcpListener (int.Parse(text_Camera_send_port.Text));	
				mytcpl.Start ();						 // Start Listening on That Port

    				while (true)
					{
                        try
                        {
                            mysocket = mytcpl.AcceptSocket();		 // Accept Any Request From Client and Start a Session
                            ns = new NetworkStream(mysocket);	 // Receives The Binary Data From Port
                           
                        }
                        catch(Exception){}
					}			
			}
            catch (Exception) {  } 
		}
		
		private void Start_Sending_Video_Conference(string remote_IP,int port_number)
		{
			try
			{
				ms = new MemoryStream();// Store it in Binary Array as Stream
				pictureBox1.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
				byte[] arrImage = ms.GetBuffer();
				myclient = new TcpClient (remote_IP,port_number);//Connecting with server
				myns = myclient.GetStream ();
				mysw = new BinaryWriter (myns);
				mysw.Write(arrImage);//send the stream to above address
				ms.Close();
				mysw.Close ();
				myns.Close ();
				myclient.Close ();
			}
			catch (Exception)
			{
			}
		}

		

		
		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				
				mytcpl.Stop ();
                myth.Abort();

			}
			catch(Exception){}
		}		
		

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.WebCamCapture.TimeToCapture_milliseconds = 1;
			this.WebCamCapture.Start(0);
			Capturing.Enabled = true;

		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.WebCamCapture.Stop();
			Capturing.Enabled = false;
		}

		private void Capturing_Tick(object sender, System.EventArgs e)
		{
		Start_Sending_Video_Conference(text_IP.Text,int.Parse(text_Camera_send_port.Text));
		}

		private void WebCamCapture_ImageCaptured(object source, WebCam_Capture.WebcamEventArgs e)
		{
		this.pictureBox1.Image = e.WebCamImage;
		}

        
	}
}
