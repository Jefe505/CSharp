namespace Learning5
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
            this.linkBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.folderTree = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkBtn
            // 
            this.linkBtn.Location = new System.Drawing.Point(12, 41);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(75, 23);
            this.linkBtn.TabIndex = 1;
            this.linkBtn.Text = "Open folder";
            this.linkBtn.UseVisualStyleBackColor = true;
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 70);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 2;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(12, 99);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // folderTree
            // 
            this.folderTree.Location = new System.Drawing.Point(93, 41);
            this.folderTree.Name = "folderTree";
            this.folderTree.Size = new System.Drawing.Size(264, 340);
            this.folderTree.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 393);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.folderTree);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.linkBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button linkBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TreeView folderTree;
        private System.Windows.Forms.TextBox textBox1;
    }
}

