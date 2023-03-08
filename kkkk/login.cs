using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;


namespace kkkk
{
    public partial class login : MaterialForm
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\doccument\\carRentalFinal\\kkkk\\kkkk\\kkkk.accdb");
       //OleDbCommand cmd;
        public login()
        {
            InitializeComponent();
            txtpass.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter dt = new OleDbDataAdapter("select uid from [admin] where uname='"+txtuname.Text+"' and pass='"+txtpass.Text+"' ",con);
            DataTable t = new DataTable();
            dt.Fill(t);
            if (t.Rows.Count == 1)
            {
                main m = new main();
                this.Visible = false;
                m.Show();
            }
            else
            {
                MessageBox.Show("wrong userid or password");
            }
            con.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
