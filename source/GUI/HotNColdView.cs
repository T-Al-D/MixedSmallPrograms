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

        void startBtn_Click(object sender, EventArgs e)
        {
            var lowerBound = 0;
            var upperBound = 100;
            int prevGuessedNum, nextGuessedNum;

            // get a valid start
            _goalNum = Check.CheckValidNumber(numInputBox.Text);

            if (_goalNum > -1 && _goalNum < 101)
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
                    // TODO
                    nextGuessedNum = 10;
                    prevGuessedNum = 30;
                }

                hotNColdListBox.Items.Add($"First guess: {prevGuessedNum} !");
                hotNColdListBox.Items.Add($"First guess: {nextGuessedNum} !");

                // in case the golNumber got guessed in the first guess
                if (prevGuessedNum != _goalNum)
                {
                    short rounds = 0;
                    // main loop
                    while (nextGuessedNum != _goalNum)
                    {
                        //var tempPrevGuessNum = prevGuessedNum;

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
                        nextGuessedNum = NumCreator.GetRandomNumWithinBound(lowerBound, upperBound);
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
            else
            {
                MessageBox.Show("Input is not within the given bounds!");
                numInputBox.Clear();
            }
        }

        void clearBtn_Click(object sender, EventArgs e) => hotNColdListBox.Items.Clear();
    }
}