using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Deutsch_Again
{
    class Color
    {
        /*
        Cette classe contient
        */
        private Dictionary<string, string> dictColor = new Dictionary<string, string>();
        public Dictionary<string, string> dictQuestionAnswer = new Dictionary<string, string>();

        public Color()
        {
            dictColor.Add("Noir", "Schwarze");
            dictColor.Add("Jaune", "Gelb");
            dictColor.Add("Rouge", "Rot");
            dictColor.Add("Blanc", "Weiß");
            dictColor.Add("Vert", "Grün");
            dictColor.Add("Marron", "Brau");
            dictColor.Add("Orange", "Orange");
            dictColor.Add("Rose", "Rosa");
            dictColor.Add("Violet", "Lila");
            dictColor.Add("Bleu", "Blau");
        }

        public void DefineQuestion()
        {
            /*
            Cette fonction sert à prédéfinir les questions
            qui seront posé à l'utilisateur sur le thème
            des couleurs.
            */ 
            Random rndChild = new Random();
            int rndValue = rndChild.Next(dictColor.Count);
            int index = 0;
            string question = "";
            string answer = "";
            while(dictQuestionAnswer.Count < dictColor.Count)
            {
                index = rndChild.Next(dictColor.Count);
                question = dictColor.ElementAt(index).Key;
                answer = dictColor.ElementAt(index).Value;
                if (dictQuestionAnswer.ContainsKey(question) == false)
                {
                    dictQuestionAnswer.Add(question, answer);
                }
            }
        }
    }
}
