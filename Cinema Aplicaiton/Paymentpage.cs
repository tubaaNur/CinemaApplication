using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Aplicaiton
{
    public partial class Paymentpage : Form
    {
        public Paymentpage()
        {
            InitializeComponent();
        }

        Categorypage ctgry = new Categorypage();

        private void Paymentpage_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            btn_f.Text = cs_data.total.ToString() + "₺";
            btn_t.Text = DateTime.Today.ToString();
            for (int i = 0; i < 90; i++)
            {
                if (cs_data.kn[i] != null)
                {
                    btn_kn.Text += cs_data.kn[i];
                }
            }
            btn_ss.Text = cs_data.seanss.ToString();
            btn_fa.Text = cs_data.filmadi;
            btn_sn.Text = cs_data.salonno;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void YazdırButonu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 90; i++)
            {
                if(cs_data.kn[i] != null)
                {
                    connect();
                    SqlCommand com = new SqlCommand("insert into bilet(seans,koltukNo) values (@seans,@koltukNo)", connection);

                    com.Parameters.AddWithValue("@seans", cs_data.seans);
                    com.Parameters.AddWithValue("@koltukNo", cs_data.kn[i].ToString());

                    com.ExecuteNonQuery();
                    connection.Close();
                }
            }
            ctgry.Show();
            this.Hide();
        }

        private void IptalButonu_Click(object sender, EventArgs e)
        {

            ctgry.Show();
            this.Hide();

        }


        private void Paymentpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                Paymentpage pymnt = new Paymentpage();
                pymnt.Show();
            }
        }

        SqlConnection connection = new SqlConnection(cs_data.conpath);

        private void connect()
        {
            try
            {
                connection.Open();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
    

