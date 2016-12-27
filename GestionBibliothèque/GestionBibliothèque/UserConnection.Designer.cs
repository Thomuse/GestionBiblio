namespace GestionBibliothèque
{
    partial class UserConnection
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
            this.o_DatagridView = new System.Windows.Forms.DataGridView();
            this.label_ID_Lecteur = new System.Windows.Forms.Label();
            this.textBox_Id_Lecteur = new System.Windows.Forms.TextBox();
            this.button_ListeEmprunts_By_ID = new System.Windows.Forms.Button();
            this.label_Pret = new System.Windows.Forms.Label();
            this.label_ID_Lecteur_Pret = new System.Windows.Forms.Label();
            this.textBox_ID_Lecteur_Pret = new System.Windows.Forms.TextBox();
            this.label_ID_Exemp_Pret = new System.Windows.Forms.Label();
            this.textBox_ID_Exemplaire = new System.Windows.Forms.TextBox();
            this.button_emprunter = new System.Windows.Forms.Button();
            this.label_Reserver = new System.Windows.Forms.Label();
            this.label_ID_Lecteur_Reservation = new System.Windows.Forms.Label();
            this.label_ID_Livre_Reservation = new System.Windows.Forms.Label();
            this.textBox_ID_Lecteur_Reservation = new System.Windows.Forms.TextBox();
            this.textBox_ID_Livre_Reservation = new System.Windows.Forms.TextBox();
            this.button_Reserver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.o_DatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // o_DatagridView
            // 
            this.o_DatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.o_DatagridView.Location = new System.Drawing.Point(371, 178);
            this.o_DatagridView.Name = "o_DatagridView";
            this.o_DatagridView.Size = new System.Drawing.Size(432, 277);
            this.o_DatagridView.TabIndex = 0;
            // 
            // label_ID_Lecteur
            // 
            this.label_ID_Lecteur.AutoSize = true;
            this.label_ID_Lecteur.Location = new System.Drawing.Point(419, 34);
            this.label_ID_Lecteur.Name = "label_ID_Lecteur";
            this.label_ID_Lecteur.Size = new System.Drawing.Size(57, 13);
            this.label_ID_Lecteur.TabIndex = 1;
            this.label_ID_Lecteur.Text = "ID Lecteur";
            // 
            // textBox_Id_Lecteur
            // 
            this.textBox_Id_Lecteur.Location = new System.Drawing.Point(522, 27);
            this.textBox_Id_Lecteur.Name = "textBox_Id_Lecteur";
            this.textBox_Id_Lecteur.Size = new System.Drawing.Size(100, 20);
            this.textBox_Id_Lecteur.TabIndex = 2;
            this.textBox_Id_Lecteur.TextChanged += new System.EventHandler(this.textBox_Id_Lecteur_TextChanged);
            // 
            // button_ListeEmprunts_By_ID
            // 
            this.button_ListeEmprunts_By_ID.Location = new System.Drawing.Point(522, 87);
            this.button_ListeEmprunts_By_ID.Name = "button_ListeEmprunts_By_ID";
            this.button_ListeEmprunts_By_ID.Size = new System.Drawing.Size(100, 40);
            this.button_ListeEmprunts_By_ID.TabIndex = 3;
            this.button_ListeEmprunts_By_ID.Text = "Liste de vos emprunts";
            this.button_ListeEmprunts_By_ID.UseVisualStyleBackColor = true;
            this.button_ListeEmprunts_By_ID.Click += new System.EventHandler(this.button_ListeEmprunts_By_ID_Click);
            // 
            // label_Pret
            // 
            this.label_Pret.AutoSize = true;
            this.label_Pret.Location = new System.Drawing.Point(98, 27);
            this.label_Pret.Name = "label_Pret";
            this.label_Pret.Size = new System.Drawing.Size(26, 13);
            this.label_Pret.TabIndex = 4;
            this.label_Pret.Text = "Prêt";
            // 
            // label_ID_Lecteur_Pret
            // 
            this.label_ID_Lecteur_Pret.AutoSize = true;
            this.label_ID_Lecteur_Pret.Location = new System.Drawing.Point(12, 68);
            this.label_ID_Lecteur_Pret.Name = "label_ID_Lecteur_Pret";
            this.label_ID_Lecteur_Pret.Size = new System.Drawing.Size(57, 13);
            this.label_ID_Lecteur_Pret.TabIndex = 5;
            this.label_ID_Lecteur_Pret.Text = "ID Lecteur";
            // 
            // textBox_ID_Lecteur_Pret
            // 
            this.textBox_ID_Lecteur_Pret.Location = new System.Drawing.Point(119, 61);
            this.textBox_ID_Lecteur_Pret.Name = "textBox_ID_Lecteur_Pret";
            this.textBox_ID_Lecteur_Pret.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID_Lecteur_Pret.TabIndex = 6;
            // 
            // label_ID_Exemp_Pret
            // 
            this.label_ID_Exemp_Pret.AutoSize = true;
            this.label_ID_Exemp_Pret.Location = new System.Drawing.Point(12, 114);
            this.label_ID_Exemp_Pret.Name = "label_ID_Exemp_Pret";
            this.label_ID_Exemp_Pret.Size = new System.Drawing.Size(72, 13);
            this.label_ID_Exemp_Pret.TabIndex = 7;
            this.label_ID_Exemp_Pret.Text = "ID Exemplaire";
            // 
            // textBox_ID_Exemplaire
            // 
            this.textBox_ID_Exemplaire.Location = new System.Drawing.Point(119, 107);
            this.textBox_ID_Exemplaire.Name = "textBox_ID_Exemplaire";
            this.textBox_ID_Exemplaire.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID_Exemplaire.TabIndex = 8;
            // 
            // button_emprunter
            // 
            this.button_emprunter.Location = new System.Drawing.Point(133, 157);
            this.button_emprunter.Name = "button_emprunter";
            this.button_emprunter.Size = new System.Drawing.Size(75, 23);
            this.button_emprunter.TabIndex = 9;
            this.button_emprunter.Text = "Emprunter";
            this.button_emprunter.UseVisualStyleBackColor = true;
            this.button_emprunter.Click += new System.EventHandler(this.button_emprunter_Click);
            // 
            // label_Reserver
            // 
            this.label_Reserver.AutoSize = true;
            this.label_Reserver.Location = new System.Drawing.Point(60, 218);
            this.label_Reserver.Name = "label_Reserver";
            this.label_Reserver.Size = new System.Drawing.Size(64, 13);
            this.label_Reserver.TabIndex = 10;
            this.label_Reserver.Text = "Réservation";
            // 
            // label_ID_Lecteur_Reservation
            // 
            this.label_ID_Lecteur_Reservation.AutoSize = true;
            this.label_ID_Lecteur_Reservation.Location = new System.Drawing.Point(12, 269);
            this.label_ID_Lecteur_Reservation.Name = "label_ID_Lecteur_Reservation";
            this.label_ID_Lecteur_Reservation.Size = new System.Drawing.Size(57, 13);
            this.label_ID_Lecteur_Reservation.TabIndex = 11;
            this.label_ID_Lecteur_Reservation.Text = "ID Lecteur";
            // 
            // label_ID_Livre_Reservation
            // 
            this.label_ID_Livre_Reservation.AutoSize = true;
            this.label_ID_Livre_Reservation.Location = new System.Drawing.Point(25, 306);
            this.label_ID_Livre_Reservation.Name = "label_ID_Livre_Reservation";
            this.label_ID_Livre_Reservation.Size = new System.Drawing.Size(44, 13);
            this.label_ID_Livre_Reservation.TabIndex = 12;
            this.label_ID_Livre_Reservation.Text = "ID Livre";
            // 
            // textBox_ID_Lecteur_Reservation
            // 
            this.textBox_ID_Lecteur_Reservation.Location = new System.Drawing.Point(92, 262);
            this.textBox_ID_Lecteur_Reservation.Name = "textBox_ID_Lecteur_Reservation";
            this.textBox_ID_Lecteur_Reservation.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID_Lecteur_Reservation.TabIndex = 13;
            // 
            // textBox_ID_Livre_Reservation
            // 
            this.textBox_ID_Livre_Reservation.Location = new System.Drawing.Point(92, 306);
            this.textBox_ID_Livre_Reservation.Name = "textBox_ID_Livre_Reservation";
            this.textBox_ID_Livre_Reservation.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID_Livre_Reservation.TabIndex = 14;
            // 
            // button_Reserver
            // 
            this.button_Reserver.Location = new System.Drawing.Point(101, 358);
            this.button_Reserver.Name = "button_Reserver";
            this.button_Reserver.Size = new System.Drawing.Size(75, 23);
            this.button_Reserver.TabIndex = 15;
            this.button_Reserver.Text = "Réserver";
            this.button_Reserver.UseVisualStyleBackColor = true;
            this.button_Reserver.Click += new System.EventHandler(this.button_Reserver_Click);
            // 
            // UserConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 467);
            this.Controls.Add(this.button_Reserver);
            this.Controls.Add(this.textBox_ID_Livre_Reservation);
            this.Controls.Add(this.textBox_ID_Lecteur_Reservation);
            this.Controls.Add(this.label_ID_Livre_Reservation);
            this.Controls.Add(this.label_ID_Lecteur_Reservation);
            this.Controls.Add(this.label_Reserver);
            this.Controls.Add(this.button_emprunter);
            this.Controls.Add(this.textBox_ID_Exemplaire);
            this.Controls.Add(this.label_ID_Exemp_Pret);
            this.Controls.Add(this.textBox_ID_Lecteur_Pret);
            this.Controls.Add(this.label_ID_Lecteur_Pret);
            this.Controls.Add(this.label_Pret);
            this.Controls.Add(this.button_ListeEmprunts_By_ID);
            this.Controls.Add(this.textBox_Id_Lecteur);
            this.Controls.Add(this.label_ID_Lecteur);
            this.Controls.Add(this.o_DatagridView);
            this.Name = "UserConnection";
            this.Text = "UserConnection";
            ((System.ComponentModel.ISupportInitialize)(this.o_DatagridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView o_DatagridView;
        private System.Windows.Forms.Label label_ID_Lecteur;
        private System.Windows.Forms.TextBox textBox_Id_Lecteur;
        private System.Windows.Forms.Button button_ListeEmprunts_By_ID;
        private System.Windows.Forms.Label label_Pret;
        private System.Windows.Forms.Label label_ID_Lecteur_Pret;
        private System.Windows.Forms.TextBox textBox_ID_Lecteur_Pret;
        private System.Windows.Forms.Label label_ID_Exemp_Pret;
        private System.Windows.Forms.TextBox textBox_ID_Exemplaire;
        private System.Windows.Forms.Button button_emprunter;
        private System.Windows.Forms.Label label_Reserver;
        private System.Windows.Forms.Label label_ID_Lecteur_Reservation;
        private System.Windows.Forms.Label label_ID_Livre_Reservation;
        private System.Windows.Forms.TextBox textBox_ID_Lecteur_Reservation;
        private System.Windows.Forms.TextBox textBox_ID_Livre_Reservation;
        private System.Windows.Forms.Button button_Reserver;
    }
}