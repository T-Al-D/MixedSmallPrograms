using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HotNColdView : Form
    {
        public HotNColdView()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var startView = new StartView();
            startView.Show();
            Visible = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Important to properly close the Application and close all Threads
            Application.ExitThread();
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
