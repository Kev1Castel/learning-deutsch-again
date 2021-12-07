using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Deutsch_Again
{
    class ClassConjugaison
    {
        private Dictionary<string, string> dictQuestion = new Dictionary<string, string>();
        public Dictionary<string, string> dictQuestionAnswer = new Dictionary<string, string>();

        public ClassConjugaison()
        {
            SetDictQuestion();
        }

        private void SetDictQuestion()
        {
            dictQuestion.Add("terminaison 1ere personne", "e");
            dictQuestion.Add("terminaison 2nde personne", "st");
            dictQuestion.Add("terminaison 3eme personne", "t");
            dictQuestion.Add("terminaison 4eme personne", "en");
            dictQuestion.Add("terminaison 5eme personne", "st");
            dictQuestion.Add("terminaison 6eme personne", "en");
            dictQuestion.Add("l'auxiliaire du futur en", "werden");
        }

        public void DefineQuestion()
        {
            Random rndChild = new Random();
            int index = 0;
            string answer = string.Empty, question = string.Empty;
            while (dictQuestion.Count > dictQuestionAnswer.Count)
            {
                index = rndChild.Next(dictQuestion.Count);
                question = dictQuestion.ElementAt(index).Key;
                answer = dictQuestion.ElementAt(index).Value;
                if (dictQuestionAnswer.ContainsKey(question) == false)
                {
                    dictQuestionAnswer.Add(question, answer);
                }
            }
        }

    }
}

