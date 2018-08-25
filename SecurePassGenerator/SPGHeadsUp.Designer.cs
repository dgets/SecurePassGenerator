namespace SecurePassGenerator
{
    partial class PWGMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxCharOpts = new System.Windows.Forms.GroupBox();
            this.clbCharOpts = new System.Windows.Forms.CheckedListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblPWField = new System.Windows.Forms.Label();
            this.gbxCharOpts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(393, 89);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Damo\'s Secure/Random Password Generator";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // gbxCharOpts
            // 
            this.gbxCharOpts.Controls.Add(this.clbCharOpts);
            this.gbxCharOpts.Location = new System.Drawing.Point(27, 101);
            this.gbxCharOpts.Name = "gbxCharOpts";
            this.gbxCharOpts.Size = new System.Drawing.Size(200, 165);
            this.gbxCharOpts.TabIndex = 1;
            this.gbxCharOpts.TabStop = false;
            this.gbxCharOpts.Text = "Character Options";
            // 
            // clbCharOpts
            // 
            this.clbCharOpts.FormattingEnabled = true;
            this.clbCharOpts.Location = new System.Drawing.Point(6, 19);
            this.clbCharOpts.Name = "clbCharOpts";
            this.clbCharOpts.Size = new System.Drawing.Size(188, 109);
            this.clbCharOpts.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(233, 120);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(166, 146);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // lblPWField
            // 
            this.lblPWField.AutoSize = true;
            this.lblPWField.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWField.Location = new System.Drawing.Point(24, 269);
            this.lblPWField.Name = "lblPWField";
            this.lblPWField.Size = new System.Drawing.Size(161, 15);
            this.lblPWField.TabIndex = 3;
            this.lblPWField.Text = "Your New Password Here";
            this.lblPWField.Click += new System.EventHandler(this.lblPWField_Click);
            // 
            // PWGMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 340);
            this.Controls.Add(this.lblPWField);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.gbxCharOpts);
            this.Controls.Add(this.lblTitle);
            this.Name = "PWGMain";
            this.Text = "Damo\'s Secure PWGen";
            this.gbxCharOpts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxCharOpts;
        private System.Windows.Forms.CheckedListBox clbCharOpts;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblPWField;
    }
}

