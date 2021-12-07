/*
 * Crée par SharpDevelop.
 * Utilisateur: Kev1
 * Date: 20/02/2021
 * Heure: 19:52
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Learning_Deutsch_Again
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.MainMenuCascadeApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuCascadeQuizz = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuCommandGestionQuizz = new System.Windows.Forms.ToolStripMenuItem();
            this.pronomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CardinalnumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gramaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonValidAnswer = new System.Windows.Forms.Button();
            this.notifyIconDebug = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelResult = new System.Windows.Forms.TextBox();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuCascadeApplication,
            this.MainMenuCascadeQuizz,
            this.guestToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(386, 33);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // MainMenuCascadeApplication
            // 
            this.MainMenuCascadeApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.MainMenuCascadeApplication.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuCascadeApplication.Name = "MainMenuCascadeApplication";
            this.MainMenuCascadeApplication.Size = new System.Drawing.Size(118, 29);
            this.MainMenuCascadeApplication.Text = "Application";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.ExitToolStripMenuItem.Text = "Quitter";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // MainMenuCascadeQuizz
            // 
            this.MainMenuCascadeQuizz.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuCommandGestionQuizz,
            this.StopSessionToolStripMenuItem});
            this.MainMenuCascadeQuizz.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuCascadeQuizz.Name = "MainMenuCascadeQuizz";
            this.MainMenuCascadeQuizz.Size = new System.Drawing.Size(72, 29);
            this.MainMenuCascadeQuizz.Text = "Quizz";
            // 
            // MainMenuCommandGestionQuizz
            // 
            this.MainMenuCommandGestionQuizz.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainMenuCommandGestionQuizz.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pronomToolStripMenuItem,
            this.numberToolStripMenuItem,
            this.CardinalnumberToolStripMenuItem,
            this.couleurToolStripMenuItem,
            this.gramaireToolStripMenuItem});
            this.MainMenuCommandGestionQuizz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenuCommandGestionQuizz.Name = "MainMenuCommandGestionQuizz";
            this.MainMenuCommandGestionQuizz.Size = new System.Drawing.Size(285, 34);
            this.MainMenuCommandGestionQuizz.Text = "Démarrer une session";
            this.MainMenuCommandGestionQuizz.Click += new System.EventHandler(this.MainMenuCommandGestionQuizz_Click);
            // 
            // pronomToolStripMenuItem
            // 
            this.pronomToolStripMenuItem.Name = "pronomToolStripMenuItem";
            this.pronomToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pronomToolStripMenuItem.Text = "Pronom Personnel";
            this.pronomToolStripMenuItem.Click += new System.EventHandler(this.PronomToolStripMenuItemClick);
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.numberToolStripMenuItem.Text = "Nombre";
            this.numberToolStripMenuItem.Click += new System.EventHandler(this.NombreToolStripMenuItemClick);
            // 
            // CardinalnumberToolStripMenuItem
            // 
            this.CardinalnumberToolStripMenuItem.Name = "CardinalnumberToolStripMenuItem";
            this.CardinalnumberToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.CardinalnumberToolStripMenuItem.Text = "Nombre Cardinaux";
            this.CardinalnumberToolStripMenuItem.Click += new System.EventHandler(this.NombreCardinauxToolStripMenuItemClick);
            // 
            // couleurToolStripMenuItem
            // 
            this.couleurToolStripMenuItem.Name = "couleurToolStripMenuItem";
            this.couleurToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.couleurToolStripMenuItem.Text = "Couleur";
            this.couleurToolStripMenuItem.Click += new System.EventHandler(this.couleurToolStripMenuItem_Click);
            // 
            // gramaireToolStripMenuItem
            // 
            this.gramaireToolStripMenuItem.Name = "gramaireToolStripMenuItem";
            this.gramaireToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gramaireToolStripMenuItem.Text = "Grammaire";
            this.gramaireToolStripMenuItem.Click += new System.EventHandler(this.gramaireToolStripMenuItem_Click);
            // 
            // StopSessionToolStripMenuItem
            // 
            this.StopSessionToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StopSessionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StopSessionToolStripMenuItem.Name = "StopSessionToolStripMenuItem";
            this.StopSessionToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.StopSessionToolStripMenuItem.Text = "Arreter la session";
            this.StopSessionToolStripMenuItem.Click += new System.EventHandler(this.StopSessionToolStripMenuItemClick);
            // 
            // guestToolStripMenuItem
            // 
            this.guestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem});
            this.guestToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F);
            this.guestToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.guestToolStripMenuItem.Name = "guestToolStripMenuItem";
            this.guestToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.guestToolStripMenuItem.Text = "Guest";
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.seConnecterToolStripMenuItem.Text = "Compte";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuestion.Location = new System.Drawing.Point(13, 41);
            this.LabelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(365, 39);
            this.LabelQuestion.TabIndex = 1;
            this.LabelQuestion.Text = "Question";
            this.LabelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelQuestion.Click += new System.EventHandler(this.LabelQuestion_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.textBoxUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUser.Location = new System.Drawing.Point(11, 94);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUser.MaxLength = 30;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(365, 29);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 210);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(386, 32);
            this.statusStripMain.TabIndex = 3;
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolStripStatusLabelStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(83, 25);
            this.toolStripStatusLabelStatus.Text = "Bienvenu";
            // 
            // buttonValidAnswer
            // 
            this.buttonValidAnswer.BackColor = System.Drawing.Color.Gray;
            this.buttonValidAnswer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonValidAnswer.FlatAppearance.BorderSize = 0;
            this.buttonValidAnswer.Location = new System.Drawing.Point(255, 144);
            this.buttonValidAnswer.Name = "buttonValidAnswer";
            this.buttonValidAnswer.Size = new System.Drawing.Size(119, 36);
            this.buttonValidAnswer.TabIndex = 4;
            this.buttonValidAnswer.Text = "Valider";
            this.buttonValidAnswer.UseVisualStyleBackColor = false;
            this.buttonValidAnswer.Click += new System.EventHandler(this.ButtonGetSessionClick);
            // 
            // notifyIconDebug
            // 
            this.notifyIconDebug.Text = "Debugger Mode";
            this.notifyIconDebug.Visible = true;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelResult.Location = new System.Drawing.Point(12, 130);
            this.labelResult.Multiline = true;
            this.labelResult.Name = "labelResult";
            this.labelResult.ReadOnly = true;
            this.labelResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.labelResult.Size = new System.Drawing.Size(227, 76);
            this.labelResult.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(386, 242);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonValidAnswer);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.LabelQuestion);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximumSize = new System.Drawing.Size(408, 298);
            this.MinimumSize = new System.Drawing.Size(408, 298);
            this.Name = "MainForm";
            this.Text = "Learning Deutsch Again";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.NotifyIcon notifyIconDebug;
		private System.Windows.Forms.ToolStripMenuItem StopSessionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CardinalnumberToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem numberToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pronomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MainMenuCommandGestionQuizz;
		private System.Windows.Forms.ToolStripMenuItem MainMenuCascadeQuizz;
		private System.Windows.Forms.Button buttonValidAnswer;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.Label LabelQuestion;
		private System.Windows.Forms.ToolStripMenuItem MainMenuCascadeApplication;
		private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TextBox labelResult;
        private System.Windows.Forms.ToolStripMenuItem guestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couleurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gramaireToolStripMenuItem;
    }
}
