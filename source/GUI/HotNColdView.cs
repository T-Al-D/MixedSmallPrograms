using MixedLibrary;

namespace GUI
{
    public partial class HotNColdView : Form
    {
        int _goalNum { get; set; }

        string _stringRow { get; set; } = "";

        public HotNColdView() => InitializeComponent();

        void ReturnBtn_Click(object sender, EventArgs e)
        {
            var startView = new StartView();
            startView.Show();
            Visible = false;
        }

        void ExitBtn_Click(object sender, EventArgs e)
        {
            // Important to properly close the Application and close all Threads
            Application.ExitThread();
            Application.Exit();
            Environment.Exit(0);
        }

        int GetValidUserInputWithinBounds(int lowerBound, int upperBound)
        {
            var guessedNumber = Check.CheckValidNumber(NumInputBox.Text);

            if (guessedNumber < lowerBound || guessedNumber > upperBound || guessedNumber == int.MinValue)
            {
                MessageBox.Show(" Please input valid input between the given bounds!");
                NumInputBox.Text = "";
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

        void StartGuessingGame()
        {
            var lowerBound = 0;
            var upperBound = 100;
            int prevGuessedNum, nextGuessedNum;

            // (valid) input
            if (!SecondMethodCheckBox.Checked)
            {
                _goalNum = Check.CheckValidNumber(NumInputBox.Text);
            }
            else
            {
                _goalNum = NumCreator.GetRandomNumWithinBound(0, 100);
            }

            if (_goalNum > -1 && _goalNum < 101)
            {
                if (!SecondMethodCheckBox.Checked)
                {
                    ActionLbl.Text = "Computer will guess number!";

                    do
                    {
                        prevGuessedNum = (short)NumCreator.GetRandomNumWithinBound(lowerBound, upperBound);
                        nextGuessedNum = (short)NumCreator.GetRandomNumWithinBound(lowerBound, upperBound);
                    } while (prevGuessedNum == nextGuessedNum);
                }
                else
                {
                    // TODO
                    ActionLbl.Text = "Please input your 1st guess !";
                    prevGuessedNum = GetValidUserInputWithinBounds(0, 101);
                    ActionLbl.Text = "Please input your 2nd guess !";
                    nextGuessedNum = GetValidUserInputWithinBounds(0, 101);

                    if (prevGuessedNum == nextGuessedNum)
                    {
                        MessageBox.Show("Both guesses have to be different values!");
                        NumInputBox.Text = "";
                        return;
                    }
                }

                HotNColdListBox.Items.Add($"First guess: {prevGuessedNum} !");
                HotNColdListBox.Items.Add($"Second guess: {nextGuessedNum} !");

                MainGuessingGame(prevGuessedNum, nextGuessedNum, lowerBound, upperBound);
            }
            else
            {
                MessageBox.Show("Input is not within the given bounds!");
                NumInputBox.Clear();
            }
        }

        void MainGuessingGame(int prevGuessedNum, int nextGuessedNum, int lowerBound, int upperBound)
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
                    HotNColdListBox.Items.Add(_stringRow);
                    HotNColdListBox.Items.Add($"Next Number between {lowerBound} and {upperBound} !");
                    _stringRow = "";
                    rounds++;
                    prevGuessedNum = nextGuessedNum;

                    if (!SecondMethodCheckBox.Checked)
                    {
                        nextGuessedNum = NumCreator.GetRandomNumWithinBound(lowerBound, upperBound);
                    }
                    else
                    {
                        nextGuessedNum = GetValidUserInputWithinBounds(lowerBound, upperBound + 1);
                    }
                }

                _stringRow = $" The goalNumber was guessed in {rounds} Rounds!";
                HotNColdListBox.Items.Add(_stringRow);
                HotNColdListBox.Items.Add("");
            }
            else
            {
                HotNColdListBox.Items.Add("Lucky, first guess was the goalNumber!");
            }
        }

        // this method mostly checks if the beginning values are correct or else the MainGuessingGame will not even start
        void StartBtn_Click(object sender, EventArgs e) => StartGuessingGame();

        void ClearBtn_Click(object sender, EventArgs e) => HotNColdListBox.Items.Clear();

        private new void KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            if (((char)e.KeyData) == ((char)Keys.Enter))
            {
                StartBtn.Focus();
                StartBtn.PerformClick();
            }
        }
    }
}