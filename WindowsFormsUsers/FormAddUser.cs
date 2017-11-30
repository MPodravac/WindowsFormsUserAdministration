using System;
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
    public partial class FormAddUser : Form
    {
        private readonly Form1 FormUserList;
        public FormAddUser(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.sUserFirstName = inptNewUserName.Text;
            oUser.sUserLastName = inptNewUserSurname.Text;
            oUser.sUserName = inptNewUserUsername.Text;
            oUser.sUserPassword = inptNewUserPassword.Text;
            Crud Crud = new Crud();
            Crud.AddNewUser(oUser);

            this.FormUserList.DataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();
        }
    }
}
