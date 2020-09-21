using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Utilities;

namespace WindowsFormsApp1.ViewModels
{
    public partial class HSKVocabScanner : Form
    {
        public HSKVocabScanner()
        {
            InitializeComponent();
        }

        private void OnClick_ScanDocument(object sender, EventArgs e)
        {
            List<string> words = DocumentManager.AllWords;

            foreach (var word in words)
            {
                int startIndex = 0;
                while (startIndex < myRtb.TextLength)
                {
                    int wordStartIndex = myRtb.Find(word, startIndex, RichTextBoxFinds.None);

                    if (wordStartIndex != -1)
                    {
                        myRtb.SelectionStart = wordStartIndex;
                        myRtb.SelectionLength = word.Length;

                        if (DocumentManager.AllWords.Contains(word))
                        {
                            myRtb.SelectionBackColor = Color.Green;
                        }
                        else if (DocumentManager.HSKLevelTwo.Contains(word))
                        {
                            myRtb.SelectionBackColor = Color.Blue;
                        }
                        else if (DocumentManager.HSKLevelThree.Contains(word))
                        {
                            myRtb.SelectionBackColor = Color.Red;
                        }
                        else if (DocumentManager.HSKLevelFour.Contains(word))
                        {
                            myRtb.SelectionBackColor = Color.Green;
                        }
                        else if (DocumentManager.HSKLevelFive.Contains(word))
                        {
                            myRtb.SelectionBackColor = Color.Pink;
                        }
                        else if (DocumentManager.HSKLevelSix.Contains(word))
                        {
                            myRtb.SelectionBackColor = Color.Orange;
                        }
                    }
                    else
                    {
                        break;
                    }
                    startIndex += wordStartIndex + word.Length;
                }
            }
        }
    }
}
