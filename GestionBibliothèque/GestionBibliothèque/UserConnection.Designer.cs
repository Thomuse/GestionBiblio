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
            // UserConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 467);
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
    }
}