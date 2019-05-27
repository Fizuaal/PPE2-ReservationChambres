namespace PPE2_ReservationLocation_chambres
{
    partial class ClientListChambresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbChambres = new System.Windows.Forms.ListBox();
            this.lblConnecte = new System.Windows.Forms.Label();
            this.lbDemandeReserv = new System.Windows.Forms.ListBox();
            this.lblDemandeReserv = new System.Windows.Forms.Label();
            this.lblChambresList = new System.Windows.Forms.Label();
            this.btDemandeReserv = new System.Windows.Forms.Button();
            this.btAccepter = new System.Windows.Forms.Button();
            this.btRefuser = new System.Windows.Forms.Button();
            this.btExpulser = new System.Windows.Forms.Button();
            this.btNewChambre = new System.Windows.Forms.Button();
            this.btSupprChambre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbChambres
            // 
            this.lbChambres.FormattingEnabled = true;
            this.lbChambres.Location = new System.Drawing.Point(653, 169);
            this.lbChambres.Name = "lbChambres";
            this.lbChambres.Size = new System.Drawing.Size(395, 368);
            this.lbChambres.TabIndex = 0;
            this.lbChambres.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblConnecte
            // 
            this.lblConnecte.AutoSize = true;
            this.lblConnecte.Location = new System.Drawing.Point(13, 13);
            this.lblConnecte.Name = "lblConnecte";
            this.lblConnecte.Size = new System.Drawing.Size(0, 13);
            this.lblConnecte.TabIndex = 1;
            // 
            // lbDemandeReserv
            // 
            this.lbDemandeReserv.FormattingEnabled = true;
            this.lbDemandeReserv.Location = new System.Drawing.Point(271, 169);
            this.lbDemandeReserv.Name = "lbDemandeReserv";
            this.lbDemandeReserv.Size = new System.Drawing.Size(376, 368);
            this.lbDemandeReserv.TabIndex = 2;
            // 
            // lblDemandeReserv
            // 
            this.lblDemandeReserv.AutoSize = true;
            this.lblDemandeReserv.Location = new System.Drawing.Point(374, 153);
            this.lblDemandeReserv.Name = "lblDemandeReserv";
            this.lblDemandeReserv.Size = new System.Drawing.Size(171, 13);
            this.lblDemandeReserv.TabIndex = 3;
            this.lblDemandeReserv.Text = "Liste des demandes de réservation";
            // 
            // lblChambresList
            // 
            this.lblChambresList.AutoSize = true;
            this.lblChambresList.Location = new System.Drawing.Point(789, 153);
            this.lblChambresList.Name = "lblChambresList";
            this.lblChambresList.Size = new System.Drawing.Size(153, 13);
            this.lblChambresList.TabIndex = 4;
            this.lblChambresList.Text = "Liste des chambres disponibles";
            // 
            // btDemandeReserv
            // 
            this.btDemandeReserv.Location = new System.Drawing.Point(653, 541);
            this.btDemandeReserv.Name = "btDemandeReserv";
            this.btDemandeReserv.Size = new System.Drawing.Size(189, 23);
            this.btDemandeReserv.TabIndex = 5;
            this.btDemandeReserv.Text = "Demander à réserver cette chambre";
            this.btDemandeReserv.UseVisualStyleBackColor = true;
            this.btDemandeReserv.Click += new System.EventHandler(this.btDemandeReserv_Click);
            // 
            // btAccepter
            // 
            this.btAccepter.Location = new System.Drawing.Point(271, 541);
            this.btAccepter.Name = "btAccepter";
            this.btAccepter.Size = new System.Drawing.Size(180, 23);
            this.btAccepter.TabIndex = 6;
            this.btAccepter.Text = "Accepter";
            this.btAccepter.UseVisualStyleBackColor = true;
            this.btAccepter.Click += new System.EventHandler(this.btAccepter_Click);
            // 
            // btRefuser
            // 
            this.btRefuser.Location = new System.Drawing.Point(457, 541);
            this.btRefuser.Name = "btRefuser";
            this.btRefuser.Size = new System.Drawing.Size(190, 23);
            this.btRefuser.TabIndex = 7;
            this.btRefuser.Text = "Refuser";
            this.btRefuser.UseVisualStyleBackColor = true;
            this.btRefuser.Click += new System.EventHandler(this.btRefuser_Click);
            // 
            // btExpulser
            // 
            this.btExpulser.Location = new System.Drawing.Point(859, 541);
            this.btExpulser.Name = "btExpulser";
            this.btExpulser.Size = new System.Drawing.Size(189, 23);
            this.btExpulser.TabIndex = 8;
            this.btExpulser.Text = "Expulser le résident";
            this.btExpulser.UseVisualStyleBackColor = true;
            this.btExpulser.Click += new System.EventHandler(this.btExpulser_Click);
            // 
            // btNewChambre
            // 
            this.btNewChambre.Location = new System.Drawing.Point(653, 541);
            this.btNewChambre.Name = "btNewChambre";
            this.btNewChambre.Size = new System.Drawing.Size(96, 23);
            this.btNewChambre.TabIndex = 9;
            this.btNewChambre.Text = "Ajouter Chambre";
            this.btNewChambre.UseVisualStyleBackColor = true;
            this.btNewChambre.Click += new System.EventHandler(this.btNewChambre_Click);
            // 
            // btSupprChambre
            // 
            this.btSupprChambre.Location = new System.Drawing.Point(755, 541);
            this.btSupprChambre.Name = "btSupprChambre";
            this.btSupprChambre.Size = new System.Drawing.Size(96, 23);
            this.btSupprChambre.TabIndex = 10;
            this.btSupprChambre.Text = "Retirer Chambre";
            this.btSupprChambre.UseVisualStyleBackColor = true;
            this.btSupprChambre.Click += new System.EventHandler(this.btSupprChambre_Click);
            // 
            // ClientListChambresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 576);
            this.Controls.Add(this.btSupprChambre);
            this.Controls.Add(this.btNewChambre);
            this.Controls.Add(this.btExpulser);
            this.Controls.Add(this.btRefuser);
            this.Controls.Add(this.btAccepter);
            this.Controls.Add(this.btDemandeReserv);
            this.Controls.Add(this.lblChambresList);
            this.Controls.Add(this.lblDemandeReserv);
            this.Controls.Add(this.lbDemandeReserv);
            this.Controls.Add(this.lblConnecte);
            this.Controls.Add(this.lbChambres);
            this.Name = "ClientListChambresForm";
            this.Text = "Liste des chambres";
            this.Load += new System.EventHandler(this.ClientListChambresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbChambres;
        private System.Windows.Forms.Label lblConnecte;
        private System.Windows.Forms.ListBox lbDemandeReserv;
        private System.Windows.Forms.Label lblDemandeReserv;
        private System.Windows.Forms.Label lblChambresList;
        private System.Windows.Forms.Button btDemandeReserv;
        private System.Windows.Forms.Button btAccepter;
        private System.Windows.Forms.Button btRefuser;
        private System.Windows.Forms.Button btExpulser;
        private System.Windows.Forms.Button btNewChambre;
        private System.Windows.Forms.Button btSupprChambre;
    }
}