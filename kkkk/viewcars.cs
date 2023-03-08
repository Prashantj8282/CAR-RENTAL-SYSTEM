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
    public partial class viewcars : MaterialForm
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\doccument\\carRentalFinal\\kkkk\\kkkk\\kkkk.accdb");
        OleDbDataAdapter ad;
        public viewcars()
        {
            InitializeComponent();
        }

        private void viewcars_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            try
            {
                con.Open();
                ad = new OleDbDataAdapter("select * from [car]", con);

                DataTable dt = new DataTable();
                ad.Fill(dt);
                //dt.Show();
                dataGridView1.DataSource = dt;
                
                con.Close();
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
