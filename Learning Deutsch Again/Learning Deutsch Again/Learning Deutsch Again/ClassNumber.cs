using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Deutsch_Again
{
    class ClassNumber
    {

		private Random childRandom = new Random();
		Dictionary<string, string> dictDeCardinalNumber = new Dictionary<string, string>();

		private List<string> deNumber = new List<string>() { "ein", "zwei", "drei", "vier", "fünf", "sechs", "sieben", "acht", "neun", "zehn", "elfe", "zwölf" };

		public Dictionary<string, int> dictNumberByType = new Dictionary<string, int>();

		public Dictionary<string, string> dictQuestionChosen = new Dictionary<string, string>();

		public ClassNumber()
        {

        }


		public void DefineQuestion(bool cardinalNumber = false)
        {
			/*
			 Cette fonction définit les questions qui seront renvoyé à la classe Quizz,
			puis choisit pour la session de quizz.
			Param:
				cardinalNumber = si le quizz porte sur le thème des nombres Cardinaux ou non
			*/
			List<string> lQuestionAnswer = new List<string>();
			string question;
			string answer;
			int index = 0;
			if (cardinalNumber == false)
			{ 
				while (dictQuestionChosen.Count < 8)
				{
					lQuestionAnswer = NumberDefine();
					answer = lQuestionAnswer.ElementAt(0);
					question = lQuestionAnswer.ElementAt(1);
					if (dictQuestionChosen.ContainsKey(question)==false)
					{ 
						dictQuestionChosen.Add(question, $"{answer}");
					}
					lQuestionAnswer.Clear();
					dictNumberByType.Clear();
				}
			} else { 
				while (dictQuestionChosen.Count < 8)
                {
                    lQuestionAnswer = DefineCardinalNumber();
                    question = lQuestionAnswer.ElementAt(0);
                    answer = lQuestionAnswer.ElementAt(1);
                    if (dictQuestionChosen.ContainsKey(question) == false)
                    {
                        dictQuestionChosen.Add(question, answer);
                    }
                }
            }
		}

        public List<string> DefineCardinalNumber()
        {
			/*
			Cette fonction définit un nombre cardinal à 
			chaque appel. 
				Elle choisit d'abord combien de nombre comprendra
				la valeur soit sur assignera à la valeur une somme 
				de la plage de 0 à 9999.
			 */

			string intNumber = null;
			int number = childRandom.Next(100);
			List<string> lQuestionAnswer = new List<string>();
			List<string> listNumToCheck = new List<string>();
			List<string> num = new List<string>();
			List<string> listReturn = new List<string>();
			
			listNumToCheck.Add("1");
			listNumToCheck.Add("2");
			listNumToCheck.Add("3");
			listNumToCheck.Add("7");

			if (number == 1)
			{
				listReturn.Add("1er");
				listReturn.Add("erste");
			} else if (number == 2) {
				listReturn.Add("2eme");
				listReturn.Add("zweite");
			} else if (number == 3) {
				listReturn.Add("3eme");
				listReturn.Add("dritte");
			} else if (number == 7) {
				listReturn.Add("7eme");
				listReturn.Add("siebte");
			} else if (number == 6){
				listReturn.Add("6");
				listReturn.Add("sechs");
			} else {
				intNumber = "7";
                while (listNumToCheck.Contains(intNumber) == true)
				{
					dictNumberByType.Clear();
					listReturn.Clear();
					num.Clear();
					num = NumberDefine();
					intNumber = num.ElementAt(1);
					listReturn.Add(intNumber+"eme");
					listReturn.Add(num.ElementAt(0) + "ste");
				}
			} 
			return listReturn;
		}

		public List<string> NumberDefine(int probMax = 1874)
        {
			/*
			Choose the unit as the first number,
			after that the script will define the ten number.
			The script have to choose if 
			la réponse à la variable utilisé
			pour tester la réponse de l'utilisateur
			et la réponse attendue.
			Something est utilisé pour retourner le nombre
			choisit.
			*/
			List<string> lreturner = new List<string>();
			//int definerNumberNum = 1;
			int definerNumberNum = childRandom.Next(2);
			string question = "";
			string answer = "";
			bool doesItAddUnd = definerNumberNum >= 1;
			GetDecimalUnit(doesItAddUnd);
			if (definerNumberNum >= 1)
            {
				GetDecimalTen();
            }
			if (definerNumberNum >=3)
            {
				GetDecimalHundred();
            }

            int lengthDictNumberByType = dictNumberByType.Count() - 1;

            foreach (KeyValuePair<string,int> KV in dictNumberByType)
            {
				question = question + KV.Key;
				answer = $"{KV.Value}" + $"{answer}";
            }
			if (question == "11")
            {
				answer = "elfe";
            } else if (question == "12")
            {
				answer = "zwölfe";
            }
			lreturner.Add(question);
			lreturner.Add(answer);
			return lreturner;
         }

        private void GetDecimalHundred()
		{
			/*
				Cette fonction définit la valeur de la centain
				par exemple si égale à "1" alors la valeur pour
				le quizz sera 1du (d=dizaine définit, u=unité définit)
				soit entre 100 et 199. Si la centaine est égale à 5 alors
				le nombre sera compris entre 500 et 599. 
			*/
			int indexList = childRandom.Next(0, 8);
			dictNumberByType.Add(deNumber[indexList]+"hundert", indexList+1);
			//int newIndex = indexList + 1;
		}

		private void GetDecimalUnit(bool doesitShouldAddUnd = false)
		{
			/*
			Cette fonction définit l'unité par exemple dans 69, elle définira 9.
			L'unité sera une valeur comprise entre 0 et 9 ensuite définis s'il doit
			y'avoir le mot clé "und" (qui en Allemand sépare l'unité et la dizaine).
			Ce dernier se fait par un booléen "doesItShouldAddUnd. Son assignation à
			"true" se fait par si le nombre de nombre dans la valeur est supérieur à
			0 (si >0 alors la valeur sera supérieur à 10) puis si l'unité et égale à 0 
			alors il n'y'aura pas de "und" d'ajouter. Pour en revenir à la valeur
			qui est définie, elle est d'abord du type int puis est récupérer sous
			le format string depuis une liste.
			Param:
				doesItShouldAddUnd = false (par défaut)
			*/
			int indexList = childRandom.Next(9);
			string unit = $"{deNumber[indexList]}";
			if (doesitShouldAddUnd && unit != "zero")
            {
				unit += "und";
            }
			dictNumberByType.Add(unit, indexList+1);
			//int newIndex = indexList + 1;
		}

		private void GetDecimalTen()
		{
			/*
			Cette fonction définit la dizaine à l'aide d'un
			type int puis récupère grâce à ce int la valeur 
			sous format lettre à l'aide d'une 'string'
			Cette valeur aussi bien qu'au format 'int' et 
			'string' est ajouter dans un dictionnaire comme
			l'unité.
				Si la dizaine est égal à "1" cela signifie
			que la valeur sera d'entre 10 et 19.
			Si alors la valeur est d'entre égal à la plage
			10 et 19, le "und" ajouté précédement à l'unité
			est retiré absolument.
				En suivant cette logique de la dizaine cela
			signifie que par exemple si:
				"8" alors la valeur définit jussqu'ici est
				entre 80 et 89
			*/
			int indexList = childRandom.Next(0, 8);
			string decimalv = "";
			if (indexList == 1)
			{
				decimalv = "zwanzig";
			}
			else if (indexList == 2)
			{
				decimalv = "dreiziß";
			}
			else if (indexList == 6)
			{
				decimalv = "siebzig";
			}
			else if (indexList == 5)
			{
				decimalv = "sechzig";
			} else if (indexList == 0)
            {
				decimalv = "zehn";
				string unit = dictNumberByType.ElementAt(0).Key;
                int value = dictNumberByType.ElementAt(0).Value;
				if (unit.Contains("und"))
                {
					unit = unit.Replace("und", "");
					dictNumberByType.Remove(unit);
					dictNumberByType.Add(unit, value);
                }
            } else {
				decimalv = deNumber[indexList] + "zig";
			}
			int newIndex = indexList + 1;
			dictNumberByType.Add(decimalv, newIndex);
		}
	}
}
