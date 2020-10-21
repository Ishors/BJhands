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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.textBox_Ienks = new System.Windows.Forms.TextBox();
            this.textBox_Croupier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Win = new System.Windows.Forms.Button();
            this.button_Loss = new System.Windows.Forms.Button();
            this.button_oups = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.textBox_nbrWin = new System.Windows.Forms.TextBox();
            this.textBox_nbrLoss = new System.Windows.Forms.TextBox();
            this.label_nbrWin = new System.Windows.Forms.Label();
            this.label_nbreLoss = new System.Windows.Forms.Label();
            this.label_ratio = new System.Windows.Forms.Label();
            this.textBox_ratio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Ienks
            // 
            this.textBox_Ienks.Location = new System.Drawing.Point(231, 52);
            this.textBox_Ienks.Name = "textBox_Ienks";
            this.textBox_Ienks.Size = new System.Drawing.Size(100, 22);
            this.textBox_Ienks.TabIndex = 2;
            this.textBox_Ienks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Ienks_KeyDown);
            // 
            // textBox_Croupier
            // 
            this.textBox_Croupier.Location = new System.Drawing.Point(231, 317);
            this.textBox_Croupier.Name = "textBox_Croupier";
            this.textBox_Croupier.Size = new System.Drawing.Size(100, 22);
            this.textBox_Croupier.TabIndex = 3;
            this.textBox_Croupier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Croupier_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ienks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Croupier";
            // 
            // button_Win
            // 
            this.button_Win.Location = new System.Drawing.Point(31, 238);
            this.button_Win.Name = "button_Win";
            this.button_Win.Size = new System.Drawing.Size(104, 55);
            this.button_Win.TabIndex = 6;
            this.button_Win.Text = "Win";
            this.button_Win.UseVisualStyleBackColor = true;
            this.button_Win.Click += new System.EventHandler(this.button_Win_Click);
            // 
            // button_Loss
            // 
            this.button_Loss.Location = new System.Drawing.Point(31, 126);
            this.button_Loss.Name = "button_Loss";
            this.button_Loss.Size = new System.Drawing.Size(105, 55);
            this.button_Loss.TabIndex = 7;
            this.button_Loss.Text = "Loss";
            this.button_Loss.UseVisualStyleBackColor = true;
            this.button_Loss.Click += new System.EventHandler(this.button_Loss_Click);
            // 
            // button_oups
            // 
            this.button_oups.Location = new System.Drawing.Point(12, 386);
            this.button_oups.Name = "button_oups";
            this.button_oups.Size = new System.Drawing.Size(99, 32);
            this.button_oups.TabIndex = 8;
            this.button_oups.Text = "oups";
            this.button_oups.UseVisualStyleBackColor = true;
            this.button_oups.Click += new System.EventHandler(this.button_oups_Click_1);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(447, 387);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(109, 31);
            this.button_reset.TabIndex = 9;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // textBox_nbrWin
            // 
            this.textBox_nbrWin.Location = new System.Drawing.Point(430, 159);
            this.textBox_nbrWin.Name = "textBox_nbrWin";
            this.textBox_nbrWin.ReadOnly = true;
            this.textBox_nbrWin.Size = new System.Drawing.Size(100, 22);
            this.textBox_nbrWin.TabIndex = 10;
            this.textBox_nbrWin.TextChanged += new System.EventHandler(this.textBox_nbrWin_TextChanged);
            // 
            // textBox_nbrLoss
            // 
            this.textBox_nbrLoss.Location = new System.Drawing.Point(431, 198);
            this.textBox_nbrLoss.Name = "textBox_nbrLoss";
            this.textBox_nbrLoss.ReadOnly = true;
            this.textBox_nbrLoss.Size = new System.Drawing.Size(100, 22);
            this.textBox_nbrLoss.TabIndex = 11;
            this.textBox_nbrLoss.TextChanged += new System.EventHandler(this.textBox_nbrLoss_TextChanged);
            // 
            // label_nbrWin
            // 
            this.label_nbrWin.AutoSize = true;
            this.label_nbrWin.Location = new System.Drawing.Point(372, 159);
            this.label_nbrWin.Name = "label_nbrWin";
            this.label_nbrWin.Size = new System.Drawing.Size(39, 17);
            this.label_nbrWin.TabIndex = 12;
            this.label_nbrWin.Text = "Wins";
            // 
            // label_nbreLoss
            // 
            this.label_nbreLoss.AutoSize = true;
            this.label_nbreLoss.Location = new System.Drawing.Point(372, 201);
            this.label_nbreLoss.Name = "label_nbreLoss";
            this.label_nbreLoss.Size = new System.Drawing.Size(53, 17);
            this.label_nbreLoss.TabIndex = 13;
            this.label_nbreLoss.Text = "Losses";
            // 
            // label_ratio
            // 
            this.label_ratio.AutoSize = true;
            this.label_ratio.Location = new System.Drawing.Point(372, 240);
            this.label_ratio.Name = "label_ratio";
            this.label_ratio.Size = new System.Drawing.Size(41, 17);
            this.label_ratio.TabIndex = 14;
            this.label_ratio.Text = "Ratio";
            // 
            // textBox_ratio
            // 
            this.textBox_ratio.Location = new System.Drawing.Point(431, 240);
            this.textBox_ratio.Name = "textBox_ratio";
            this.textBox_ratio.ReadOnly = true;
            this.textBox_ratio.Size = new System.Drawing.Size(100, 22);
            this.textBox_ratio.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 430);
            this.Controls.Add(this.textBox_ratio);
            this.Controls.Add(this.label_ratio);
            this.Controls.Add(this.label_nbreLoss);
            this.Controls.Add(this.label_nbrWin);
            this.Controls.Add(this.textBox_nbrLoss);
            this.Controls.Add(this.textBox_nbrWin);
            this.Controls.Add(this.button_reset);
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
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TextBox textBox_nbrWin;
        private System.Windows.Forms.TextBox textBox_nbrLoss;
        private System.Windows.Forms.Label label_nbrWin;
        private System.Windows.Forms.Label label_nbreLoss;
        private System.Windows.Forms.Label label_ratio;
        private System.Windows.Forms.TextBox textBox_ratio;
    }
}

