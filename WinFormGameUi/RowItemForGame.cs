using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormGameUi
{
    public partial class RowItemForGame : Form
    {
        private static int s_ControlsOfRowsIndex = 5;

        private ColorSelection m_Color;

        private GameLogic m_GameLogic;

        public ColorSelection ColorList
        {
            get
            {
                return m_Color;
            }

            set
            {
                m_Color = value;
            }
        }

        public RowItemForGame(GameLogic i_GameLogic)
        {
            m_GameLogic = i_GameLogic;
            m_Color = new ColorSelection();
            InitializeComponent();
            this.ButtonExecute.Enabled = false;
        }

        private void ButtonUnitColor_Click(object sender, EventArgs e)
        {
            ColorList.ShowDialog();
            if((sender as Button).BackColor != SystemColors.Control)
            {
                if (!m_Color.CheckIfSelectd(ColorList.m_SelectedColor))
                {
                    m_Color.UpdateColorSelected((sender as Button).BackColor, false);
                    m_Color.UpdateColorSelected(ColorList.m_SelectedColor, true);
                    (sender as Button).BackColor = ColorList.m_SelectedColor;
                }
            }
            else
            {
                if(!m_Color.CheckIfSelectd(ColorList.m_SelectedColor))
                {
                    m_Color.UpdateColorSelected(ColorList.m_SelectedColor, true);
                    (sender as Button).BackColor = ColorList.m_SelectedColor;
                }
            }
        }

        private void allButtonsHandlerCheckIfTiOpenExecuteButton_Click(object sender, EventArgs e)
        {
            if(checkIfAllButtonPainted())
            {
                this.ButtonExecute.Enabled = true;
            }
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            this.ButtonUnit1.Enabled = false;
            this.ButtonUnit2.Enabled = false;
            this.ButtonUnit3.Enabled = false;
            this.ButtonUnit4.Enabled = false;
            bool flagOfWin = false;
            List<Button> buttonsToSendForColorUpdate = new List<Button>(4)
                                                           {
                                                               (this.ParentForm.Controls[3] as Button),
                                                               (this.ParentForm.Controls[2] as Button),
                                                               (this.ParentForm.Controls[1] as Button),
                                                               (this.ParentForm.Controls[0] as Button)
                                                           };

            this.ButtonExecute.Enabled = false;
            m_GameLogic.CheckResults(this, ref flagOfWin);

            if(flagOfWin)
            {
                m_GameLogic.UpdateColorsOfComputerSelection(buttonsToSendForColorUpdate);
            }
            else if (s_ControlsOfRowsIndex != this.ParentForm.Controls.Count)
            {
                this.ParentForm.Controls[s_ControlsOfRowsIndex++].Enabled = true;
            }
            else
            {
                m_GameLogic.UpdateColorsOfComputerSelection(buttonsToSendForColorUpdate);
            }
        }

        private bool checkIfAllButtonPainted()
        {
            return this.ButtonUnit1.BackColor != SystemColors.Control
                    && this.ButtonUnit2.BackColor != SystemColors.Control
                    && this.ButtonUnit3.BackColor != SystemColors.Control
                    && this.ButtonUnit4.BackColor != SystemColors.Control;
        }
    }
}
