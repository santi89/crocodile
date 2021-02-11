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

namespace WindowsFormsApp1
{
    public partial class Main_Crocodile : Form
    {
        Thread td;
        public Main_Crocodile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void startgame()
        {
            Application.Run(new Crocodile());
        }
        private void btnenter_Click(object sender, EventArgs e)
        {
            this.Close();
            td = new Thread(startgame);
            td.SetApartmentState(ApartmentState.STA);
            td.Start();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
