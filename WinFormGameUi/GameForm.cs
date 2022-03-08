using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace WinFormGameUi
{
    public partial class GameForm : Form
    {
        private static int s_IndexOfRowToOpen = 0;

        private int m_NumberOfRows;

        public int NumberOfRows { get; set; }

        public List<Button> m_GameFormButtons;

        public GameLogic m_GameLogic = new GameLogic();

        public Dictionary<int, RowItemForGame> GameRowsList;

        public GameForm(int i_NumberOfRows)
        {
            NumberOfRows = i_NumberOfRows;
            GameRowsList = new Dictionary<int, RowItemForGame>(i_NumberOfRows);
            InitializeComponent();
            this.ClientSize = new Size(this.Size.Width, this.Size.Height + NumberOfRows * 40);
            InitRows();
            m_GameFormButtons = new List<Button>(4)
                                  {
                                      ButtonComputerSelect1, ButtonComputerSelect2,
                                      ButtonComputerSelect3, ButtonComputerSelect4
                                  };
        }

        public void InitRows()
        {
            int leftMarginOnForm = ButtonComputerSelect1.Left;
            RowItemForGame rowOnForm = new RowItemForGame(m_GameLogic);
            rowOnForm.Top = ButtonComputerSelect1.Bottom + 50;
            rowOnForm.Left = leftMarginOnForm;
            rowOnForm.TopLevel = false;
            Controls.Add(rowOnForm);
            rowOnForm.Show();
            RowItemForGame previewRowItem = rowOnForm;
            GameRowsList.Add(0, rowOnForm);
            for (int index = 1; index < NumberOfRows; index++)
            {
                RowItemForGame newRowToForm = new RowItemForGame(m_GameLogic);
                newRowToForm.Top = previewRowItem.Bottom + 4;
                newRowToForm.Left = leftMarginOnForm;
                newRowToForm.TopLevel = false;
                newRowToForm.Enabled = false;
                previewRowItem = newRowToForm;
                Controls.Add(newRowToForm);
                GameRowsList.Add(index, newRowToForm);
                newRowToForm.Show();
            }
        }
    }
}
