namespace GUI
{
    partial class StartView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartView));
            this.DiamondBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.exitLbl = new System.Windows.Forms.Label();
            this.HotNColdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DiamondBtn
            // 
            this.DiamondBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiamondBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiamondBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DiamondBtn.FlatAppearance.BorderSize = 3;
            this.DiamondBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiamondBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiamondBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.DiamondBtn.Location = new System.Drawing.Point(58, 84);
            this.DiamondBtn.Name = "DiamondBtn";
            this.DiamondBtn.Size = new System.Drawing.Size(112, 41);
            this.DiamondBtn.TabIndex = 0;
            this.DiamondBtn.Text = "Diamond";
            this.DiamondBtn.UseVisualStyleBackColor = false;
            this.DiamondBtn.Click += new System.EventHandler(this.DiamondBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which (mini) program would you like to try out ?";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitBtn.FlatAppearance.BorderSize = 3;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ExitBtn.Location = new System.Drawing.Point(1050, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(68, 39);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.exitLbl.BackColor = System.Drawing.Color.Bisque;
            this.exitLbl.Location = new System.Drawing.Point(970, 54);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(148, 45);
            this.exitLbl.TabIndex = 3;
            this.exitLbl.Text = "Please use the EXIT button,\r\nto make sure no processes\r\nor threads are remaining " +
    "!";
            // 
            // HotNColdBtn
            // 
            this.HotNColdBtn.BackColor = System.Drawing.Color.Cyan;
            this.HotNColdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HotNColdBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.HotNColdBtn.FlatAppearance.BorderSize = 3;
            this.HotNColdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotNColdBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HotNColdBtn.ForeColor = System.Drawing.Color.Black;
            this.HotNColdBtn.Location = new System.Drawing.Point(204, 84);
            this.HotNColdBtn.Name = "HotNColdBtn";
            this.HotNColdBtn.Size = new System.Drawing.Size(112, 41);
            this.HotNColdBtn.TabIndex = 4;
            this.HotNColdBtn.Text = "HotNCold";
            this.HotNColdBtn.UseVisualStyleBackColor = false;
            this.HotNColdBtn.Click += new System.EventHandler(this.HotNColdBtn_Click);
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1130, 465);
            this.Controls.Add(this.HotNColdBtn);
            this.Controls.Add(this.exitLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiamondBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartView";
            this.Text = "MixedSmallPrograms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DiamondBtn;
        private Label label1;
        private Button ExitBtn;
        private Label exitLbl;
        private Button HotNColdBtn;
    }
}