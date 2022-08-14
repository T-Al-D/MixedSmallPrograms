namespace GUI
{
    partial class DiamondView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiamondView));
            this.NumInputBox = new System.Windows.Forms.TextBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.InputIsTotalSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.DiamondInstructionLbl = new System.Windows.Forms.Label();
            this.DiamodListBox = new System.Windows.Forms.ListBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.InstructionLbl2 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumInputBox
            // 
            this.NumInputBox.BackColor = System.Drawing.SystemColors.Window;
            this.NumInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumInputBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumInputBox.Location = new System.Drawing.Point(12, 409);
            this.NumInputBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumInputBox.MaxLength = 4;
            this.NumInputBox.Name = "NumInputBox";
            this.NumInputBox.Size = new System.Drawing.Size(167, 26);
            this.NumInputBox.TabIndex = 0;
            this.NumInputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.MistyRose;
            this.ReturnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ReturnBtn.FlatAppearance.BorderSize = 3;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBtn.ForeColor = System.Drawing.Color.Red;
            this.ReturnBtn.Location = new System.Drawing.Point(12, 12);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(115, 38);
            this.ReturnBtn.TabIndex = 1;
            this.ReturnBtn.Text = "<- Go Back !";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Honeydew;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartBtn.FlatAppearance.BorderSize = 3;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.StartBtn.Location = new System.Drawing.Point(12, 464);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(167, 33);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "input and start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // InputIsTotalSizeCheckBox
            // 
            this.InputIsTotalSizeCheckBox.AutoSize = true;
            this.InputIsTotalSizeCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.InputIsTotalSizeCheckBox.Location = new System.Drawing.Point(12, 331);
            this.InputIsTotalSizeCheckBox.Name = "InputIsTotalSizeCheckBox";
            this.InputIsTotalSizeCheckBox.Size = new System.Drawing.Size(318, 42);
            this.InputIsTotalSizeCheckBox.TabIndex = 3;
            this.InputIsTotalSizeCheckBox.Text = "confirm if input is the total size\r\nof the diamond (only uneven numbers)";
            this.InputIsTotalSizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiamondInstructionLbl
            // 
            this.DiamondInstructionLbl.AutoSize = true;
            this.DiamondInstructionLbl.BackColor = System.Drawing.SystemColors.Desktop;
            this.DiamondInstructionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiamondInstructionLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiamondInstructionLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.DiamondInstructionLbl.Location = new System.Drawing.Point(12, 83);
            this.DiamondInstructionLbl.Name = "DiamondInstructionLbl";
            this.DiamondInstructionLbl.Size = new System.Drawing.Size(362, 97);
            this.DiamondInstructionLbl.TabIndex = 4;
            this.DiamondInstructionLbl.Text = resources.GetString("DiamondInstructionLbl.Text");
            // 
            // DiamodListBox
            // 
            this.DiamodListBox.FormattingEnabled = true;
            this.DiamodListBox.ItemHeight = 19;
            this.DiamodListBox.Location = new System.Drawing.Point(417, 12);
            this.DiamodListBox.Name = "DiamodListBox";
            this.DiamodListBox.Size = new System.Drawing.Size(623, 517);
            this.DiamodListBox.TabIndex = 5;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearBtn.FlatAppearance.BorderSize = 3;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Location = new System.Drawing.Point(208, 464);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(139, 33);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "clear listBox";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // InstructionLbl2
            // 
            this.InstructionLbl2.AutoSize = true;
            this.InstructionLbl2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InstructionLbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructionLbl2.ForeColor = System.Drawing.Color.IndianRed;
            this.InstructionLbl2.Location = new System.Drawing.Point(12, 195);
            this.InstructionLbl2.Name = "InstructionLbl2";
            this.InstructionLbl2.Size = new System.Drawing.Size(256, 19);
            this.InstructionLbl2.TabIndex = 7;
            this.InstructionLbl2.Text = "Input number between 0 and 42 !";
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
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // DiamondView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1061, 551);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.InstructionLbl2);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DiamodListBox);
            this.Controls.Add(this.DiamondInstructionLbl);
            this.Controls.Add(this.InputIsTotalSizeCheckBox);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.NumInputBox);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DiamondView";
            this.Text = "DiamondView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NumInputBox;
        private Button ReturnBtn;
        private Button StartBtn;
        private CheckBox InputIsTotalSizeCheckBox;
        private Label DiamondInstructionLbl;
        private ListBox DiamodListBox;
        private Button ClearBtn;
        private Label InstructionLbl2;
        private Button ExitBtn;
    }
}