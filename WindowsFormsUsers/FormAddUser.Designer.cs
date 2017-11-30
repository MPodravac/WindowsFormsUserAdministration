namespace WindowsFormsUsers
{
    partial class FormAddUser
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.lblNewUserSurname = new System.Windows.Forms.Label();
            this.lblNewUserUsername = new System.Windows.Forms.Label();
            this.lblNewUserPassword = new System.Windows.Forms.Label();
            this.inptNewUserName = new System.Windows.Forms.TextBox();
            this.inptNewUserSurname = new System.Windows.Forms.TextBox();
            this.inptNewUserUsername = new System.Windows.Forms.TextBox();
            this.inptNewUserPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAdd.Location = new System.Drawing.Point(201, 46);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(137, 24);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Dodaj korisnika";
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Location = new System.Drawing.Point(59, 98);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(24, 13);
            this.lblNewUserName.TabIndex = 1;
            this.lblNewUserName.Text = "Ime";
            // 
            // lblNewUserSurname
            // 
            this.lblNewUserSurname.AutoSize = true;
            this.lblNewUserSurname.Location = new System.Drawing.Point(59, 136);
            this.lblNewUserSurname.Name = "lblNewUserSurname";
            this.lblNewUserSurname.Size = new System.Drawing.Size(44, 13);
            this.lblNewUserSurname.TabIndex = 2;
            this.lblNewUserSurname.Text = "Prezime";
            // 
            // lblNewUserUsername
            // 
            this.lblNewUserUsername.AutoSize = true;
            this.lblNewUserUsername.Location = new System.Drawing.Point(59, 176);
            this.lblNewUserUsername.Name = "lblNewUserUsername";
            this.lblNewUserUsername.Size = new System.Drawing.Size(75, 13);
            this.lblNewUserUsername.TabIndex = 3;
            this.lblNewUserUsername.Text = "Korisničko ime";
            // 
            // lblNewUserPassword
            // 
            this.lblNewUserPassword.AutoSize = true;
            this.lblNewUserPassword.Location = new System.Drawing.Point(59, 209);
            this.lblNewUserPassword.Name = "lblNewUserPassword";
            this.lblNewUserPassword.Size = new System.Drawing.Size(44, 13);
            this.lblNewUserPassword.TabIndex = 4;
            this.lblNewUserPassword.Text = "Lozinka";
            // 
            // inptNewUserName
            // 
            this.inptNewUserName.Location = new System.Drawing.Point(193, 91);
            this.inptNewUserName.Name = "inptNewUserName";
            this.inptNewUserName.Size = new System.Drawing.Size(200, 20);
            this.inptNewUserName.TabIndex = 5;
            // 
            // inptNewUserSurname
            // 
            this.inptNewUserSurname.Location = new System.Drawing.Point(193, 129);
            this.inptNewUserSurname.Name = "inptNewUserSurname";
            this.inptNewUserSurname.Size = new System.Drawing.Size(200, 20);
            this.inptNewUserSurname.TabIndex = 6;
            // 
            // inptNewUserUsername
            // 
            this.inptNewUserUsername.Location = new System.Drawing.Point(193, 169);
            this.inptNewUserUsername.Name = "inptNewUserUsername";
            this.inptNewUserUsername.Size = new System.Drawing.Size(200, 20);
            this.inptNewUserUsername.TabIndex = 7;
            // 
            // inptNewUserPassword
            // 
            this.inptNewUserPassword.Location = new System.Drawing.Point(193, 202);
            this.inptNewUserPassword.Name = "inptNewUserPassword";
            this.inptNewUserPassword.Size = new System.Drawing.Size(200, 20);
            this.inptNewUserPassword.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 327);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inptNewUserPassword);
            this.Controls.Add(this.inptNewUserUsername);
            this.Controls.Add(this.inptNewUserSurname);
            this.Controls.Add(this.inptNewUserName);
            this.Controls.Add(this.lblNewUserPassword);
            this.Controls.Add(this.lblNewUserUsername);
            this.Controls.Add(this.lblNewUserSurname);
            this.Controls.Add(this.lblNewUserName);
            this.Controls.Add(this.lblAdd);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Label lblNewUserSurname;
        private System.Windows.Forms.Label lblNewUserUsername;
        private System.Windows.Forms.Label lblNewUserPassword;
        private System.Windows.Forms.TextBox inptNewUserName;
        private System.Windows.Forms.TextBox inptNewUserSurname;
        private System.Windows.Forms.TextBox inptNewUserUsername;
        private System.Windows.Forms.TextBox inptNewUserPassword;
        private System.Windows.Forms.Button btnAdd;
    }
}