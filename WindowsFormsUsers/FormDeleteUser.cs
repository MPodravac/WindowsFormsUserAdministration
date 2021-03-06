﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseService;

namespace WindowsFormsUsers
{
    public partial class FormDeleteUser : Form
    {
        private readonly Form1 FormUserList;
        public string ID;
        public FormDeleteUser(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }

        private void btnDeletedelete_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.nUserID = Int32.Parse(ID);
            Crud Crud = new Crud();
            Crud.DeleteUsers(oUser);

            this.FormUserList.DataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();
        }

        private void btnDeletecancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
