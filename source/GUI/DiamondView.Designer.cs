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
            this.returnBtn = new System.Windows.Forms.Button();
            this.diamondStartBtn = new System.Windows.Forms.Button();
            this.InputIsTotalSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.diamondInstructionLbl = new System.Windows.Forms.Label();
            this.diamodListBox = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.NumInputBox.Name = "NumInputBox";
            this.NumInputBox.Size = new System.Drawing.Size(167, 26);
            this.NumInputBox.TabIndex = 0;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.MistyRose;
            this.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.returnBtn.FlatAppearance.BorderSize = 3;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.ForeColor = System.Drawing.Color.Red;
            this.returnBtn.Location = new System.Drawing.Point(12, 12);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(115, 38);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "<- Go Back !";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // diamondStartBtn
            // 
            this.diamondStartBtn.BackColor = System.Drawing.Color.Honeydew;
            this.diamondStartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diamondStartBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.diamondStartBtn.FlatAppearance.BorderSize = 3;
            this.diamondStartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamondStartBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.diamondStartBtn.Location = new System.Drawing.Point(12, 464);
            this.diamondStartBtn.Name = "diamondStartBtn";
            this.diamondStartBtn.Size = new System.Drawing.Size(167, 33);
            this.diamondStartBtn.TabIndex = 2;
            this.diamondStartBtn.Text = "input and start";
            this.diamondStartBtn.UseVisualStyleBackColor = false;
            this.diamondStartBtn.Click += new System.EventHandler(this.diamondStartBtn_Click);
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
            // diamondInstructionLbl
            // 
            this.diamondInstructionLbl.AutoSize = true;
            this.diamondInstructionLbl.BackColor = System.Drawing.SystemColors.Desktop;
            this.diamondInstructionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diamondInstructionLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamondInstructionLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.diamondInstructionLbl.Location = new System.Drawing.Point(12, 83);
            this.diamondInstructionLbl.Name = "diamondInstructionLbl";
            this.diamondInstructionLbl.Size = new System.Drawing.Size(362, 97);
            this.diamondInstructionLbl.TabIndex = 4;
            this.diamondInstructionLbl.Text = resources.GetString("diamondInstructionLbl.Text");
            // 
            // diamodListBox
            // 
            this.diamodListBox.FormattingEnabled = true;
            this.diamodListBox.ItemHeight = 19;
            this.diamodListBox.Location = new System.Drawing.Point(414, 31);
            this.diamodListBox.Name = "diamodListBox";
            this.diamodListBox.Size = new System.Drawing.Size(623, 479);
            this.diamodListBox.TabIndex = 5;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearBtn.FlatAppearance.BorderSize = 3;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(208, 464);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(139, 33);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "clear listBox";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input number between 0 and 40 !";
            // 
            // DiamondView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1061, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.diamodListBox);
            this.Controls.Add(this.diamondInstructionLbl);
            this.Controls.Add(this.InputIsTotalSizeCheckBox);
            this.Controls.Add(this.diamondStartBtn);
            this.Controls.Add(this.returnBtn);
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
        private Button returnBtn;
        private Button diamondStartBtn;
        private CheckBox InputIsTotalSizeCheckBox;
        private Label diamondInstructionLbl;
        private ListBox diamodListBox;
        private Button clearBtn;
        private Label label1;
    }
}