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
    public partial class Start : Form
    {
        private const int K_NumberOfChoicesStart = 4;
        private int m_gameNumberOfChances = 4;

        public int GameNumberOfChances
        {
            get => m_gameNumberOfChances;
            set => m_gameNumberOfChances = value;
        }

        public Start()
        {
            InitializeComponent();
        }

        private void UpdateNumberOfChances()
        {
            if (this.GameNumberOfChances < 10)
            {
                this.GameNumberOfChances++;
            }
            else
            {
                this.GameNumberOfChances = K_NumberOfChoicesStart;
            }
        }

        private void Start_Load(object sender, EventArgs i_E)
        {
        }

        private void ButtonBumberOfChoices_Click(object i_Sender, EventArgs e)
        {
            UpdateNumberOfChances();
            (i_Sender as Button).Text = string.Format("{0}{1}", "Number of chances: ", this.GameNumberOfChances);
        }

        private void ButtonStart_Click(object i_Sender, EventArgs e)
        {
            this.Visible = false;
            GameForm gameForm = new GameForm(GameNumberOfChances);
            gameForm.ShowDialog();
        }
    }
}
