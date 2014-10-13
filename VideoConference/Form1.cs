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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox text_Voice_SendingPort;
        private System.Windows.Forms.TextBox text_IP;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
        private WebCam_Capture.WebCamCapture webCamCapture1;
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text_Voice_SendingPort = new System.Windows.Forms.TextBox();
            this.text_IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Capturing = new System.Windows.Forms.Timer(this.components);
            this.text_Camera_send_port = new System.Windows.Forms.TextBox();
            this.WebCamCapture = new WebCam_Capture.WebCamCapture();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(485, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Talking";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(580, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop Voice";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_Voice_SendingPort
            // 
            this.text_Voice_SendingPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Voice_SendingPort.Location = new System.Drawing.Point(418, 345);
            this.text_Voice_SendingPort.Name = "text_Voice_SendingPort";
            this.text_Voice_SendingPort.Size = new System.Drawing.Size(61, 20);
            this.text_Voice_SendingPort.TabIndex = 12;
            this.text_Voice_SendingPort.Text = "9000";
            // 
            // text_IP
            // 
            this.text_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_IP.Location = new System.Drawing.Point(559, 15);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(112, 20);
            this.text_IP.TabIndex = 10;
            this.text_IP.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(354, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Voice Port";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(462, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Talk With (IP)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "My Camera";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(348, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Remote Camera";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(354, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Video Port";
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(580, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 24);
            this.button3.TabIndex = 26;
            this.button3.Text = "Stop Camera";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(485, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 24);
            this.button4.TabIndex = 25;
            this.button4.Text = "Start Camera";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Capturing
            // 
            this.Capturing.Tick += new System.EventHandler(this.Capturing_Tick);
            // 
            // text_Camera_send_port
            // 
            this.text_Camera_send_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Camera_send_port.Location = new System.Drawing.Point(418, 319);
            this.text_Camera_send_port.Name = "text_Camera_send_port";
            this.text_Camera_send_port.Size = new System.Drawing.Size(61, 20);
            this.text_Camera_send_port.TabIndex = 27;
            this.text_Camera_send_port.Text = "8000";
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(351, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
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
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(681, 380);
            this.Controls.Add(this.text_Camera_send_port);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Voice_SendingPort);
            this.Controls.Add(this.text_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Conference";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
		#region Voice_In()
		private void Voice_In()
		{
			byte[] br;
			r.Bind(new IPEndPoint(IPAddress.Any, int.Parse(text_Voice_SendingPort.Text)));
			while (true)
				{
				br = new byte[16384];
				r.Receive(br);
				m_Fifo.Write(br, 0, br.Length);
				}
		}
		#endregion
		#region Voice_Out()
		
		private void Voice_Out(IntPtr data, int size)
		{
            try
            {
                //for Recorder
                if (m_RecBuffer == null || m_RecBuffer.Length < size)
                    m_RecBuffer = new byte[size];
                System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size);
                //Microphone ==> data ==> m_RecBuffer ==> m_Fifo
                r.SendTo(m_RecBuffer, new IPEndPoint(IPAddress.Parse(text_IP.Text), int.Parse(text_Voice_SendingPort.Text)));
            }
            catch (Exception) { }
		}  
		
		#endregion


        
		//********************************************************************************//
		private WaveOutPlayer m_Player;
		private WaveInRecorder m_Recorder;
		private FifoStream m_Fifo = new FifoStream();
		private Socket r;
		private Thread t;
		private bool connected = false;
		private byte[] m_PlayBuffer;
		private byte[] m_RecBuffer;
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
            // Voice Thread
            r = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            t = new Thread(new ThreadStart(Voice_In));
            t.IsBackground = true;

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
                            pictureBox2.Image = Image.FromStream(ns);
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

		private void Start()
		{
			Stop();
			try
			{
                WaveFormat fmt = new WaveFormat(22050, 8, 1);
				m_Player = new WaveOutPlayer(0, fmt, 16384, 3, new BufferFillEventHandler(Filler));
				m_Recorder = new WaveInRecorder(-1, fmt, 16384, 3, new BufferDoneEventHandler(Voice_Out));
			}
			catch
			{
				Stop();
				throw;
			}
		}

		private void Stop()
		{
			if (m_Player != null)
				try
				{
                    m_Player.Dispose();
				}
				finally
				{
					m_Player = null;
				}
			if (m_Recorder != null)
				try
				{
                    m_Recorder.Dispose();
				}
				finally
				{
					m_Recorder = null;
				}
			m_Fifo.Flush(); // clear all pending data
		}

		private void Filler(IntPtr data, int size)
		{
			if (m_PlayBuffer == null || m_PlayBuffer.Length < size)
				m_PlayBuffer = new byte[size];
			if (m_Fifo.Length >= size)
				m_Fifo.Read(m_PlayBuffer, 0, size);
			else
				for (int i = 0; i < m_PlayBuffer.Length; i++)
					m_PlayBuffer[i] = 0;
			System.Runtime.InteropServices.Marshal.Copy(m_PlayBuffer, 0, data, size);
			// m_Fifo ==> m_PlayBuffer==> data ==> Speakers
		}
		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				
				mytcpl.Stop ();
				Stop();

                t.Abort();
                myth.Abort();

			}
			catch(Exception){}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Stop();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (connected == false)
			{
				t.Start();
				connected = true;
			}

			Start();
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
