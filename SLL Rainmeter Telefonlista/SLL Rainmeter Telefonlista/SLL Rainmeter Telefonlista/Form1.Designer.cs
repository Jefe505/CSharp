namespace SLL_Rainmeter_Telefonlista
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab2ndline = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listaPersonal = new System.Windows.Forms.ListBox();
            this.listaHP = new System.Windows.Forms.ListBox();
            this.tab2ndline.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab2ndline
            // 
            this.tab2ndline.Controls.Add(this.tabPage1);
            this.tab2ndline.Controls.Add(this.tabPersonal);
            this.tab2ndline.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab2ndline.Location = new System.Drawing.Point(0, 48);
            this.tab2ndline.Name = "tab2ndline";
            this.tab2ndline.SelectedIndex = 0;
            this.tab2ndline.Size = new System.Drawing.Size(898, 406);
            this.tab2ndline.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listaHP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Helpdesk / 2nd Line";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPersonal
            // 
            this.tabPersonal.Controls.Add(this.listaPersonal);
            this.tabPersonal.Location = new System.Drawing.Point(4, 22);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonal.Size = new System.Drawing.Size(890, 380);
            this.tabPersonal.TabIndex = 1;
            this.tabPersonal.Text = "Personal";
            this.tabPersonal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Spara lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ändra post";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Skapa RM lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(799, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Stäng";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listaPersonal
            // 
            this.listaPersonal.FormattingEnabled = true;
            this.listaPersonal.Location = new System.Drawing.Point(0, 3);
            this.listaPersonal.Name = "listaPersonal";
            this.listaPersonal.Size = new System.Drawing.Size(888, 368);
            this.listaPersonal.TabIndex = 0;
            // 
            // listaHP
            // 
            this.listaHP.FormattingEnabled = true;
            this.listaHP.Location = new System.Drawing.Point(0, 4);
            this.listaHP.Name = "listaHP";
            this.listaHP.Size = new System.Drawing.Size(889, 368);
            this.listaHP.TabIndex = 0;
            this.listaHP.SelectedIndexChanged += new System.EventHandler(this.listaHP_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 454);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tab2ndline);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab2ndline.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPersonal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab2ndline;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPersonal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listaHP;
        private System.Windows.Forms.ListBox listaPersonal;
    }
}

