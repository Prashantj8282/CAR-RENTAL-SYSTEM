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
    public partial class CustomerStatus : MaterialForm
    {
        
        public CustomerStatus()
        {
            InitializeComponent();
        }

        private void CustomerStatus_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            string strProvider = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\doccument\carRentalFinal\kkkk\kkkk\kkkk.accdb";
         
            string strSql = "Select * from rent";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable rent = new DataTable();
            da.Fill(rent);
            dataGridView1.DataSource = rent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
