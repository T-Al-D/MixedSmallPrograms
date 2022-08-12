using MixedLibrary;

namespace GUI
{
    public partial class HotNColdView : Form
    {
        private int _goalNumber { get; set; }

        private string _stringRow { get; set; } = "";

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

        private void startBtn_Click(object sender, EventArgs e)
        {
            short lowerBound = 0;
            short upperBound = 100;
            short prevGuessedNum, nextGuessedNum;

            // get a valid start
            _goalNumber = Check.CheckValidNumber(numInputBox.Text);
            if (_goalNumber != -1 && _goalNumber < 101)
            {
                if (!secondMethodCheckBox.Checked)
                {
                    do
                    {
                        prevGuessedNum = (short)NumCreator.GetRandomNumWithinBound(lowerBound, upperBound);
                        nextGuessedNum = (short)NumCreator.GetRandomNumWithinBound(lowerBound, upperBound);
                    } while (prevGuessedNum == nextGuessedNum);
                }
                else
                {
                    //TODO 
                    nextGuessedNum = 10;
                    prevGuessedNum = 30;
                }

                // main loop
                while (nextGuessedNum != _goalNumber)
                {
                    short tempPrevGuessNum = prevGuessedNum;
                    prevGuessedNum = nextGuessedNum;

                    if (true)
                    {

                    }
                    else
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Input is not within the given bounds!");
            }
        }
    }
}
