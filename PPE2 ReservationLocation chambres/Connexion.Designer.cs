namespace PPE2_ReservationLocation_chambres
{
    partial class ConnexionForm
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
            this.btConnect = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblMDP = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.ErreurUtilis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(442, 342);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(101, 23);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connexion";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btAdminConnect_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 117);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(295, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Fizuaal";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(128, 199);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(295, 20);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.Text = "1998killian";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(125, 183);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(74, 13);
            this.lblMDP.TabIndex = 4;
            this.lblMDP.Text = "Mot de passe:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(125, 101);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Nom d\'utilisateur:";
            // 
            // ErreurUtilis
            // 
            this.ErreurUtilis.AutoSize = true;
            this.ErreurUtilis.ForeColor = System.Drawing.Color.Crimson;
            this.ErreurUtilis.Location = new System.Drawing.Point(147, 257);
            this.ErreurUtilis.Name = "ErreurUtilis";
            this.ErreurUtilis.Size = new System.Drawing.Size(256, 13);
            this.ErreurUtilis.TabIndex = 6;
            this.ErreurUtilis.Text = "Le nom d\'utilisateur ou le mot de passe est incorrecte";
            this.ErreurUtilis.Visible = false;
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 377);
            this.Controls.Add(this.ErreurUtilis);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btConnect);
            this.Name = "ConnexionForm";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label ErreurUtilis;
    }
}

