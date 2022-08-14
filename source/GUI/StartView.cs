namespace GUI
{
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //Important to properly close the Application and close all Threads
            Application.ExitThread();
            Application.Exit();
            Environment.Exit(0);
        }

        private void DiamondBtn_Click(object sender, EventArgs e)
        {
            DiamondView diamondView = new DiamondView();
            diamondView.Show();
            Visible = false;
        }

        private void HotNColdBtn_Click(object sender, EventArgs e)
        {
            HotNColdView hotNColdView = new HotNColdView();
            hotNColdView.Show();
            Visible = false;
        }
    }
}