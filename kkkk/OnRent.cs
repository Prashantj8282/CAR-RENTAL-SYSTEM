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
    public partial class OnRent : MaterialForm
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\doccument\\carRentalFinal\\kkkk\\kkkk\\kkkk.accdb");
        OleDbCommand cmd;
        public OnRent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(days.Text) * int.Parse(rentperday.Text);

            Total.Text = a.ToString();

            con.Open();
            cmd = new OleDbCommand("insert into [rent](cid,custname,hiredate,rent,phnumber,rentid) values(@cid,@cname,@hdate,@rent,@pno,@rentid)", con);
            cmd.Parameters.AddWithValue("@cid", carid.Text);
            
            cmd.Parameters.AddWithValue("@cname", custname.Text);
            cmd.Parameters.AddWithValue("@hdate", hdate.Text);
            cmd.Parameters.AddWithValue("@rent", rentperday.Text);
            cmd.Parameters.AddWithValue("@pno", pno.Text);
            cmd.Parameters.AddWithValue("@rentid", rentid.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("data inserted");
            
           
         
        }

        private void OnRent_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnRent o1 = new OnRent();
            o1.Show();
            this.Dispose(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            statusView s = new statusView();
            s.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void carid_TextChanged(object sender, EventArgs e)
        {

        }

        private void custname_TextChanged(object sender, EventArgs e)
        {

        }

        private void rentperday_TextChanged(object sender, EventArgs e)
        {

        }

        private void days_TextChanged(object sender, EventArgs e)
        {

        }

        private void pno_TextChanged(object sender, EventArgs e)
        {

        }

        private void hdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
