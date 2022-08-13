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
            this.exitBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.hotNColdListBox = new System.Windows.Forms.ListBox();
            this.explanationLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.numInputBox = new System.Windows.Forms.TextBox();
            this.explanation2 = new System.Windows.Forms.Label();
            this.secondMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.exitBtn.Location = new System.Drawing.Point(147, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(68, 38);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.MistyRose;
            this.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.returnBtn.FlatAppearance.BorderSize = 3;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnBtn.ForeColor = System.Drawing.Color.Red;
            this.returnBtn.Location = new System.Drawing.Point(12, 12);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(115, 38);
            this.returnBtn.TabIndex = 9;
            this.returnBtn.Text = "<- Go Back !";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // hotNColdListBox
            // 
            this.hotNColdListBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hotNColdListBox.FormattingEnabled = true;
            this.hotNColdListBox.ItemHeight = 19;
            this.hotNColdListBox.Location = new System.Drawing.Point(483, 12);
            this.hotNColdListBox.Name = "hotNColdListBox";
            this.hotNColdListBox.Size = new System.Drawing.Size(367, 479);
            this.hotNColdListBox.TabIndex = 11;
            // 
            // explanationLbl
            // 
            this.explanationLbl.AutoSize = true;
            this.explanationLbl.BackColor = System.Drawing.Color.Navy;
            this.explanationLbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.explanationLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.explanationLbl.Location = new System.Drawing.Point(12, 68);
            this.explanationLbl.Name = "explanationLbl";
            this.explanationLbl.Size = new System.Drawing.Size(440, 44);
            this.explanationLbl.TabIndex = 12;
            this.explanationLbl.Text = " 1st Method: give the Computer a number to guess !\r\n2nd Method: computer gives nu" +
    "mber und you have to guess!";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clearBtn.FlatAppearance.BorderSize = 3;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(208, 458);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(139, 33);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "clear listBox";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Honeydew;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.startBtn.FlatAppearance.BorderSize = 3;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.startBtn.Location = new System.Drawing.Point(12, 458);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(167, 33);
            this.startBtn.TabIndex = 14;
            this.startBtn.Text = "input and start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // numInputBox
            // 
            this.numInputBox.BackColor = System.Drawing.SystemColors.Window;
            this.numInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numInputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numInputBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numInputBox.Location = new System.Drawing.Point(12, 403);
            this.numInputBox.Margin = new System.Windows.Forms.Padding(4);
            this.numInputBox.Name = "numInputBox";
            this.numInputBox.Size = new System.Drawing.Size(167, 27);
            this.numInputBox.TabIndex = 13;
            // 
            // explanation2
            // 
            this.explanation2.AutoSize = true;
            this.explanation2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.explanation2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.explanation2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.explanation2.Location = new System.Drawing.Point(12, 128);
            this.explanation2.Name = "explanation2";
            this.explanation2.Size = new System.Drawing.Size(296, 22);
            this.explanation2.TabIndex = 16;
            this.explanation2.Text = "Please input number between 0 an 100 !";
            // 
            // secondMethodCheckBox
            // 
            this.secondMethodCheckBox.AutoSize = true;
            this.secondMethodCheckBox.BackColor = System.Drawing.Color.DarkOrchid;
            this.secondMethodCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondMethodCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.secondMethodCheckBox.Location = new System.Drawing.Point(12, 320);
            this.secondMethodCheckBox.Name = "secondMethodCheckBox";
            this.secondMethodCheckBox.Size = new System.Drawing.Size(289, 46);
            this.secondMethodCheckBox.TabIndex = 17;
            this.secondMethodCheckBox.Text = "if this box is checked, the 2nd Method\r\nis active, else the 1st Method !";
            this.secondMethodCheckBox.UseVisualStyleBackColor = false;
            // 
            // HotNColdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(867, 507);
            this.Controls.Add(this.secondMethodCheckBox);
            this.Controls.Add(this.explanation2);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.numInputBox);
            this.Controls.Add(this.explanationLbl);
            this.Controls.Add(this.hotNColdListBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.returnBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotNColdView";
            this.Text = "HotNColdView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitBtn;
        private Button returnBtn;
        private ListBox hotNColdListBox;
        private Label explanationLbl;
        private Button clearBtn;
        private Button startBtn;
        private TextBox numInputBox;
        private Label explanation2;
        private CheckBox secondMethodCheckBox;
    }
}