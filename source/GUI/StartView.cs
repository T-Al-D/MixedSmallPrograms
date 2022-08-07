namespace GUI
{
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void diamondBtn_Click(object sender, EventArgs e)
        {
            DiamondView diamondView = new DiamondView();
            diamondView.Show();
            Visible = false;
        }
    }
}