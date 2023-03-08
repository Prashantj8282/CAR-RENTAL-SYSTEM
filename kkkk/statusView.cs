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
    public partial class statusView : MaterialForm
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\doccument\\carRentalFinal\\kkkk\\kkkk\\kkkk.accdb");
        
        public statusView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                con.Open();
                OleDbDataAdapter ad = new OleDbDataAdapter("select * from [car] where status='"+button1.Text+"'",con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }
        

        private void statusView_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            try
            {
                con.Open();
                OleDbDataAdapter ad = new OleDbDataAdapter("select * from [car]", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbDataAdapter ad = new OleDbDataAdapter("select * from [car] where status='" + button2.Text + "'", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ep) 
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Update [car] set status=@status where cid ='"+textBox1.Text+"' ", con);
            cmd.Parameters.AddWithValue("@status", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("status updated");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m1 = new main();
            m1.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnRent o = new OnRent();
            o.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
