using MixedLibrary;

namespace GUI
{
    public partial class HotNColdView : Form
    {
        int _goalNum { get; set; }

        string _stringRow { get; set; } = "";

        public HotNColdView() => InitializeComponent();

        void returnBtn_Click(object sender, EventArgs e)
        {
            var startView = new StartView();
            startView.Show();
            Visible = false;
        }

        void exitBtn_Click(object sender, EventArgs e)
        {
            // Important to properly close the Application and close all Threads
            Application.ExitThread();
            Application.Exit();
            Environment.Exit(0);
        }

        private int GetValidUserInputWithinBounds(int lowerBound, int upperBound)
        {
            int guessedNumber = Check.CheckValidNumber(numInputBox.Text);
            if (guessedNumber < lowerBound || guessedNumber > upperBound || guessedNumber == int.MinValue)
            {
                MessageBox.Show(" Please input valid input between the given bounds!");
                numInputBox.Text = "";
            }
            return guessedNumber;
        }

        int CalculateNewBound(int prevGuess, int nextGuess, int oldBound, bool boundIsMinimum)
        {
            int newBound;

            if (boundIsMinimum)
            {
                newBound = nextGuess + (Math.Abs(prevGuess - nextGuess) / 2);

                // making sure the lowerBound dosen´t get smaller (closer to 0) and or bigger than goalNumber
                if (newBound < oldBound || newBound > _goalNum)
                {
                    newBound = oldBound;
                }
            }
            else
            {
                newBound = nextGuess + (Math.Abs(prevGuess - nextGuess) / 2);

                // making sure the upperBound dosen´t get bigger (closer to 100) or smaller than goalNumber
                if (newBound > oldBound || newBound < _goalNum)
                {
                    newBound = oldBound;
                }
            }

            return newBound;
        }


        private void MainGuessingGame(int prevGuessedNum, int nextGuessedNum, int lowerBound, int upperBound)
        {
            // in case the golNumber got guessed in the first guess
            if (prevGuessedNum != _goalNum)
            {
                short rounds = 0;
                // main loop
                while (nextGuessedNum != _goalNum)
                {
                    // if difference to the previous guess was smaller than the next guess,
                    // then COLD, else HOT !
                    // calculations have to done in reverse (HOT and COLD), therefor sometime parameters between next and prev
                    // are switched for everything to function
                    if (Math.Abs(_goalNum - prevGuessedNum) < Math.Abs(_goalNum - nextGuessedNum))
                    {
                        _stringRow = $"-> COLD {nextGuessedNum}";

                        if (prevGuessedNum > nextGuessedNum)
                        {
                            lowerBound = CalculateNewBound(prevGuessedNum, nextGuessedNum, lowerBound, true);
                        }
                        else
                        {
                            upperBound = CalculateNewBound(nextGuessedNum, prevGuessedNum, upperBound, false);
                        }
                    }
                    else
                    {
                        _stringRow = $"-> HOT {nextGuessedNum}";

                        if (prevGuessedNum < nextGuessedNum)
                        {
                            lowerBound = CalculateNewBound(nextGuessedNum, prevGuessedNum, lowerBound, true);
                        }
                        else
                        {
                            upperBound = CalculateNewBound(prevGuessedNum, nextGuessedNum, upperBound, false);
                        }
                    }

                    // routine that has to be done regardless
                    hotNColdListBox.Items.Add(_stringRow);
                    hotNColdListBox.Items.Add($"Next Number between {lowerBound} and {upperBound} !");
                    _stringRow = "";
                    rounds++;
                    prevGuessedNum = nextGuessedNum;
                    if (!secondMethodCheckBox.Checked)
                    {
                        nextGuessedNum = NumCreator.GetRandomNumWithinBound(lowerBound, upperBound);
                    }
                    else
                    {
                        nextGuessedNum = GetValidUserInputWithinBounds(lowerBound, upperBound + 1);
                    }
                }

                _stringRow = $" The goalNumber was guessed in {rounds} Rounds!";
                hotNColdListBox.Items.Add(_stringRow);
                hotNColdListBox.Items.Add("");
            }
            else
            {
                hotNColdListBox.Items.Add("Lucky, first guess was the goalNumber!");
            }
        }

        // this method mostly checks if the beginning values are correct or else the MainGuessingGame will not even start
        void startBtn_Click(object sender, EventArgs e)
        {
            int lowerBound = 0;
            int upperBound = 100;
            int prevGuessedNum, nextGuessedNum;

            // (valid) input
            if (!secondMethodCheckBox.Checked)
            {
                _goalNum = Check.CheckValidNumber(numInputBox.Text);
            }
            else
            {
                _goalNum = NumCreator.GetRandomNumWithinBound(0, 100);
            }

            if (_goalNum > -1 && _goalNum < 101)
            {
                if (!secondMethodCheckBox.Checked)
                {
                    actionLbl.Text = "Computer will guess number!";
                    do
                    {
                        prevGuessedNum = (short)NumCreator.GetRandomNumWithinBound(lowerBound, upperBound);
                        nextGuessedNum = (short)NumCreator.GetRandomNumWithinBound(lowerBound, upperBound);
                    } while (prevGuessedNum == nextGuessedNum);
                }
                else
                {

                    actionLbl.Text = "Please input your 1st guess !";
                    prevGuessedNum = GetValidUserInputWithinBounds(0, 101);
                    actionLbl.Text = "Please input your 2nd guess !";
                    nextGuessedNum = GetValidUserInputWithinBounds(0, 101);

                    if (prevGuessedNum == nextGuessedNum)
                    {
                        MessageBox.Show("Both guesses have to be different values!");
                        numInputBox.Text = "";
                        return;
                    }
                }

                hotNColdListBox.Items.Add($"First guess: {prevGuessedNum} !");
                hotNColdListBox.Items.Add($"First guess: {nextGuessedNum} !");

                MainGuessingGame(prevGuessedNum, nextGuessedNum, lowerBound, upperBound);
            }
            else
            {
                MessageBox.Show("Input is not within the given bounds!");
                numInputBox.Clear();
            }
        }

        void clearBtn_Click(object sender, EventArgs e) => hotNColdListBox.Items.Clear();
    }
}