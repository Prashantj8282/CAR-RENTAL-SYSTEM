using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;

namespace kkkk
{
    public partial class customers : MaterialForm
    {
        public customers()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel1.Enabled = false;
            custBindingSource.ResetBindings(false);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customers_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            // TODO: This line of code loads data into the 'kkkkDataSet.cust' table. You can move, or remove it, as needed.
            this.custTableAdapter.Fill(this.kkkkDataSet.cust);
            custBindingSource.DataSource=(this.kkkkDataSet.cust);
            //custBindingSource.DataMember(this.kkkkDataSet.cust);
            

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("r u sure u want 2 delete this record ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    custBindingSource.RemoveCurrent(); 
                }
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message,"message");

            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
               

                    try
                    {
                        custBindingSource.EndEdit();
                        custTableAdapter.Update(this.kkkkDataSet.cust);
                        panel1.Enabled = false;

                    }
                    catch (Exception ep)
                    {
                        MessageBox.Show(ep.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        custBindingSource.ResetBindings(false);
                    }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                txtname.Focus();
                this.kkkkDataSet.cust.AddcustRow(this.kkkkDataSet.cust.NewcustRow());
                custBindingSource.MoveLast();

            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                custBindingSource.ResetBindings(false);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtname.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m1 = new main();
            m1.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
