namespace PPE2_ReservationLocation_chambres
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
            this.btClientConnect = new System.Windows.Forms.Button();
            this.btAdminConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btClientConnect
            // 
            this.btClientConnect.Location = new System.Drawing.Point(57, 33);
            this.btClientConnect.Name = "btClientConnect";
            this.btClientConnect.Size = new System.Drawing.Size(140, 23);
            this.btClientConnect.TabIndex = 0;
            this.btClientConnect.Text = "Connexion Client";
            this.btClientConnect.UseVisualStyleBackColor = true;
            // 
            // btAdminConnect
            // 
            this.btAdminConnect.Location = new System.Drawing.Point(57, 62);
            this.btAdminConnect.Name = "btAdminConnect";
            this.btAdminConnect.Size = new System.Drawing.Size(140, 23);
            this.btAdminConnect.TabIndex = 1;
            this.btAdminConnect.Text = "Connexion Admin";
            this.btAdminConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 377);
            this.Controls.Add(this.btAdminConnect);
            this.Controls.Add(this.btClientConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClientConnect;
        private System.Windows.Forms.Button btAdminConnect;
    }
}

