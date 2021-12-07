using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Learning_Deutsch_Again
{
    public class ClassUser
    {
        private Dictionary<string, string> dictProfil = new Dictionary<string, string>();

        public string actualSessionName = "Guest";
        public string actualSessionPassword = "@Gues321";

        public void GetProfilConnected(out string username, out string password)
        {
            username = actualSessionName;
            password = actualSessionPassword;          
        }

        public List<string> GetAllSessionName()
        {
            List<string> listSession = new List<string>();
            foreach(KeyValuePair<string,string> key in dictProfil)
            {
                listSession.Add(key.Key);
            }
            return listSession;
        }
        
        public void LoadProfile(string path)
        {

            XmlDocument file = new XmlDocument();
            path += @"\profil.xml";
            file.Load(path);
            XmlNodeList root = file.ChildNodes;
            //XmlNodeList child = root[1].ChildNodes;
            foreach(XmlNode child in root)
            {
                foreach (XmlNode profil in child)
                {
                    XmlNodeList c = profil.ChildNodes;
                    XmlNode loginNode = c.Item(0);
                    XmlNode passwordNode = c.Item(1);
                    string login = loginNode.InnerText;
                    string password = passwordNode.InnerText;
                    dictProfil.Add(login, password);
                }
            }

        }
    }
}
