using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Deutsch_Again
{
    class ClassPronomQuestion
    {
        private List<string> dePronom = new List<string>() { "ich", "du", "er","sie", "es", "wir", "sie", "sie" };
        private List<string> frPronom = new List<string>() { "je", "tu", "il","elle", "il/elle (Version animeaux et objets)", "nous", "vous", "ils/elles" };
        public Dictionary<string, string> dictQuestionAnswer = new Dictionary<string, string>();        

        public void GetAllQuestion()
        {
            /*
             Récupère toutes les questions possible sur ce thème.
            PS:Rient n'est 'returné' l'assignation se fait par l'instance
            de cette classe car le type est un dictionnaire.
             */
            int lengthListQuestion = dePronom.Count();
            int lengthDictQuestionAnswer = 0;
            Random childRnd = new Random();
            int index;
            string deElement;
            string frElement;
            while (lengthDictQuestionAnswer < lengthListQuestion)
            {
                index = childRnd.Next(dePronom.Count());
                deElement = dePronom[index];
                frElement = frPronom[index];
                if (dictQuestionAnswer.ContainsKey(frElement) == false)
                {
                    dictQuestionAnswer.Add(frElement,deElement);
                }
                lengthDictQuestionAnswer = dictQuestionAnswer.Count();
            }

        }
    }
}
