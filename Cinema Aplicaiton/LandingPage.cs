using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Aplicaiton
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void LandingPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                LandingPage lndg = new LandingPage();
                lndg.Show();


            }
        }

        private void LandingPage_Click(object sender, EventArgs e)
        {
            Homepage hmpg = new Homepage();
            hmpg.Show();
            this.Hide();
            

        }
        

    }
}
