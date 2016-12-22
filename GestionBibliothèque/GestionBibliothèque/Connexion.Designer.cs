namespace GestionBibliothèque
{
    partial class Connexion
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
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Biblio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(234, 80);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(33, 13);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Login";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(214, 122);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // label_Biblio
            // 
            this.label_Biblio.AutoSize = true;
            this.label_Biblio.Location = new System.Drawing.Point(202, 162);
            this.label_Biblio.Name = "label_Biblio";
            this.label_Biblio.Size = new System.Drawing.Size(65, 13);
            this.label_Biblio.TabIndex = 2;
            this.label_Biblio.Text = "Bibliothèque";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 393);
            this.Controls.Add(this.label_Biblio);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Login);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Biblio;
    }
}