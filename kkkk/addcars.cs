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
using System.IO;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
namespace kkkk
{
    public partial class addcars : MaterialForm

    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\\doccument\\kkkk\\kkkk\\kkkk.accdb");
        OleDbCommand cmd;
        string imglocation = "";
        public addcars()
        {
            InitializeComponent();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*)";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                cpic.ImageLocation = imglocation;
                //imagep.Image == Image.FromFile(dialog.FileName);
            }

        }

        private void addcars_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

         }
        private byte[] saveimg()
        {
            MemoryStream ms = new MemoryStream();
            cpic.Image.Save(ms, cpic.Image.RawFormat);
            return ms.GetBuffer();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                cmd = new OleDbCommand("insert into [car](cid,pno,cname,color,quality,rent,pic) values(@cid,@pno,@cname,@color,@quality,@rent,@pic)",con);
                cmd.Parameters.AddWithValue("@cid",txtcid.Text);
                cmd.Parameters.AddWithValue("@pno", txtnoplate.Text);
                cmd.Parameters.AddWithValue("@cname", txtcname.Text);
                cmd.Parameters.AddWithValue("@color", txtcolor.Text);
                cmd.Parameters.AddWithValue("@quality", txtquality.Text);
                cmd.Parameters.AddWithValue("@rent", txtrent.Text);
                cmd.Parameters.AddWithValue("@cid",saveimg());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("file inserted");
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btncalcle_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbcname_Click(object sender, EventArgs e)
        {

        }

        private void lbcolor_Click(object sender, EventArgs e)
        {

        }

        private void lbquality_Click(object sender, EventArgs e)
        {

        }

        private void lbrent_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cpic_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
