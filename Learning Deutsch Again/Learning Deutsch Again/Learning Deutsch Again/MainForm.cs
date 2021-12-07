/*
 * Crée par SharpDevelop.
 * Utilisateur: Kev1
 * Date: 20/02/2021
 * Heure: 19:52
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.IO;

namespace Learning_Deutsch_Again
{
    public partial class MainForm : Form
    {
        private ClassQuizz quizz = new ClassQuizz();
        
        protected ClassUser user = new ClassUser();

        Boolean doesSessionStarted = false;
        private Random indexRnm = new Random();

        string quizzName;

        bool doesUserIsConnect = true;

        bool doesDevelopperModeIsActive = false;
        string message = "";    


        public MainForm()
        {
            InitializeComponent();
            StopSessionToolStripMenuItem.Visible = false;
            string pathExe = Application.ExecutablePath;
            pathExe = pathExe.Replace("Learning Deutsch Again.exe", "Ressource");
            user.LoadProfile(pathExe);

        }

        private void ErrorTopLevel()
        {
/*            Form ErrorTopLevel = new Form();
            ErrorTopLevel.Text = message;*/
        }

        public void setLanguage(string lang = null)
        {
            string path = Directory.GetCurrentDirectory();
            string filePath = path + @"data\ressources\lang.xml";
            bool fileExists = File.Exists(filePath);
            bool directoryExists = Directory.Exists(path);
            if (fileExists == true) 
            { 
                XDocument xmlDoc = XDocument.Load(path);
                var list = xmlDoc.Root.Elements("id")
                                           .Select(element => element.Value)
                                           .ToList();

            } else if (directoryExists == false) {
                //ErrorTopLevel("Dossier n'existe pas");
            } else if (fileExists == false) {
                //ErrorTopLevel("Fichier n'existe pas");
            }
        }

        private void SetBalloonTip(string message = null)
        {
            /* 
            Cette fonction est utilisé pour afficher des Notification
            Param:
                message = message corp à afficher dans la notification
             */
            notifyIconDebug.Icon = SystemIcons.Exclamation;
            notifyIconDebug.BalloonTipTitle = "Dev Mode";
            notifyIconDebug.BalloonTipText = message;
            notifyIconDebug.Text = message;
            notifyIconDebug.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIconDebug.Visible = true;
            notifyIconDebug.ShowBalloonTip(1000);
        }

        private void CountLineLabelResuot()
        {
            int countLineLabelResult = labelResult.Lines.Where(line => !String.IsNullOrWhiteSpace(line)).Count();
        }

        public void Quizz(string typeQuestion = null)
        {
            /*
             Cette fonction sert à démarerr ou nn un quizz. 
            */
            if (this.doesSessionStarted == true)
            {
                buttonValidAnswer.Enabled = false;
                pronomToolStripMenuItem.Visible = true;
                CardinalnumberToolStripMenuItem.Visible = true;
                numberToolStripMenuItem.Visible = true;
                MainMenuCommandGestionQuizz.Visible = true;
                StopSessionToolStripMenuItem.Visible = false;
                this.doesSessionStarted = false;
                LabelQuestion.Text = "Question";
                textBoxUser.Text = "";
                quizz.SetOffQuizz();
            } else {
                buttonValidAnswer.Enabled = true;
                pronomToolStripMenuItem.Visible = false;
                CardinalnumberToolStripMenuItem.Visible = false;
                numberToolStripMenuItem.Visible = false;
                MainMenuCommandGestionQuizz.Visible = false;
                StopSessionToolStripMenuItem.Visible = true;
                this.doesSessionStarted = true;
                message = quizz.StartQuizz(typeQuestion);
                LabelQuestion.Text = "Quel est la traduction de '" + message + "' en Allemand?";
                if (doesDevelopperModeIsActive)
                {
                    SetBalloonTip(quizz.answer);
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = textBoxUser.Text.ToLower();
                if (text == "quizz.start_pronom")
                {
                    quizzName = "Pronom";
                    Quizz();
                }
                else if (text == "quizz.start_num")
                {
                    quizzName = "Nombre";
                    Quizz();
                }
                else if (text == "quizz.start_cnum")
                {
                    quizzName = "NombreC";
                    Quizz();
                }
            }
        }		
		
		void StopSessionToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (doesSessionStarted==true)
			{
				this.Quizz();
			}
		}
        
        private void SetLabelReslut(string text)
        {
            /*
             Cette fonction sert à actualiser le label indquant les questions
            réussistes ou non.
             */
            labelResult.Text = text;
            CountLineLabelResuot();
        }
        void ButtonGetSessionClick(object sender, EventArgs e)
        {
            bool doesAnswerWasRight = false;
            string text = textBoxUser.Text.ToLower();
            string message;
            string question;
            if (text == "dev.enable_y")
            {
                SetBalloonTip("Mode Dev Activer");
                doesDevelopperModeIsActive = true;
            } else if (text == "dev.enable_n") {
                doesDevelopperModeIsActive = false;
                SetBalloonTip("Mode Dev Désactiver");
            } else if (text == "dev.show_answer" & doesDevelopperModeIsActive == true & doesSessionStarted == true) {
                SetBalloonTip();
            } else if (text == "quizz.start_pronom") {
                quizzName = "Pronom";
                Quizz();
            } else if (text == "quizz.start_num") {
                quizzName = "Nombre";
                Quizz();
            } else if (text == "quizz.start_cnum") {
                quizzName = "NombreC";
                Quizz();
            } else if (text == "stop") {
                Quizz();
            }  else if (text == "pass") {
                quizz.AddQuestionToListQuestionPassed();
                message = quizz.GetQuestionDid();
                quizz.ChooseQuestion();
                SetLabelReslut(message);
                question = "Traduis \"" + quizz.ChooseQuestion() + "\" en Allemand";
                if (question.Contains("end"))
                {
                    question = "Question";
                    Quizz();
                } else {
                    textBoxUser.Text = "";
                }
                LabelQuestion.Text = question;

            } else {
                doesAnswerWasRight = quizz.CheckQuestion(text);
                message = quizz.GetQuestionDid();
                SetLabelReslut(message);
                question = "Traduis \"" + quizz.ChooseQuestion() + "\" en Allemand" ;
                if (question.Contains("end"))
                {
                    question = "Question";
                    Quizz();
                } else {
                    textBoxUser.Text = "";
                }
                if (doesDevelopperModeIsActive) {
                    SetBalloonTip(quizz.answer);
                }
                LabelQuestion.Text = question;                
			}
		}

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setLanguage("fr");
        }

        private void enToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setLanguage("en");
        }

        private void frToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setLanguage("fr");
        }

        private void TopLevelConnect()
        {
            string password = string.Empty;
            string username = string.Empty;
            user.GetProfilConnected(out username, out password);
            FormConnect childWin = new FormConnect();
            childWin.ActiveThisForm(profilName: username, password:password);
            List<string> listSource = new List<string>();
            listSource = user.GetAllSessionName();
            childWin.SetAutoCompleteSource(listSource);
            childWin.ShowDialog();
        }

        private void sinscrireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopLevelConnect();
        }

        public void DisconnectUser()
        {

        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void couleurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quizz(typeQuestion:"Color");
        }

        private void gramaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quizz(typeQuestion:"Grammaire");

        }

        void PronomToolStripMenuItemClick(object sender, EventArgs e)
        {
            Quizz("Pronom");
        }

        void NombreToolStripMenuItemClick(object sender, EventArgs e)
        {
            Quizz("Nombre");
        }

        void NombreCardinauxToolStripMenuItemClick(object sender, EventArgs e)
        {
            Quizz("NombreC");
        }

        private void MainMenuCommandGestionQuizz_Click(object sender, EventArgs e)
        {

        }

        private void LabelQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}