namespace Learning3
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
            this.getTextBtn = new System.Windows.Forms.Button();
            this.showText = new System.Windows.Forms.Label();
            this.setText = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.testNumberBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getTextBtn
            // 
            this.getTextBtn.Location = new System.Drawing.Point(12, 12);
            this.getTextBtn.Name = "getTextBtn";
            this.getTextBtn.Size = new System.Drawing.Size(93, 23);
            this.getTextBtn.TabIndex = 1;
            this.getTextBtn.Text = "Give your text";
            this.getTextBtn.UseVisualStyleBackColor = true;
            this.getTextBtn.Click += new System.EventHandler(this.getTextBtn_Click);
            // 
            // showText
            // 
            this.showText.AutoSize = true;
            this.showText.Location = new System.Drawing.Point(141, 15);
            this.showText.Name = "showText";
            this.showText.Size = new System.Drawing.Size(54, 13);
            this.showText.TabIndex = 1;
            this.showText.Text = "Some text";
            // 
            // setText
            // 
            this.setText.Location = new System.Drawing.Point(144, 55);
            this.setText.Multiline = true;
            this.setText.Name = "setText";
            this.setText.Size = new System.Drawing.Size(224, 57);
            this.setText.TabIndex = 0;
            this.setText.TextChanged += new System.EventHandler(this.setText_TextChanged);
            this.setText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.setText_KeyPress);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(12, 89);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(93, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // testNumberBtn
            // 
            this.testNumberBtn.Location = new System.Drawing.Point(12, 54);
            this.testNumberBtn.Name = "testNumberBtn";
            this.testNumberBtn.Size = new System.Drawing.Size(93, 23);
            this.testNumberBtn.TabIndex = 2;
            this.testNumberBtn.Text = "Number testing";
            this.testNumberBtn.UseVisualStyleBackColor = true;
            this.testNumberBtn.Click += new System.EventHandler(this.testNumberBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 124);
            this.Controls.Add(this.testNumberBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.setText);
            this.Controls.Add(this.showText);
            this.Controls.Add(this.getTextBtn);
            this.Name = "Form1";
            this.Text = "Testing testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getTextBtn;
        private System.Windows.Forms.Label showText;
        private System.Windows.Forms.TextBox setText;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button testNumberBtn;
    }
}

