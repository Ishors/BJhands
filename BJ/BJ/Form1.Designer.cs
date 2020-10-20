namespace BJ
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.textBox_Ienks = new System.Windows.Forms.TextBox();
            this.textBox_Croupier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Win = new System.Windows.Forms.Button();
            this.button_Loss = new System.Windows.Forms.Button();
            this.button_oups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Ienks
            // 
            this.textBox_Ienks.Location = new System.Drawing.Point(68, 166);
            this.textBox_Ienks.Name = "textBox_Ienks";
            this.textBox_Ienks.Size = new System.Drawing.Size(100, 22);
            this.textBox_Ienks.TabIndex = 2;
            this.textBox_Ienks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Ienks_KeyDown);
            // 
            // textBox_Croupier
            // 
            this.textBox_Croupier.Location = new System.Drawing.Point(365, 166);
            this.textBox_Croupier.Name = "textBox_Croupier";
            this.textBox_Croupier.Size = new System.Drawing.Size(100, 22);
            this.textBox_Croupier.TabIndex = 3;
            this.textBox_Croupier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Croupier_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ienks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Croupier";
            // 
            // button_Win
            // 
            this.button_Win.Location = new System.Drawing.Point(214, 227);
            this.button_Win.Name = "button_Win";
            this.button_Win.Size = new System.Drawing.Size(103, 49);
            this.button_Win.TabIndex = 6;
            this.button_Win.Text = "Win";
            this.button_Win.UseVisualStyleBackColor = true;
            this.button_Win.Click += new System.EventHandler(this.button_Win_Click);
            // 
            // button_Loss
            // 
            this.button_Loss.Location = new System.Drawing.Point(214, 295);
            this.button_Loss.Name = "button_Loss";
            this.button_Loss.Size = new System.Drawing.Size(103, 48);
            this.button_Loss.TabIndex = 7;
            this.button_Loss.Text = "Loss";
            this.button_Loss.UseVisualStyleBackColor = true;
            this.button_Loss.Click += new System.EventHandler(this.button_Loss_Click);
            // 
            // button_oups
            // 
            this.button_oups.Location = new System.Drawing.Point(444, 365);
            this.button_oups.Name = "button_oups";
            this.button_oups.Size = new System.Drawing.Size(99, 32);
            this.button_oups.TabIndex = 8;
            this.button_oups.Text = "oups";
            this.button_oups.UseVisualStyleBackColor = true;
            this.button_oups.Click += new System.EventHandler(this.button_oups_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 430);
            this.Controls.Add(this.button_oups);
            this.Controls.Add(this.button_Loss);
            this.Controls.Add(this.button_Win);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Croupier);
            this.Controls.Add(this.textBox_Ienks);
            this.Name = "Form1";
            this.Text = "BlackJack du Ienks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox textBox_Ienks;
        private System.Windows.Forms.TextBox textBox_Croupier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Win;
        private System.Windows.Forms.Button button_Loss;
        private System.Windows.Forms.Button button_oups;
    }
}

