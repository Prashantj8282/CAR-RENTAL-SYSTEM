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
    public partial class main : MaterialForm
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\doccument\\carRentalFinal\\kkkk\\kkkk\\kkkk.accdb");
        //OleDbDataAdapter ad;
        public main()
        {
            InitializeComponent();
        }

        private void btncars_Click(object sender, EventArgs e)
        {
            this.Close();
            viewcars v = new viewcars();
            v.Show();
        }

        private void btnaddcars_Click(object sender, EventArgs e)
        {
            this.Hide();
            addcars ad = new addcars();
            ad.Show();
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            this.Hide();

            customers c = new customers();
            c.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            addadmin am = new addadmin();
            am.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            addadmin a1 = new addadmin();
            addcars a2 = new addcars();
            viewcars a3 = new viewcars();
            customers a4 = new customers();
            a1.Close();
            a2.Close();
            a3.Close();
            a4.Close();
            this.Close();
            

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            addadmin a1 = new addadmin();
            addcars a2 = new addcars();
            viewcars a3 = new viewcars();
            customers a4 = new customers();
            login a5 = new login();
            a1.Close();
            a2.Close();
            a3.Close();
            a4.Close();
            a5.Close();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            statusView s = new statusView();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnRent r = new OnRent();
            r.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerStatus cs = new CustomerStatus();
            cs.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
