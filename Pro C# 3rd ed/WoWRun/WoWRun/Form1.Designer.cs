namespace WoWRun
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
            this.radioScriptCraft = new System.Windows.Forms.RadioButton();
            this.radioVanilla = new System.Windows.Forms.RadioButton();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioScriptCraft
            // 
            this.radioScriptCraft.AutoSize = true;
            this.radioScriptCraft.Location = new System.Drawing.Point(15, 24);
            this.radioScriptCraft.Name = "radioScriptCraft";
            this.radioScriptCraft.Size = new System.Drawing.Size(74, 17);
            this.radioScriptCraft.TabIndex = 0;
            this.radioScriptCraft.TabStop = true;
            this.radioScriptCraft.Text = "ScriptCraft";
            this.radioScriptCraft.UseVisualStyleBackColor = true;
            this.radioScriptCraft.CheckedChanged += new System.EventHandler(this.radioScriptCraft_CheckedChanged);
            // 
            // radioVanilla
            // 
            this.radioVanilla.AutoSize = true;
            this.radioVanilla.Location = new System.Drawing.Point(15, 46);
            this.radioVanilla.Name = "radioVanilla";
            this.radioVanilla.Size = new System.Drawing.Size(87, 17);
            this.radioVanilla.TabIndex = 1;
            this.radioVanilla.TabStop = true;
            this.radioVanilla.Text = "Vanilla WoW";
            this.radioVanilla.UseVisualStyleBackColor = true;
            this.radioVanilla.CheckedChanged += new System.EventHandler(this.radioVanilla_CheckedChanged);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(179, 61);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioVanilla);
            this.groupBox.Controls.Add(this.radioScriptCraft);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(145, 71);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Realm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 96);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonRun);
            this.Name = "Form1";
            this.Text = "RunWoW";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioScriptCraft;
        private System.Windows.Forms.RadioButton radioVanilla;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

