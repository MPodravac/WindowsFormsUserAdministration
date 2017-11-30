namespace WindowsFormsUsers
{
    partial class FormEditUser
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
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.lblEditUserName = new System.Windows.Forms.Label();
            this.lblEditUserID = new System.Windows.Forms.Label();
            this.lblEditName = new System.Windows.Forms.Label();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.lblEditPassword = new System.Windows.Forms.Label();
            this.inptEditName = new System.Windows.Forms.TextBox();
            this.inptEditSurname = new System.Windows.Forms.TextBox();
            this.inptEditPassword = new System.Windows.Forms.TextBox();
            this.btnEditcancel = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle.Location = new System.Drawing.Point(303, 42);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(133, 24);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "Uredi korisnika";
            // 
            // lblEditUserName
            // 
            this.lblEditUserName.AutoSize = true;
            this.lblEditUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUserName.Location = new System.Drawing.Point(333, 66);
            this.lblEditUserName.Name = "lblEditUserName";
            this.lblEditUserName.Size = new System.Drawing.Size(67, 15);
            this.lblEditUserName.TabIndex = 1;
            this.lblEditUserName.Text = "UserName";
            // 
            // lblEditUserID
            // 
            this.lblEditUserID.AutoSize = true;
            this.lblEditUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUserID.Location = new System.Drawing.Point(344, 81);
            this.lblEditUserID.Name = "lblEditUserID";
            this.lblEditUserID.Size = new System.Drawing.Size(45, 15);
            this.lblEditUserID.TabIndex = 2;
            this.lblEditUserID.Text = "UserID";
            this.lblEditUserID.Visible = false;
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(137, 127);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(24, 13);
            this.lblEditName.TabIndex = 3;
            this.lblEditName.Text = "Ime";
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Location = new System.Drawing.Point(137, 162);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(44, 13);
            this.lblEditLastName.TabIndex = 4;
            this.lblEditLastName.Text = "Prezime";
            // 
            // lblEditPassword
            // 
            this.lblEditPassword.AutoSize = true;
            this.lblEditPassword.Location = new System.Drawing.Point(137, 198);
            this.lblEditPassword.Name = "lblEditPassword";
            this.lblEditPassword.Size = new System.Drawing.Size(44, 13);
            this.lblEditPassword.TabIndex = 5;
            this.lblEditPassword.Text = "Lozinka";
            // 
            // inptEditName
            // 
            this.inptEditName.Location = new System.Drawing.Point(206, 120);
            this.inptEditName.Name = "inptEditName";
            this.inptEditName.Size = new System.Drawing.Size(363, 20);
            this.inptEditName.TabIndex = 6;
            // 
            // inptEditSurname
            // 
            this.inptEditSurname.Location = new System.Drawing.Point(206, 155);
            this.inptEditSurname.Name = "inptEditSurname";
            this.inptEditSurname.Size = new System.Drawing.Size(363, 20);
            this.inptEditSurname.TabIndex = 7;
            // 
            // inptEditPassword
            // 
            this.inptEditPassword.Location = new System.Drawing.Point(206, 191);
            this.inptEditPassword.Name = "inptEditPassword";
            this.inptEditPassword.Size = new System.Drawing.Size(363, 20);
            this.inptEditPassword.TabIndex = 8;
            // 
            // btnEditcancel
            // 
            this.btnEditcancel.Location = new System.Drawing.Point(254, 249);
            this.btnEditcancel.Name = "btnEditcancel";
            this.btnEditcancel.Size = new System.Drawing.Size(100, 35);
            this.btnEditcancel.TabIndex = 9;
            this.btnEditcancel.Text = "ZATVORI";
            this.btnEditcancel.UseVisualStyleBackColor = true;
            this.btnEditcancel.Click += new System.EventHandler(this.btnEditcancel_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(396, 249);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(100, 35);
            this.btnEditUser.TabIndex = 10;
            this.btnEditUser.Text = "SPREMI";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 382);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnEditcancel);
            this.Controls.Add(this.inptEditPassword);
            this.Controls.Add(this.inptEditSurname);
            this.Controls.Add(this.inptEditName);
            this.Controls.Add(this.lblEditPassword);
            this.Controls.Add(this.lblEditLastName);
            this.Controls.Add(this.lblEditName);
            this.Controls.Add(this.lblEditUserID);
            this.Controls.Add(this.lblEditUserName);
            this.Controls.Add(this.lblEditTitle);
            this.Name = "FormEditUser";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditTitle;
        public System.Windows.Forms.Label lblEditUserName;
        public System.Windows.Forms.Label lblEditUserID;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.Label lblEditPassword;
        public System.Windows.Forms.TextBox inptEditName;
        public System.Windows.Forms.TextBox inptEditSurname;
        public System.Windows.Forms.TextBox inptEditPassword;
        private System.Windows.Forms.Button btnEditcancel;
        private System.Windows.Forms.Button btnEditUser;
    }
}