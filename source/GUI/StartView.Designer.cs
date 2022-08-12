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
            this.diamondBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.exitLbl = new System.Windows.Forms.Label();
            this.hotNColdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diamondBtn
            // 
            this.diamondBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.diamondBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diamondBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.diamondBtn.FlatAppearance.BorderSize = 3;
            this.diamondBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamondBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diamondBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.diamondBtn.Location = new System.Drawing.Point(58, 84);
            this.diamondBtn.Name = "diamondBtn";
            this.diamondBtn.Size = new System.Drawing.Size(112, 41);
            this.diamondBtn.TabIndex = 0;
            this.diamondBtn.Text = "Diamond";
            this.diamondBtn.UseVisualStyleBackColor = false;
            this.diamondBtn.Click += new System.EventHandler(this.diamondBtn_Click);
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
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.FlatAppearance.BorderSize = 3;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.exitBtn.Location = new System.Drawing.Point(1050, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(68, 39);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
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
            // hotNColdBtn
            // 
            this.hotNColdBtn.BackColor = System.Drawing.Color.Cyan;
            this.hotNColdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotNColdBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.hotNColdBtn.FlatAppearance.BorderSize = 3;
            this.hotNColdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotNColdBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hotNColdBtn.ForeColor = System.Drawing.Color.Black;
            this.hotNColdBtn.Location = new System.Drawing.Point(204, 84);
            this.hotNColdBtn.Name = "hotNColdBtn";
            this.hotNColdBtn.Size = new System.Drawing.Size(112, 41);
            this.hotNColdBtn.TabIndex = 4;
            this.hotNColdBtn.Text = "HotNCold";
            this.hotNColdBtn.UseVisualStyleBackColor = false;
            this.hotNColdBtn.Click += new System.EventHandler(this.hotNColdBtn_Click);
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1130, 465);
            this.Controls.Add(this.hotNColdBtn);
            this.Controls.Add(this.exitLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diamondBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartView";
            this.Text = "MixedSmallPrograms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button diamondBtn;
        private Label label1;
        private Button exitBtn;
        private Label exitLbl;
        private Button hotNColdBtn;
    }
}