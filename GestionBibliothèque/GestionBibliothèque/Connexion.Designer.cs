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
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.comboBox_Biblio = new System.Windows.Forms.ComboBox();
            this.button_TestAdmin = new System.Windows.Forms.Button();
            this.button_Test_User = new System.Windows.Forms.Button();
            this.button_Charger_Nom_Biblio = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
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
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(296, 73);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(100, 20);
            this.textBox_Login.TabIndex = 3;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(296, 122);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // comboBox_Biblio
            // 
            this.comboBox_Biblio.FormattingEnabled = true;
            this.comboBox_Biblio.Location = new System.Drawing.Point(296, 159);
            this.comboBox_Biblio.Name = "comboBox_Biblio";
            this.comboBox_Biblio.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Biblio.TabIndex = 5;
            this.comboBox_Biblio.SelectedIndexChanged += new System.EventHandler(this.comboBox_Biblio_SelectedIndexChanged);
            // 
            // button_TestAdmin
            // 
            this.button_TestAdmin.Location = new System.Drawing.Point(35, 75);
            this.button_TestAdmin.Name = "button_TestAdmin";
            this.button_TestAdmin.Size = new System.Drawing.Size(75, 23);
            this.button_TestAdmin.TabIndex = 6;
            this.button_TestAdmin.Text = "Test Admin";
            this.button_TestAdmin.UseVisualStyleBackColor = true;
            this.button_TestAdmin.Click += new System.EventHandler(this.button_TestAdmin_Click);
            // 
            // button_Test_User
            // 
            this.button_Test_User.Location = new System.Drawing.Point(513, 80);
            this.button_Test_User.Name = "button_Test_User";
            this.button_Test_User.Size = new System.Drawing.Size(75, 23);
            this.button_Test_User.TabIndex = 7;
            this.button_Test_User.Text = "Test User";
            this.button_Test_User.UseVisualStyleBackColor = true;
            this.button_Test_User.Click += new System.EventHandler(this.button_Test_User_Click);
            // 
            // button_Charger_Nom_Biblio
            // 
            this.button_Charger_Nom_Biblio.Location = new System.Drawing.Point(45, 162);
            this.button_Charger_Nom_Biblio.Name = "button_Charger_Nom_Biblio";
            this.button_Charger_Nom_Biblio.Size = new System.Drawing.Size(75, 49);
            this.button_Charger_Nom_Biblio.TabIndex = 8;
            this.button_Charger_Nom_Biblio.Text = "Charger Nom Biblio";
            this.button_Charger_Nom_Biblio.UseVisualStyleBackColor = true;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(309, 206);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 41);
            this.button_Connect.TabIndex = 9;
            this.button_Connect.Text = "Se Connecter";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 393);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.button_Charger_Nom_Biblio);
            this.Controls.Add(this.button_Test_User);
            this.Controls.Add(this.button_TestAdmin);
            this.Controls.Add(this.comboBox_Biblio);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
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
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.ComboBox comboBox_Biblio;
        private System.Windows.Forms.Button button_TestAdmin;
        private System.Windows.Forms.Button button_Test_User;
        private System.Windows.Forms.Button button_Charger_Nom_Biblio;
        private System.Windows.Forms.Button button_Connect;
    }
}