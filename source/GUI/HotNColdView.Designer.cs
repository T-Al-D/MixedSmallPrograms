namespace GUI
{
    partial class HotNColdView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotNColdView));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.HotNColdListBox = new System.Windows.Forms.ListBox();
            this.ExplanationLbl1 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.NumInputBox = new System.Windows.Forms.TextBox();
            this.ExplanationLbl2 = new System.Windows.Forms.Label();
            this.SecondMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.ActionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.ExitBtn.Location = new System.Drawing.Point(147, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(68, 38);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.MistyRose;
            this.ReturnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ReturnBtn.FlatAppearance.BorderSize = 3;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReturnBtn.ForeColor = System.Drawing.Color.Red;
            this.ReturnBtn.Location = new System.Drawing.Point(12, 12);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(115, 38);
            this.ReturnBtn.TabIndex = 9;
            this.ReturnBtn.Text = "<- Go Back !";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // HotNColdListBox
            // 
            this.HotNColdListBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HotNColdListBox.FormattingEnabled = true;
            this.HotNColdListBox.ItemHeight = 19;
            this.HotNColdListBox.Location = new System.Drawing.Point(483, 12);
            this.HotNColdListBox.Name = "HotNColdListBox";
            this.HotNColdListBox.Size = new System.Drawing.Size(367, 498);
            this.HotNColdListBox.TabIndex = 11;
            // 
            // ExplanationLbl1
            // 
            this.ExplanationLbl1.AutoSize = true;
            this.ExplanationLbl1.BackColor = System.Drawing.Color.Navy;
            this.ExplanationLbl1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExplanationLbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExplanationLbl1.Location = new System.Drawing.Point(12, 68);
            this.ExplanationLbl1.Name = "ExplanationLbl1";
            this.ExplanationLbl1.Size = new System.Drawing.Size(440, 88);
            this.ExplanationLbl1.TabIndex = 12;
            this.ExplanationLbl1.Text = " 1st Method: give the Computer a number to guess !\r\n2nd Method: computer gives nu" +
    "mber und you have to guess!\r\nIf you contine with the 2nd Method you can first cl" +
    "ick start\r\nwithout number input.";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearBtn.FlatAppearance.BorderSize = 3;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Location = new System.Drawing.Point(208, 477);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(139, 33);
            this.ClearBtn.TabIndex = 15;
            this.ClearBtn.Text = "clear listBox";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Honeydew;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartBtn.FlatAppearance.BorderSize = 3;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.StartBtn.Location = new System.Drawing.Point(12, 477);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(167, 33);
            this.StartBtn.TabIndex = 14;
            this.StartBtn.Text = "input and start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // NumInputBox
            // 
            this.NumInputBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumInputBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumInputBox.Location = new System.Drawing.Point(12, 422);
            this.NumInputBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumInputBox.MaxLength = 6;
            this.NumInputBox.Name = "NumInputBox";
            this.NumInputBox.Size = new System.Drawing.Size(167, 27);
            this.NumInputBox.TabIndex = 13;
            this.NumInputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // ExplanationLbl2
            // 
            this.ExplanationLbl2.AutoSize = true;
            this.ExplanationLbl2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ExplanationLbl2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExplanationLbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExplanationLbl2.Location = new System.Drawing.Point(12, 172);
            this.ExplanationLbl2.Name = "ExplanationLbl2";
            this.ExplanationLbl2.Size = new System.Drawing.Size(296, 22);
            this.ExplanationLbl2.TabIndex = 16;
            this.ExplanationLbl2.Text = "Please input number between 0 an 100 !";
            // 
            // SecondMethodCheckBox
            // 
            this.SecondMethodCheckBox.AutoSize = true;
            this.SecondMethodCheckBox.BackColor = System.Drawing.Color.DarkOrchid;
            this.SecondMethodCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondMethodCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SecondMethodCheckBox.Location = new System.Drawing.Point(12, 339);
            this.SecondMethodCheckBox.Name = "SecondMethodCheckBox";
            this.SecondMethodCheckBox.Size = new System.Drawing.Size(289, 46);
            this.SecondMethodCheckBox.TabIndex = 17;
            this.SecondMethodCheckBox.Text = "if this box is checked, the 2nd Method\r\nis active, else the 1st Method !";
            this.SecondMethodCheckBox.UseVisualStyleBackColor = false;
            // 
            // ActionLbl
            // 
            this.ActionLbl.AutoSize = true;
            this.ActionLbl.BackColor = System.Drawing.Color.Blue;
            this.ActionLbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActionLbl.ForeColor = System.Drawing.Color.White;
            this.ActionLbl.Location = new System.Drawing.Point(12, 238);
            this.ActionLbl.Name = "ActionLbl";
            this.ActionLbl.Size = new System.Drawing.Size(102, 19);
            this.ActionLbl.TabIndex = 18;
            this.ActionLbl.Text = "Next Action ...";
            // 
            // HotNColdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(867, 523);
            this.Controls.Add(this.ActionLbl);
            this.Controls.Add(this.SecondMethodCheckBox);
            this.Controls.Add(this.ExplanationLbl2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.NumInputBox);
            this.Controls.Add(this.ExplanationLbl1);
            this.Controls.Add(this.HotNColdListBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotNColdView";
            this.Text = "HotNColdView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ExitBtn;
        private Button ReturnBtn;
        private ListBox HotNColdListBox;
        private Label ExplanationLbl1;
        private Button ClearBtn;
        private Button StartBtn;
        private TextBox NumInputBox;
        private Label ExplanationLbl2;
        private CheckBox SecondMethodCheckBox;
        private Label ActionLbl;
    }
}