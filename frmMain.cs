using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gnuciDictionary;
namespace Deficiando
{
    public partial class frmMain : Form
    {
        //form level variables: numwordstried, score, correct-definition, list of words
        //enum pickaword, choosedefinition, userwent
        Random rndWord = new Random();
        Random rndDefBox = new Random();
        Word selectedword;
        List<Word> lstwords;
        List<Label> lstdefboxes;
        public frmMain()
        {
            InitializeComponent();
            btnPickWord.Click += BtnPickWord_Click;
            lstdefboxes = new List<Label>() { lbldef1, lbldef2, lbldef3 };
            lstwords = EnglishDictionary.GetAllWords().ToList();
        }

        //procedure pick a word and fill the 3 definition labels

        private void PickaWord()
        {
            int wordnum = rndWord.Next(1000, 100000);
            int defboxnum = rndDefBox.Next(0, 3);
            selectedword = lstwords[wordnum];
            lblWord.Text = selectedword.Value;

            lstdefboxes.ForEach(l => l.Text = "");

            lstdefboxes[defboxnum].Text = selectedword.Definition;

            lstdefboxes.Where(l => l.Text == "").ToList().ForEach(l =>
            {
                //pick a random word and put its definition into the l
                wordnum = rndWord.Next(0, 100000);
                l.Text = lstwords[wordnum].Definition;
            });

        }

        //CheckWinner

        private void BtnPickWord_Click(object? sender, EventArgs e)
        {
            PickaWord();
        }

    }
}