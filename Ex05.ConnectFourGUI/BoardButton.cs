using System;

namespace Ex05.ConnectFourGUI
{
    using System.Windows.Forms;
    using Ex05.ConnectFourEngine;

    internal partial class BoardButton : Button
    {
        public const int k_InitialSpaceFromLeftEdge = 15;
        public const int k_InitialSpaceFromTopEdge = 50;
        public const int k_SpaceBetweenButtons = 10;
        public const int k_ButtonSize = 30;

        public BoardButton(int i_Row, int i_Col)
        {
            InitializeComponent();
            placeButtonOnScreen(i_Row, i_Col);
        }

        private void placeButtonOnScreen(int i_Row, int i_Col)
        {
            this.Left = k_InitialSpaceFromLeftEdge + (i_Col * (k_SpaceBetweenButtons + k_ButtonSize));
            this.Top = k_InitialSpaceFromTopEdge + (i_Row * (k_SpaceBetweenButtons + k_ButtonSize));
        }

        public void BoardCell_GotChanged(BoardCell i_CellChanged)
        {
            if(i_CellChanged.IsEmpty)
            {
                this.Text = string.Empty;
            }
            else
            {
                this.Text = i_CellChanged.CurrentSign.ToString();
            }
        }
    }
}
