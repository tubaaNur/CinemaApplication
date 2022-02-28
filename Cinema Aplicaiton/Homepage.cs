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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void GirisYap_Click(object sender, EventArgs e)
        {
            if (KullanıcıGiris.Text == "askosokella" && KullanıcıSifre.Text == "147852")
            {
                Categorypage ctgry = new Categorypage();
                ctgry.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                Homepage hmpg = new Homepage();
                hmpg.Show();
            }

        }


        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            DialogResult result1 = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
                {
                    Homepage hmpg = new Homepage();
                    hmpg.Show();
                }
            }

        private void KullanıcıGiris_TextChanged(object sender, EventArgs e)
        {
            KullanıcıGiris.MaxLength = 17;
        }

        private void KullanıcıSifre_TextChanged(object sender, EventArgs e)
        {
            KullanıcıSifre.MaxLength = 8;
        }

       
    }
    }



    