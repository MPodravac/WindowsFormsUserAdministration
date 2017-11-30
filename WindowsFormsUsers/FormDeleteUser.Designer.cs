namespace WindowsFormsUsers
{
    partial class FormDeleteUser
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
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnDeletecancel = new System.Windows.Forms.Button();
            this.btnDeletedelete = new System.Windows.Forms.Button();
            this.lblDeleteuserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDelete.Location = new System.Drawing.Point(113, 59);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(147, 24);
            this.lblDelete.TabIndex = 0;
            this.lblDelete.Text = "Obriši korisnika?";
            // 
            // btnDeletecancel
            // 
            this.btnDeletecancel.Location = new System.Drawing.Point(64, 130);
            this.btnDeletecancel.Name = "btnDeletecancel";
            this.btnDeletecancel.Size = new System.Drawing.Size(100, 35);
            this.btnDeletecancel.TabIndex = 1;
            this.btnDeletecancel.Text = "ZATVORI";
            this.btnDeletecancel.UseVisualStyleBackColor = true;
            this.btnDeletecancel.Click += new System.EventHandler(this.btnDeletecancel_Click);
            // 
            // btnDeletedelete
            // 
            this.btnDeletedelete.Location = new System.Drawing.Point(214, 130);
            this.btnDeletedelete.Name = "btnDeletedelete";
            this.btnDeletedelete.Size = new System.Drawing.Size(100, 35);
            this.btnDeletedelete.TabIndex = 2;
            this.btnDeletedelete.Text = "OBRIŠI";
            this.btnDeletedelete.UseVisualStyleBackColor = true;
            this.btnDeletedelete.Click += new System.EventHandler(this.btnDeletedelete_Click);
            // 
            // lblDeleteuserID
            // 
            this.lblDeleteuserID.AutoSize = true;
            this.lblDeleteuserID.Location = new System.Drawing.Point(162, 92);
            this.lblDeleteuserID.Name = "lblDeleteuserID";
            this.lblDeleteuserID.Size = new System.Drawing.Size(40, 13);
            this.lblDeleteuserID.TabIndex = 3;
            this.lblDeleteuserID.Text = "UserID";
            this.lblDeleteuserID.Visible = false;
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 247);
            this.Controls.Add(this.lblDeleteuserID);
            this.Controls.Add(this.btnDeletedelete);
            this.Controls.Add(this.btnDeletecancel);
            this.Controls.Add(this.lblDelete);
            this.Name = "FormDeleteUser";
            this.Text = "FormDeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnDeletecancel;
        private System.Windows.Forms.Button btnDeletedelete;
        public System.Windows.Forms.Label lblDeleteuserID;
    }
}