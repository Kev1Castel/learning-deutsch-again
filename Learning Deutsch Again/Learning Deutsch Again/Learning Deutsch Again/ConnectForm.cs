using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_Deutsch_Again
{
    public partial class FormConnect : Form
    {
        //private ClassUser user = new ClassUser();

        public FormConnect()
        {
            InitializeComponent();
            List<string> listComplete = new List<string>();
        }

        public void SetAutoCompleteSource(List<string> listSource)
        {
            foreach(string element in listSource)
            {
                textBoxProfilName.AutoCompleteCustomSource.Add(element);                
            }
        }

        public void ActiveThisForm(string profilName, string password)
        {
            textBoxProfilName.Text = profilName;
            textBoxPassword.Text = password;
        }

        private void Connect()
        {
        }

        private void FormConnect_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxProfilName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
