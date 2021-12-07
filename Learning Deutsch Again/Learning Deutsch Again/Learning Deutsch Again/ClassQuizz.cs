using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Deutsch_Again
{
    class ClassQuizz
    {

		private List<string> textlist = new List<string> { "Application", "Quitter", "Démarrer une session", "Pronom Personnel", "Nombre", "Nombre Cardinaux" };

		private List<string> listQuestionPassed = new List<string>();

		//private List<string> listAnswerPossibiles = new List<string>();

		private Dictionary<string, bool> dictQuestionDid = new Dictionary<string, bool>();

		private Dictionary<string, string> dictQuestionAnswer = new Dictionary<string, string>();

		private bool doesAnswerIsRight = false;
		private string lastQuestion, question;
		public string answer;

		private Random indexRnm = new Random();

		private ClassNumber numberClass = new ClassNumber();
		private ClassPronomQuestion pronomQuestion = new ClassPronomQuestion();
		private Color color = new Color();
		private ClassConjugaison grammaire = new ClassConjugaison();

		//public string answer = "";


		public int counterQuestionRightAnswered = 0;

		private int wrongQuestionAnswered;

		private string CalculStats()
        {
			string text ="";
			float statQuestionDid = (float)dictQuestionDid.Count() / (float)dictQuestionAnswer.Count() * (float)100.0;
			float statQuestionFailed = (float)wrongQuestionAnswered / (float)(dictQuestionDid.Count() + dictQuestionAnswer.Count()) * (float)100.0;


			text = $"{Math.Round(statQuestionFailed,2)}%/{Math.Round(statQuestionDid)}%/100%";
			//text = $"{wrongQuestionAnswered}/{dictQuestionDid.Count()}/{dictQuestionAnswer.Count()}";
			return text;
        }

		public void SetOffQuizz()
        {
			dictQuestionDid.Clear();
			dictQuestionAnswer.Clear();
			listQuestionPassed.Clear();
			answer = "";
			question = "end";
        }

		public void AddQuestionToListQuestionPassed()
		{
			wrongQuestionAnswered += 1;
			listQuestionPassed.Add(question);
			dictQuestionDid[question] = true;
        }

		public string GetQuestionDid()
        {
			/*
			 Cette fonction permet d'obtenir un aperçu des réponses faite en indiquant
				à l'utilisateur la validité de la réponse de la question. Cela pour toutes
				les questions déjà faite par l'utilisateur. Tout cela est récupérer dans une 
				variable text, parfois les questions sont trop longues alors seulement un 
				petit bouts est récupérer afin d'afficher un minium de texte à l'utilisateur.
			
			Return:
				string text = question faite
			 
			 */
			string text = "Résultat :"+CalculStats()+ "\r\n";
			foreach(KeyValuePair<string,bool> KV in dictQuestionDid)
            {
				if (KV.Key.Contains("animeaux") && KV.Key.Contains("il"))
				{
					text += "Il/Elle";
				}
				else if (KV.Key.Contains("terminaison") && KV.Key.Contains("personne"))
				{
					text += KV.Key;
					text = text.Replace("terminaison", "Term.");
					text = text.Replace("personne", "Pers.");
                } else if (KV.Key.Contains("l'auxiliaire du futur en")){
					text += "Auxilaire Futur (DE)";
                } else { 
					text += KV.Key;
				}
				if (KV.Value == false)
                {
					text += " : Râté";
                } else {
					if (listQuestionPassed.Contains(KV.Key)==false)
					{ 
						text += "  : Réussite";
					} else {
						text += " : passer";
                    }
				}
				text += "\r\n";
			}
			return text;
        }
		
		public bool CheckQuestion(string a)
        {
			/*
			Cette fonction permet de vérifier le résultat(string a (saisie de l
				'utilisateur)) de la question ou de modifier le status 
				(d'une question non réussiste en réussis) grâce à le 
				dictionnaire<string, bool> contenant les questions faite par 
				l'utilisateur.

			Param:
				string a = est la réponse saisit par l'utilisateur
			
			Return:
				doesAnswerIsRight = est un booléen s'assignant à la validité
					de la réponse.
			*/
			doesAnswerIsRight = a == answer.ToLower();
			if (dictQuestionDid.ContainsKey(question))
            {
				if (doesAnswerIsRight == true)
                {
					dictQuestionDid[question] = doesAnswerIsRight;
                }
            } else { 
				dictQuestionDid.Add(question, doesAnswerIsRight);
			}
			if (doesAnswerIsRight == false)
            {
				wrongQuestionAnswered++;
            }
			return doesAnswerIsRight;
        }

		private List<string> GetRightAnsweredQuestion()
        {
			/*
			Cette fonction permet d'obtenir une liste de question réussis (qui est renvoyé)
			Return:
				List<string> questionAchieved = question parfaitement réussis 
			*/
			List<string> questionAchieved = new List<string>();
			foreach(KeyValuePair<string, bool> KV in dictQuestionDid)
            {
				if (KV.Value == true)
                {
					questionAchieved.Add(KV.Key);
                }
            }
			return questionAchieved;
        }

		public string ChooseQuestion()
        {
			/*
			Cette méthode est utilisé à choisir la question puis la renvoyé
			Return:
				string question = la question définis
			*/
			int count = 0;
			lastQuestion = question;
			question = null;
			Random childRnd = new Random();
			int index = childRnd.Next(dictQuestionAnswer.Count());
			question = dictQuestionAnswer.ElementAt(index).Key;
			answer = dictQuestionAnswer.ElementAt(index).Value;
			List<string> listRightAnswered = new List<string>();
			listRightAnswered = GetRightAnsweredQuestion();
			int counterQuestionDLeftover = dictQuestionAnswer.Count() - listRightAnswered.Count();
			if (dictQuestionAnswer.Count() > 0)
            {
                if (counterQuestionDLeftover > 0)
                {
                    while (question == lastQuestion || listRightAnswered.Contains(question) == true || listQuestionPassed.Contains(question)==true)
                    {
                        index = childRnd.Next(dictQuestionAnswer.Count());
                        question = dictQuestionAnswer.ElementAt(index).Key;
                        answer = dictQuestionAnswer.ElementAt(index).Value;
						count += 1;
						if (count > 200)
                        {
							question = "end";
                        }
                    }
                }
                else if (counterQuestionDLeftover == 0)
                {
                    question = "end";
                }
            }
			System.Diagnostics.Debug.WriteLine(answer);
            return question;
        }

		public string StartQuizz(string kindQuestion)
		{
			/*
			Cette fonction démarre une session de quizz,
				elle permet de congifirer selon le thème
				la session.
			Param:
				kindQuestion = matière de quizz, par exemple si l'utilisateur
					démarre un quizz
			Return:
				string question qui est la question définis dans une autre méthode.
			*/ 
			List<string> numericNum = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
			string question = null;
			wrongQuestionAnswered = 0;
			if (kindQuestion == "Nombre")
			{
				numberClass.DefineQuestion();
				dictQuestionAnswer = numberClass.dictQuestionChosen;
				question = ChooseQuestion();
			}
			else if (kindQuestion == "NombreC")
			{
				numberClass.DefineQuestion(cardinalNumber:true);
				dictQuestionAnswer = numberClass.dictQuestionChosen;
				question = ChooseQuestion();
				//answer_by_laptop = numberClass.NumberDefine(2500);
			}
			else if (kindQuestion == "Pronom")
			{
				pronomQuestion.GetAllQuestion();
				dictQuestionAnswer = pronomQuestion.dictQuestionAnswer;
				question = ChooseQuestion();
			} else if (kindQuestion == "Color")
            {
				color.DefineQuestion();
				dictQuestionAnswer = color.dictQuestionAnswer;
				question = ChooseQuestion();
            } else if (kindQuestion == "Grammaire")
            {
				grammaire.DefineQuestion();
				dictQuestionAnswer = grammaire.dictQuestionAnswer;
				question = ChooseQuestion();
            }
			return question;
		}
	}
}
