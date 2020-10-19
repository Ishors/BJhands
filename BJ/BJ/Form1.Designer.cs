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
            this.button_as = new System.Windows.Forms.Button();
            this.button_ienks = new System.Windows.Forms.Button();
            this.button_croupier = new System.Windows.Forms.Button();
            this.button_loose = new System.Windows.Forms.Button();
            this.buttonwin = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_10 = new System.Windows.Forms.Button();
            this.button_valet = new System.Windows.Forms.Button();
            this.button_dame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_roi = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_as
            // 
            this.button_as.Location = new System.Drawing.Point(12, 174);
            this.button_as.Name = "button_as";
            this.button_as.Size = new System.Drawing.Size(68, 59);
            this.button_as.TabIndex = 12;
            this.button_as.Text = "As";
            this.button_as.UseVisualStyleBackColor = true;
            this.button_as.Click += new System.EventHandler(this.button_as_Click);
            // 
            // button_ienks
            // 
            this.button_ienks.Location = new System.Drawing.Point(12, 292);
            this.button_ienks.Name = "button_ienks";
            this.button_ienks.Size = new System.Drawing.Size(161, 45);
            this.button_ienks.TabIndex = 13;
            this.button_ienks.Text = "Ienks";
            this.button_ienks.UseVisualStyleBackColor = true;
            this.button_ienks.Click += new System.EventHandler(this.button_ienks_Click);
            // 
            // button_croupier
            // 
            this.button_croupier.Location = new System.Drawing.Point(384, 292);
            this.button_croupier.Name = "button_croupier";
            this.button_croupier.Size = new System.Drawing.Size(161, 45);
            this.button_croupier.TabIndex = 14;
            this.button_croupier.Text = "Croupier";
            this.button_croupier.UseVisualStyleBackColor = true;
            this.button_croupier.Click += new System.EventHandler(this.button_croupier_Click);
            // 
            // button_loose
            // 
            this.button_loose.Location = new System.Drawing.Point(198, 344);
            this.button_loose.Name = "button_loose";
            this.button_loose.Size = new System.Drawing.Size(161, 45);
            this.button_loose.TabIndex = 16;
            this.button_loose.Text = "Loose";
            this.button_loose.UseVisualStyleBackColor = true;
            this.button_loose.Click += new System.EventHandler(this.button_loose_Click);
            // 
            // buttonwin
            // 
            this.buttonwin.Location = new System.Drawing.Point(198, 251);
            this.buttonwin.Name = "buttonwin";
            this.buttonwin.Size = new System.Drawing.Size(161, 45);
            this.buttonwin.TabIndex = 17;
            this.buttonwin.Text = "Win";
            this.buttonwin.UseVisualStyleBackColor = true;
            this.buttonwin.Click += new System.EventHandler(this.buttonwin_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(12, 96);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(68, 59);
            this.button_8.TabIndex = 6;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(105, 96);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(68, 59);
            this.button_9.TabIndex = 7;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_10
            // 
            this.button_10.Location = new System.Drawing.Point(198, 96);
            this.button_10.Name = "button_10";
            this.button_10.Size = new System.Drawing.Size(68, 59);
            this.button_10.TabIndex = 8;
            this.button_10.Text = "10";
            this.button_10.UseVisualStyleBackColor = true;
            this.button_10.Click += new System.EventHandler(this.button_10_Click);
            // 
            // button_valet
            // 
            this.button_valet.Location = new System.Drawing.Point(291, 96);
            this.button_valet.Name = "button_valet";
            this.button_valet.Size = new System.Drawing.Size(68, 59);
            this.button_valet.TabIndex = 9;
            this.button_valet.Text = "Valet";
            this.button_valet.UseVisualStyleBackColor = true;
            this.button_valet.Click += new System.EventHandler(this.button_valet_Click);
            // 
            // button_dame
            // 
            this.button_dame.Location = new System.Drawing.Point(384, 96);
            this.button_dame.Name = "button_dame";
            this.button_dame.Size = new System.Drawing.Size(68, 59);
            this.button_dame.TabIndex = 10;
            this.button_dame.Text = "Dame";
            this.button_dame.UseVisualStyleBackColor = true;
            this.button_dame.Click += new System.EventHandler(this.button_dame_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 18;
            this.button1.Text = "Raté";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_roi
            // 
            this.button_roi.Location = new System.Drawing.Point(477, 96);
            this.button_roi.Name = "button_roi";
            this.button_roi.Size = new System.Drawing.Size(68, 59);
            this.button_roi.TabIndex = 11;
            this.button_roi.Text = "Roi";
            this.button_roi.UseVisualStyleBackColor = true;
            this.button_roi.Click += new System.EventHandler(this.button_roi_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(477, 12);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(68, 59);
            this.button_7.TabIndex = 5;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(384, 12);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(68, 59);
            this.button_6.TabIndex = 4;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(291, 12);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(68, 59);
            this.button_5.TabIndex = 3;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(198, 12);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(68, 59);
            this.button_4.TabIndex = 2;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(105, 12);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(68, 59);
            this.button_3.TabIndex = 1;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(12, 12);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(68, 59);
            this.button_2.TabIndex = 0;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonwin);
            this.Controls.Add(this.button_loose);
            this.Controls.Add(this.button_croupier);
            this.Controls.Add(this.button_ienks);
            this.Controls.Add(this.button_as);
            this.Controls.Add(this.button_roi);
            this.Controls.Add(this.button_dame);
            this.Controls.Add(this.button_valet);
            this.Controls.Add(this.button_10);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Name = "Form1";
            this.Text = "BlackJack du Ienks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button_as;
        private System.Windows.Forms.Button button_ienks;
        private System.Windows.Forms.Button button_croupier;
        private System.Windows.Forms.Button button_loose;
        private System.Windows.Forms.Button buttonwin;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_10;
        private System.Windows.Forms.Button button_valet;
        private System.Windows.Forms.Button button_dame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_roi;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
    }
}

