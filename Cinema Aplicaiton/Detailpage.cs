using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cinema_Aplicaiton
{
    public partial class Detailpage : Form
    {
        public Detailpage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void label6_Click(object sender, EventArgs e)
        {
          

        }

        private void koltuk()
        {
            int lx = 139;
            int ly = 60;

            for (char x='A';x <= 'I'; x++)
            {
                for(int i = 1; i <= 10; i++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(150, 200);
                    btn.Name = x + i.ToString();
                    btn.Text = x + i.ToString();
                    btn.ForeColor = Color.Black;
                    btn.BackColor = Color.WhiteSmoke;
                    connect();
                    SqlCommand com = new SqlCommand("select * from bilet where seans='"+cs_data.seans+"'", connection);
                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {
                        if (btn.Name == reader["koltukNo"].ToString())
                        {
                            btn.Enabled = false;
                            btn.BackColor = Color.Teal;
                        }

                    }
                    connection.Close();
                    btn.Size =new Size(83, 24);
                    btn.Location =new Point(lx, ly);
                    this.Controls.Add(btn);
                    btn.Click += new EventHandler(koltuk_Click);
                    lx += 103;
                }
                lx = 139;
                ly += 40;
            }
        }

        private void Detailpage_Load(object sender, EventArgs e)
        {
            koltuk();

            SalonNumarasi.Text =cs_data.salonno;
            cs_data.ks = 0;
            for(int i = 0; i < 90; i++)
            {
                cs_data.kn[i] = null;
            }
            cs_data.total = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            connection.Close();
        }

        private void SatınAl_Click(object sender, EventArgs e)
        {
            if (cs_data.total != 0)
            {
                Paymentpage pymnt = new Paymentpage();
                pymnt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("koltuk seç", "dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void GeriButonu_Click(object sender, EventArgs e)
        {
            Categorypage ctgry = new Categorypage();
            ctgry.Show();
            this.Hide();
        }
        

        private void Detailpage_FormClosed(object sender, FormClosedEventArgs e)
        {

            DialogResult result1 = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                Detailpage dtl = new Detailpage();
                dtl.Show();
            }
        }

        private void koltuk_Click(object sender, EventArgs e)
        {
            if(((Button)sender).BackColor == Color.WhiteSmoke)
            {
                if (rb_o.Checked == true)
                {
                    ((Button)sender).BackColor = Color.Red;
                    ((Button)sender).ForeColor = Color.White;
                    cs_data.total += 30;
                    cs_data.kn[cs_data.ks] = ((Button)sender).Name;
                    cs_data.ks++;
                }
                else if (rb_t.Checked == true)
                {
                    ((Button)sender).BackColor = Color.Black;
                    ((Button)sender).ForeColor = Color.White;
                    cs_data.total += 35;
                    cs_data.kn[cs_data.ks] = ((Button)sender).Name;
                    cs_data.ks++;
                }
                else
                {
                    MessageBox.Show("bilet türü seç!!", "dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                if (((Button)sender).BackColor == Color.Red)
                {
                    ((Button)sender).ForeColor = Color.Black;
                    ((Button)sender).BackColor = Color.WhiteSmoke;
                    cs_data.total -= 30;
                }
                else if (rb_t.Checked == true)
                {
                    ((Button)sender).ForeColor = Color.Black;
                    ((Button)sender).BackColor = Color.WhiteSmoke;
                    cs_data.total -= 35;
                }
                for(int i = 0; i < cs_data.ks; i++)
                {
                    if(cs_data.kn[i] == ((Button)sender).Name)
                    {
                        for(int j = i; j < cs_data.ks; j++)
                        {
                            cs_data.kn[j] = cs_data.kn[j + 1];
                        }
                    }
                }

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

