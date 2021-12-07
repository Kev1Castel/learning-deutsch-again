using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Deutsch_Again
{
    class ClassPhrase
    {
        private Dictionary<string, string> dictVerb = new Dictionary<string, string>();

        private Dictionary<string, string> dictDeterminant = new Dictionary<string, string>();

        private List<string> listDeTerm = new List<string>();

        string timeVerb = null;

        ClassPhrase()
        {
            SetdictVerb();
        }

        private void SetdictVerb()
        {
            listDeTerm.Add("e");
            listDeTerm.Add("st");
            listDeTerm.Add("t");
            listDeTerm.Add("en");
            listDeTerm.Add("t");
            listDeTerm.Add("en");
            

            dictVerb.Add("schpreschen","parler");
            dictVerb.Add("fahr","fahren");
            dictVerb.Add("geh","gehen");
        }
    }
}
