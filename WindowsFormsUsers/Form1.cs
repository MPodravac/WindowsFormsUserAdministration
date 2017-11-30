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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Crud Crud = new Crud();
            List<User> lUsers = Crud.GetUsers();
            DataGridViewUsers.DataSource = lUsers;

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            oEditButton.Image = Image.FromFile("D:/DotNet/pencil.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oEditButton);

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("D:/DotNet/delete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oDeleteButton);

            DataGridViewUsers.AutoGenerateColumns = false; //mora se postaviti tako da kolone budu pravilno raspoređene, tj. da idu onim redoslijedom kako su i dodavane


        }

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //metoda za provjeravanje da li se poziva funkcija klikom na gumb
            //MessageBox.Show("Dot Net"); 

            DataGridViewUsers.Rows[e.RowIndex].Selected = true; //tu se postavlja da se redak zaplavi

            //ako je index kliknute ćelije (kolone) 5 i index retka različit od -1, napravi nešto
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                //Form1 FormUserList=this;
                FormEditUser FormEditUser = new FormEditUser(this ); //kreiran novi objekt druge forme(edit user) - this-pokazivač na objekt prve forme
                //new FormEditUser(this ) -objekt klase formedituser čiji konstruktor zaprima objekt klase formedituser
                FormEditUser.lblEditUserID.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                //iz dataviewgrid kontrole edituserid iz reda koji je pritisnut i ćelije 
                //objekti kojima mijenjamo vrijednost moraju biti u formi2.designer postavljeni kao public (po defaultu je private)
                FormEditUser.lblEditUserName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUser.inptEditPassword.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUser.inptEditName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditUser.inptEditSurname.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormEditUser.Show();
            }

            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                //Form1 FormUserList=this;
                FormDeleteUser FormDeleteUser = new FormDeleteUser(this); //kreiran novi objekt druge forme(edit user) - this-pokazivač na objekt prve forme
                //new FormEditUser(this ) -objekt klase formedituser čiji konstruktor zaprima objekt klase formedituser
                FormDeleteUser.lblDeleteuserID.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteUser.ID=DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteUser.Show();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser FormAddUser = new FormAddUser(this);
            FormAddUser.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   
}
