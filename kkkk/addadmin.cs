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
    public partial class addadmin : MaterialForm
    {
        public addadmin()
        {
            InitializeComponent();
        }

        private void addadmin_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            // TODO: This line of code loads data into the 'kkkkDataSet.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.kkkkDataSet.admin);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            try
            {
                adminBindingSource.EndEdit();
                adminTableAdapter.Update(this.kkkkDataSet.admin);
                groupBox1.Enabled = false;
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                adminBindingSource.ResetBindings(false);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("r u sure u want 2 delete this record ?", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   // custBindingSource.RemoveCurrent();
                    adminBindingSource.RemoveCurrent();
                    adminBindingSource.DataSource = this.kkkkDataSet.admin;
                }
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message, "message");

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true;
                txtuname.Focus();
                this.kkkkDataSet.admin.AddadminRow(this.kkkkDataSet.admin.NewadminRow());
                adminBindingSource.MoveLast();

            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                adminBindingSource.ResetBindings(false);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}