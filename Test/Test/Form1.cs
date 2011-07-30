using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Test
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolTip toolTip2;
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

		private void ActionHandler( string n )
		{
			if(MessageBox.Show( "Nisse", n, MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes)
			{
				if(button.Text.Equals("nisse"))
				{
					button.Text = "no nisse";
				}
				else
				{
					button.Text = "nisse";
				}
			}
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
			this.button = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(32, 16);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(96, 24);
			this.button.TabIndex = 0;
			this.button.Text = "tryck";
			this.toolTip2.SetToolTip(this.button, "Klicka här");
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(160, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 24);
			this.button2.TabIndex = 1;
			this.button2.Text = "stäng";
			this.toolTip1.SetToolTip(this.button2, "Klicka för att stänga");
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 116);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

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

		private void button_Click(object sender, System.EventArgs e)
		{
			ActionHandler( "nisse" );
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
