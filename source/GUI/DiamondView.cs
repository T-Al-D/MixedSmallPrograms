using MixedLibrary;
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
    public partial class DiamondView : Form
    {
        private int _diamondSize { get; set; }
        // string is build with these
        private char _buildingBlock { get; set; } = '*';
        // each row is build with many chars before being displayed
        private string _stringRow { get; set; } = "";
        public DiamondView()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            StartView startView = new StartView();
            startView.Show();
            Visible = false;
        }

        private void diamondStartBtn_Click(object sender, EventArgs e)
        {
            _diamondSize = Check.CheckValidNumber(NumInputBox.Text);
            if (!(_diamondSize != -1 && _diamondSize > 40))
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

        private void AddEmptySpaces(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                _stringRow = $"{_stringRow} ";
            }
        }

        private void RoutineAfterRow()
        {
            diamodListBox.Items.Add(_stringRow);
            _stringRow = "";
        }

        private void DrawDiamond(int input)
        {
            int drawCharsInColumn = 1;
            if (input == 0)
            {
                drawCharsInColumn = 0;
            }
            int emptySpaces = (input * 2);
            byte steps = 2;

            // upper part
            for (int rows = 0; rows < input; rows++)
            {
                AddEmptySpaces(emptySpaces);
                for (int column = 0; column < drawCharsInColumn; column++)
                {
                    _stringRow = $"{_stringRow}{_buildingBlock}";
                }
                RoutineAfterRow();
                drawCharsInColumn += steps;
                emptySpaces -= steps;
            }

            //balance out in the middle
            emptySpaces += (steps * 2);
            drawCharsInColumn -= (steps * 2);

            //lower part
            for (int rows = 0; rows < input - 1; rows++)
            {
                AddEmptySpaces(emptySpaces);
                for (int column = 0; column < drawCharsInColumn; column++)
                {
                    _stringRow = $"{_stringRow}{_buildingBlock}";
                }
                RoutineAfterRow();
                drawCharsInColumn -= steps;
                emptySpaces += steps;
            }

            // one line for space before each diamond    
            RoutineAfterRow();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            diamodListBox.Items.Clear();
        }
    }
}
