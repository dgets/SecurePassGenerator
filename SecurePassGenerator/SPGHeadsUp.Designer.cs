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
            this.lblCharNums = new System.Windows.Forms.Label();
            this.nudCharNums = new System.Windows.Forms.NumericUpDown();
            this.clbCharOpts = new System.Windows.Forms.CheckedListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblPWField = new System.Windows.Forms.Label();
            this.tbxPWField = new System.Windows.Forms.TextBox();
            this.gbxCharOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharNums)).BeginInit();
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
            // 
            // gbxCharOpts
            // 
            this.gbxCharOpts.Controls.Add(this.lblCharNums);
            this.gbxCharOpts.Controls.Add(this.nudCharNums);
            this.gbxCharOpts.Controls.Add(this.clbCharOpts);
            this.gbxCharOpts.Location = new System.Drawing.Point(27, 101);
            this.gbxCharOpts.Name = "gbxCharOpts";
            this.gbxCharOpts.Size = new System.Drawing.Size(200, 165);
            this.gbxCharOpts.TabIndex = 1;
            this.gbxCharOpts.TabStop = false;
            this.gbxCharOpts.Text = "Character Options";
            // 
            // lblCharNums
            // 
            this.lblCharNums.AutoSize = true;
            this.lblCharNums.Location = new System.Drawing.Point(6, 136);
            this.lblCharNums.Name = "lblCharNums";
            this.lblCharNums.Size = new System.Drawing.Size(130, 13);
            this.lblCharNums.TabIndex = 4;
            this.lblCharNums.Text = "Characters in Passphrase:";
            // 
            // nudCharNums
            // 
            this.nudCharNums.Location = new System.Drawing.Point(139, 134);
            this.nudCharNums.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudCharNums.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCharNums.Name = "nudCharNums";
            this.nudCharNums.Size = new System.Drawing.Size(55, 20);
            this.nudCharNums.TabIndex = 3;
            this.nudCharNums.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // clbCharOpts
            // 
            this.clbCharOpts.CheckOnClick = true;
            this.clbCharOpts.FormattingEnabled = true;
            this.clbCharOpts.Location = new System.Drawing.Point(6, 19);
            this.clbCharOpts.Name = "clbCharOpts";
            this.clbCharOpts.Size = new System.Drawing.Size(188, 109);
            this.clbCharOpts.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(233, 101);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(166, 165);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_OnClick);
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
            // 
            // tbxPWField
            // 
            this.tbxPWField.Location = new System.Drawing.Point(27, 288);
            this.tbxPWField.MaxLength = 255;
            this.tbxPWField.Name = "tbxPWField";
            this.tbxPWField.ReadOnly = true;
            this.tbxPWField.Size = new System.Drawing.Size(372, 20);
            this.tbxPWField.TabIndex = 4;
            this.tbxPWField.Text = "Your new password will soon be here";
            this.tbxPWField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PWGMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 340);
            this.Controls.Add(this.tbxPWField);
            this.Controls.Add(this.lblPWField);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.gbxCharOpts);
            this.Controls.Add(this.lblTitle);
            this.Name = "PWGMain";
            this.Text = "Damo\'s Secure PWGen";
            this.gbxCharOpts.ResumeLayout(false);
            this.gbxCharOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharNums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxCharOpts;
        private System.Windows.Forms.CheckedListBox clbCharOpts;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblPWField;
        private System.Windows.Forms.Label lblCharNums;
        private System.Windows.Forms.NumericUpDown nudCharNums;
        private System.Windows.Forms.TextBox tbxPWField;
    }
}

