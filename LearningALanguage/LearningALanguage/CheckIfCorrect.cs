using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LearningALanguage
{
    public class CheckIfCorrect
    {
        private Regex hallo = new Regex("^h(allo|oi|a)$");
        public string halloA = "hallo";
        private Regex howareyou = new Regex("^hoe.(gaat|is).het*$");
        public string howareyouA = "Hoe gaat het";
        private Regex imsorry = new Regex("^[sorry]*[het spijt me]*[excuses]*$");
        public string imsorryA = "Het spijt me";
        private Regex ja = new Regex("^ja$");
        public string jaA = "Ja";
        private Regex nee = new Regex("^nee$");
        public string neeA = "Nee";
        private Regex iam = new Regex("^ik.(ben|heet)$");
        public string iamA = "Ik ben";
        private Regex whatsyourname = new Regex("^(hoe.heet.jij|wat.is.jouw.naam)$");
        public string whatsyournameA = "Hoe heet jij";
        private Regex thankyou = new Regex("^dank(je|jewel|u)*$");
        public string thankyouA = "Dankjewel";
        private Regex howmuchdoesitcost = new Regex("^(hoeveel|hoe).(duur is|kost).(het|dit)$");
        public string howmuchdoesitcostA = "Hoeveel kost dit";
        private Regex idontunderstand = new Regex("^ik.(begrijp|snap).niet$");
        public string idontunderstandA = "Ik begrijp het niet";
        private Regex goodbye = new Regex("^(doei|vaarwel|hoi)$");
        public string goodbyeA = "Doei";

        List<Regex> regexList;

        public CheckIfCorrect()
        {
            regexList = new List<Regex>();
            regexList.Add(hallo);
            regexList.Add(howareyou);
            regexList.Add(imsorry);
            regexList.Add(ja);
            regexList.Add(nee);
            regexList.Add(iam);
            regexList.Add(whatsyourname);
            regexList.Add(thankyou);
            regexList.Add(howmuchdoesitcost);
            regexList.Add(idontunderstand);
            regexList.Add(goodbye);

        }

        public bool Correct(string text)
        {
            foreach (Regex rx in regexList)
            {
                if (Regex.IsMatch(text, rx.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
