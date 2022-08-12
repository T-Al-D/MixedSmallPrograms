using MixedLibrary;

namespace GUI
{
    public partial class DiamondView : Form
    {
        int _diamondSize { get; set; }
        // string is build with these
        string _buildingBlock { get; set; } = "*";
        // each row is build with many chars before being displayed
        string _stringRow { get; set; } = "";
        public DiamondView() => InitializeComponent();

        void returnBtn_Click(object sender, EventArgs e)
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

        void diamondStartBtn_Click(object sender, EventArgs e)
        {
            _diamondSize = Check.CheckValidNumber(NumInputBox.Text);

            if (!(_diamondSize != -1 && _diamondSize > 42))
            {
                NumInputBox.Text = "";

                if (InputIsTotalSizeCheckBox.Checked)
                {
                    if ((_diamondSize % 2) != 0)
                    {
                        // catch error one star draw during 0 input
                        if (_diamondSize == 0)
                        {
                            DrawDiamond(0);
                        }
                        else
                        {
                            DrawDiamond(_diamondSize / 2 + 1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input has to uneven if number is toatal size !");
                    }
                }
                else
                {
                    DrawDiamond(_diamondSize);
                }
            }
            else
            {
                MessageBox.Show("Input has to be a valid positive Number in the given range!");
            }
        }

        void RoutineAfterRow()
        {
            diamodListBox.Items.Add(_stringRow);
            _stringRow = "";
        }

        void DrawDiamond(int input)
        {
            var drawCharsInColumn = 1;

            if (input == 0)
            {
                drawCharsInColumn = 0;
            }

            var emptySpaces = (input * 2);
            byte steps = 2;

            // upper part
            for (int rows = 0; rows < input; rows++)
            {
                _stringRow = StringCreator.AddEmptySpaces(_stringRow, emptySpaces);
                _stringRow = StringCreator.FillStringWithSubStrings(_stringRow, _buildingBlock, drawCharsInColumn);

                //for (int column = 0; column < drawCharsInColumn; column++)
                //    _stringRow = $"{_stringRow}{_buildingBlock}";


                RoutineAfterRow();
                drawCharsInColumn += steps;
                emptySpaces -= steps;
            }

            // balance out in the middle
            emptySpaces += (steps * 2);
            drawCharsInColumn -= (steps * 2);

            // lower part
            for (int rows = 0; rows < input - 1; rows++)
            {
                _stringRow = StringCreator.AddEmptySpaces(_stringRow, emptySpaces);
                _stringRow = StringCreator.FillStringWithSubStrings(_stringRow, _buildingBlock, drawCharsInColumn);


                //for (int column = 0; column < drawCharsInColumn; column++)
                //    _stringRow = $"{_stringRow}{_buildingBlock}";


                RoutineAfterRow();
                drawCharsInColumn -= steps;
                emptySpaces += steps;
            }

            // one line for space before each diamond    
            RoutineAfterRow();
        }

        void clearBtn_Click(object sender, EventArgs e) => diamodListBox.Items.Clear();
    }
}