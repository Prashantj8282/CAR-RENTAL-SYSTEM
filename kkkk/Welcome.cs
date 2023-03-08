using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;

namespace kkkk
{
    public partial class Welcome : MaterialForm
    {
        public Welcome()
        {
            //Thread t = new Thread(new ThreadStart(WelcomeStart));
            //t.Start();
            //Thread.Sleep(5000);

            InitializeComponent();
            //t.Abort();
        }
        public void WelcomeStart()
        {
            //Application.Run(new Form1());
        }


        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            login l = new login();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addadmin u = new addadmin();
            this.Hide();
            u.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
