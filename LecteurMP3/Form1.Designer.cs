namespace LecteurMP3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonChoix = new System.Windows.Forms.Button();
            this.buttonLecture = new System.Windows.Forms.Button();
            this.buttonTitres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.repertoire = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChoix
            // 
            this.buttonChoix.Location = new System.Drawing.Point(29, 37);
            this.buttonChoix.Name = "buttonChoix";
            this.buttonChoix.Size = new System.Drawing.Size(186, 37);
            this.buttonChoix.TabIndex = 0;
            this.buttonChoix.Text = "Choix du Répertoire";
            this.buttonChoix.UseVisualStyleBackColor = true;
            this.buttonChoix.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLecture
            // 
            this.buttonLecture.Location = new System.Drawing.Point(276, 37);
            this.buttonLecture.Name = "buttonLecture";
            this.buttonLecture.Size = new System.Drawing.Size(131, 36);
            this.buttonLecture.TabIndex = 1;
            this.buttonLecture.Text = "Lecture";
            this.buttonLecture.UseVisualStyleBackColor = true;
            this.buttonLecture.Click += new System.EventHandler(this.buttonLecture_Click);
            // 
            // buttonTitres
            // 
            this.buttonTitres.Location = new System.Drawing.Point(470, 37);
            this.buttonTitres.Name = "buttonTitres";
            this.buttonTitres.Size = new System.Drawing.Size(128, 36);
            this.buttonTitres.TabIndex = 2;
            this.buttonTitres.Text = "Liste des Titres";
            this.buttonTitres.UseVisualStyleBackColor = true;
            this.buttonTitres.Click += new System.EventHandler(this.buttonTitres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Répertoire actuel :";
            // 
            // repertoire
            // 
            this.repertoire.AutoSize = true;
            this.repertoire.Location = new System.Drawing.Point(161, 119);
            this.repertoire.Name = "repertoire";
            this.repertoire.Size = new System.Drawing.Size(0, 17);
            this.repertoire.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titre En Cours de Lecture :";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(32, 234);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(586, 48);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(215, 172);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(0, 17);
            this.labelTitre.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 476);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.repertoire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTitres);
            this.Controls.Add(this.buttonLecture);
            this.Controls.Add(this.buttonChoix);
            this.Name = "Form1";
            this.Text = "Lecteur MP3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChoix;
        private System.Windows.Forms.Button buttonLecture;
        private System.Windows.Forms.Button buttonTitres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label repertoire;
        private System.Windows.Forms.Label label2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label labelTitre;
    }
}

