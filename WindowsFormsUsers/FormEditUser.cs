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
    public partial class FormEditUser : Form
    {
        private readonly Form1 FormUserList;
        //ovo je konstruktor koji zaprima prvu formu i svom podatkovnom članu postavlja taj dobiveni parametar, potrebno je kad stisnemo na gumbić spremi da imamo pristup do njega
        public FormEditUser(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.nUserID = Int32.Parse(lblEditUserID.Text);
            oUser.sUserFirstName = inptEditName.Text;
            oUser.sUserLastName = inptEditSurname.Text;
            oUser.sUserPassword = inptEditPassword.Text;
            oUser.sUserName = lblEditUserName.Text;
            Crud Crud = new Crud();
            Crud.UpdateUsers(oUser);

            this.FormUserList.DataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();
        }

        private void btnEditcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
