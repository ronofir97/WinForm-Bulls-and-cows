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
    public partial class ColorSelection : Form
    {
        private Dictionary<Color, bool> m_DictionaryOfSelectedColor;

        public Color m_SelectedColor;

        public ColorSelection()
        {
            m_DictionaryOfSelectedColor = new Dictionary<Color, bool>(8)
                                                                          {
                                                                               { Color.Red, false },
                                                                               { Color.Purple, false },
                                                                               { Color.Green, false },
                                                                               { Color.Blue, false },
                                                                               { Color.DeepSkyBlue, false },
                                                                               { Color.Yellow, false },
                                                                               { Color.Brown, false },
                                                                               { Color.White, false }
                                                                           };
            InitializeComponent();
        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            this.m_SelectedColor = (sender as Button).BackColor;
            (sender as Button).Enabled = false;
            this.Visible = false;
        }

        public bool CheckIfSelectd(Color i_ColorToCheck)
        {
            if(i_ColorToCheck.IsEmpty)
            {
                return false;
            }
            else
            {
                return m_DictionaryOfSelectedColor[i_ColorToCheck] == true;
            }
        }

        public void UpdateColorSelected(Color i_ColorToIpdate, bool i_FlagToUpdate)
        {
            m_DictionaryOfSelectedColor[i_ColorToIpdate] = i_FlagToUpdate;

            if(!i_FlagToUpdate)
            {
                foreach(Control control in this.Controls)
                {
                    if((control as Button).BackColor == i_ColorToIpdate)
                    {
                        (control as Button).Enabled = true;
                    }
                }
            }
        }
    }
}
