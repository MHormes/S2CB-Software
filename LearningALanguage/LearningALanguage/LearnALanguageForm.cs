using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningALanguage
{
    public partial class LearnALanguageForm : Form
    {
        private Label[] wordsSentences;
        private TextBox[] answers;
        private PictureBox[] correctness;
        CheckIfCorrect Test;

        public LearnALanguageForm()
        {
            InitializeComponent();
            // Store reference of controls for easy processing
            wordsSentences = new Label[] { lblQuestion1,lblQuestion2,lblQuestion3,lblQuestion4,lblQuestion5,lblQuestion6,lblQuestion7,lblQuestion8,lblQuestion9,lblQuestion10,lblQuestion11 };
            answers = new TextBox[] { tbQuestion1, tbQuestion2, tbQuestion3, tbQuestion4, tbQuestion5, tbQuestion6, tbQuestion7, tbQuestion8, tbQuestion9, tbQuestion10, tbQuestion11 };
            correctness = new PictureBox[] { pbQuestion1, pbQuestion2, pbQuestion3, pbQuestion4, pbQuestion5, pbQuestion6, pbQuestion7, pbQuestion8, pbQuestion9, pbQuestion10, pbQuestion11 };
            Test = new CheckIfCorrect();
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            string results = "";
            if (Test.Correct(tbQuestion1.Text.ToLower())) { pbQuestion1.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n" ;}
            else { pbQuestion1.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.halloA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion2.Text.ToLower())) { pbQuestion2.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion2.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.howareyouA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion3.Text.ToLower())) { pbQuestion3.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion3.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.imsorryA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion4.Text.ToLower())) { pbQuestion4.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion4.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.jaA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion5.Text.ToLower())) { pbQuestion5.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion5.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.neeA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion6.Text.ToLower())) { pbQuestion6.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion6.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.iamA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion7.Text.ToLower())) { pbQuestion7.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion7.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.whatsyournameA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion8.Text.ToLower())) { pbQuestion8.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion8.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.thankyouA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion9.Text.ToLower())) { pbQuestion9.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion9.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.howmuchdoesitcostA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion10.Text.ToLower())) { pbQuestion10.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion10.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.idontunderstandA + "\r\n\r\n"; }
            if (Test.Correct(tbQuestion11.Text.ToLower())) { pbQuestion11.Image = Image.FromFile(Application.StartupPath + "\\" + "Good.png"); results += "\r\n\r\n"; }
            else { pbQuestion11.Image = Image.FromFile(Application.StartupPath + "\\" + "Wrong.png"); results += Test.goodbyeA + "\r\n\r\n"; }

            tbResults.Text = results;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }
    }
}
