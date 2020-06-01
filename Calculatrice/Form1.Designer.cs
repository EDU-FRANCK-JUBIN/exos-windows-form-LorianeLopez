namespace Calculatrice
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.number_9 = new System.Windows.Forms.Button();
            this.number_8 = new System.Windows.Forms.Button();
            this.number_7 = new System.Windows.Forms.Button();
            this.button_sous = new System.Windows.Forms.Button();
            this.number_6 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.number_3 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_1 = new System.Windows.Forms.Button();
            this.button_egal = new System.Windows.Forms.Button();
            this.button_virg = new System.Windows.Forms.Button();
            this.number_0 = new System.Windows.Forms.Button();
            this.button_mystery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(52, 49);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(350, 115);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_CE
            // 
            this.button_CE.Location = new System.Drawing.Point(52, 188);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(67, 43);
            this.button_CE.TabIndex = 1;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(153, 188);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(65, 43);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "C";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(248, 188);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(67, 43);
            this.button_remove.TabIndex = 3;
            this.button_remove.Text = "<--";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(336, 188);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(66, 43);
            this.button_div.TabIndex = 4;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_mult
            // 
            this.button_mult.Location = new System.Drawing.Point(336, 264);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(66, 43);
            this.button_mult.TabIndex = 8;
            this.button_mult.Text = "*";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // number_9
            // 
            this.number_9.Location = new System.Drawing.Point(248, 264);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(67, 43);
            this.number_9.TabIndex = 7;
            this.number_9.Text = "9";
            this.number_9.UseVisualStyleBackColor = true;
            this.number_9.Click += new System.EventHandler(this.number_9_Click);
            // 
            // number_8
            // 
            this.number_8.Location = new System.Drawing.Point(153, 264);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(65, 43);
            this.number_8.TabIndex = 6;
            this.number_8.Text = "8";
            this.number_8.UseVisualStyleBackColor = true;
            this.number_8.Click += new System.EventHandler(this.number_8_Click);
            // 
            // number_7
            // 
            this.number_7.Location = new System.Drawing.Point(52, 264);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(67, 43);
            this.number_7.TabIndex = 5;
            this.number_7.Text = "7";
            this.number_7.UseVisualStyleBackColor = true;
            this.number_7.Click += new System.EventHandler(this.number_7_Click);
            // 
            // button_sous
            // 
            this.button_sous.Location = new System.Drawing.Point(336, 329);
            this.button_sous.Name = "button_sous";
            this.button_sous.Size = new System.Drawing.Size(66, 43);
            this.button_sous.TabIndex = 12;
            this.button_sous.Text = "-";
            this.button_sous.UseVisualStyleBackColor = true;
            this.button_sous.Click += new System.EventHandler(this.button_sous_Click);
            // 
            // number_6
            // 
            this.number_6.Location = new System.Drawing.Point(248, 329);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(67, 43);
            this.number_6.TabIndex = 11;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = true;
            this.number_6.Click += new System.EventHandler(this.number_6_Click);
            // 
            // number_5
            // 
            this.number_5.Location = new System.Drawing.Point(153, 329);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(65, 43);
            this.number_5.TabIndex = 10;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = true;
            this.number_5.Click += new System.EventHandler(this.number_5_Click);
            // 
            // number_4
            // 
            this.number_4.Location = new System.Drawing.Point(52, 329);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(67, 43);
            this.number_4.TabIndex = 9;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = true;
            this.number_4.Click += new System.EventHandler(this.number_4_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(336, 395);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(66, 43);
            this.button_add.TabIndex = 16;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // number_3
            // 
            this.number_3.Location = new System.Drawing.Point(248, 395);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(67, 43);
            this.number_3.TabIndex = 15;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = true;
            this.number_3.Click += new System.EventHandler(this.number_3_Click);
            // 
            // number_2
            // 
            this.number_2.Location = new System.Drawing.Point(153, 395);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(65, 43);
            this.number_2.TabIndex = 14;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = true;
            this.number_2.Click += new System.EventHandler(this.number_2_Click);
            // 
            // number_1
            // 
            this.number_1.Location = new System.Drawing.Point(52, 395);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(67, 43);
            this.number_1.TabIndex = 13;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = true;
            this.number_1.Click += new System.EventHandler(this.number_1_Click);
            // 
            // button_egal
            // 
            this.button_egal.Location = new System.Drawing.Point(336, 470);
            this.button_egal.Name = "button_egal";
            this.button_egal.Size = new System.Drawing.Size(66, 43);
            this.button_egal.TabIndex = 20;
            this.button_egal.Text = "=";
            this.button_egal.UseVisualStyleBackColor = true;
            this.button_egal.Click += new System.EventHandler(this.button_egal_Click);
            // 
            // button_virg
            // 
            this.button_virg.Location = new System.Drawing.Point(248, 470);
            this.button_virg.Name = "button_virg";
            this.button_virg.Size = new System.Drawing.Size(67, 43);
            this.button_virg.TabIndex = 19;
            this.button_virg.Text = ",";
            this.button_virg.UseVisualStyleBackColor = true;
            this.button_virg.Click += new System.EventHandler(this.button_virg_Click);
            // 
            // number_0
            // 
            this.number_0.Location = new System.Drawing.Point(153, 470);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(65, 43);
            this.number_0.TabIndex = 18;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = true;
            this.number_0.Click += new System.EventHandler(this.number_0_Click);
            // 
            // button_mystery
            // 
            this.button_mystery.Location = new System.Drawing.Point(52, 470);
            this.button_mystery.Name = "button_mystery";
            this.button_mystery.Size = new System.Drawing.Size(67, 43);
            this.button_mystery.TabIndex = 17;
            this.button_mystery.Text = "+-";
            this.button_mystery.UseVisualStyleBackColor = true;
            this.button_mystery.Click += new System.EventHandler(this.button_mystery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_egal);
            this.Controls.Add(this.button_virg);
            this.Controls.Add(this.number_0);
            this.Controls.Add(this.button_mystery);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.number_3);
            this.Controls.Add(this.number_2);
            this.Controls.Add(this.number_1);
            this.Controls.Add(this.button_sous);
            this.Controls.Add(this.number_6);
            this.Controls.Add(this.number_5);
            this.Controls.Add(this.number_4);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.number_9);
            this.Controls.Add(this.number_8);
            this.Controls.Add(this.number_7);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.textBoxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button number_9;
        private System.Windows.Forms.Button number_8;
        private System.Windows.Forms.Button number_7;
        private System.Windows.Forms.Button button_sous;
        private System.Windows.Forms.Button number_6;
        private System.Windows.Forms.Button number_5;
        private System.Windows.Forms.Button number_4;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button number_3;
        private System.Windows.Forms.Button number_2;
        private System.Windows.Forms.Button number_1;
        private System.Windows.Forms.Button button_egal;
        private System.Windows.Forms.Button button_virg;
        private System.Windows.Forms.Button number_0;
        private System.Windows.Forms.Button button_mystery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

