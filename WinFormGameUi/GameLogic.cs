using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormGameUi
{
    public class GameLogic
    {
        private List<Color> m_ColorList;

        private List<Color> m_ListOfColorSelection;

        public List<Color> ColorList { get; set; }

        public GameLogic()
        {
            m_ListOfColorSelection = new List<Color>(4);
            ColorList = new List<Color>()
                            {
                                Color.Red,
                                Color.Purple,
                                Color.Green,
                                Color.Blue,
                                Color.DeepSkyBlue,
                                Color.Yellow,
                                Color.Brown,
                                Color.White
                            };
            RandomComputerSelection();
        }

        public void RandomComputerSelection()
        {
            List<int> intListPresentIndexes = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };
            Random random = new Random();
            for (int index = 0; index < 4; index++)
            {
                bool flagOfIter = false;
                while (!flagOfIter)
                {
                    int randomNumber = random.Next(0, 8);
                    if (intListPresentIndexes.Contains(randomNumber))
                    {
                        m_ListOfColorSelection.Add(ColorList[randomNumber]);
                        intListPresentIndexes.Remove(randomNumber);
                        flagOfIter = true;
                    }
                }
            }
        }

        public void CheckResults(RowItemForGame i_RowItemForGame, ref bool i_BoolToCheckIfWin)
        {
            int counterOfBoolPgia = 0;
            int countOfPgia = 0;
            int index = 0;
            List<Button> listToCheck = new List<Button>(4)
                                           {
                                               i_RowItemForGame.ButtonUnit1, i_RowItemForGame.ButtonUnit2,
                                               i_RowItemForGame.ButtonUnit3, i_RowItemForGame.ButtonUnit4
                                           };
            List<Button> resultsButtons = new List<Button>(4)
                                              {
                                                  i_RowItemForGame.ResBtn1, i_RowItemForGame.ResBtn2,
                                                  i_RowItemForGame.ResBtn3, i_RowItemForGame.ResBtn4
                                              };
            for(index = 0; index < 4; index++)
            {
                if(listToCheck[index].BackColor == m_ListOfColorSelection[index])
                {
                    counterOfBoolPgia++;
                }
                else if (m_ListOfColorSelection.Contains(listToCheck[index].BackColor))
                {
                    countOfPgia++;
                }
            }

            if (counterOfBoolPgia == 4)
            {
                i_BoolToCheckIfWin = true;
            }

            index = 0;
            while (counterOfBoolPgia > 0)
            {
                resultsButtons[index++].BackColor = Color.Black;
                counterOfBoolPgia--;
            }

            while (countOfPgia > 0)
            {
                resultsButtons[index++].BackColor = Color.Yellow;
                countOfPgia--;
            }
        }

        public void UpdateColorsOfComputerSelection(List<Button> i_ListButtonToUpdateColor)
        {
            for(int index = 0; index < 4; index++)
            {
                i_ListButtonToUpdateColor[index].BackColor = m_ListOfColorSelection[index];
            }
        }
    }
}