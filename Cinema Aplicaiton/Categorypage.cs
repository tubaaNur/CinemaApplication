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
    public partial class Categorypage : Form
    {
        public Categorypage()
        {
            InitializeComponent();
        }

        private void Categorypage_Load(object sender, EventArgs e)
        {
            cs_data.seans = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
                for (int i = 0; i < 3; i++)
                {
                    Button btn = new Button();
                    btn.Name = i.ToString();
                    btn.Text = i.ToString();

                    if (i == 1)
                {
                    IlerlemeButonu.BackColor = Color.Blue;
                } 
                    else if(i == 2)
                {
                    IlerlemeButonu.BackColor = Color.Pink;
                }
                
            }
            }

        private void CikisButonu_Click(object sender, EventArgs e)
        {
            Homepage hmpg = new Homepage();
            hmpg.Show();
            this.Hide();

        }

        private void FilmSaati_Click(object sender, EventArgs e)
        {
            s01.BackColor = Color.WhiteSmoke;
            s02.BackColor = Color.WhiteSmoke;
            s03.BackColor = Color.WhiteSmoke;
            s04.BackColor = Color.WhiteSmoke;
            s05.BackColor = Color.WhiteSmoke;
            s06.BackColor = Color.WhiteSmoke;
            s07.BackColor = Color.WhiteSmoke;
            s08.BackColor = Color.WhiteSmoke;
            s09.BackColor = Color.WhiteSmoke;
            s10.BackColor = Color.WhiteSmoke;
            s11.BackColor = Color.WhiteSmoke;
            s12.BackColor = Color.WhiteSmoke;
            s13.BackColor = Color.WhiteSmoke;
            s14.BackColor = Color.WhiteSmoke;
            s15.BackColor = Color.WhiteSmoke;
            s16.BackColor = Color.WhiteSmoke;
            ((Button)sender).BackColor = Color.Purple;

            if(((Button)sender).Name == "s01")
            {
                cs_data.seans = 1;
            }
            else if (((Button)sender).Name == "s02")
            {
                cs_data.seans = 2;
            }
            else if (((Button)sender).Name == "s03")
            {
                cs_data.seans = 3;
            }
            else if (((Button)sender).Name == "s04")
            {
                cs_data.seans = 4;
            }
            else if (((Button)sender).Name == "s05")
            {
                cs_data.seans = 5;
            }
            else if (((Button)sender).Name == "s06")
            {
                cs_data.seans = 6;
            }
            else if (((Button)sender).Name == "s07")
            {
                cs_data.seans = 7;
            }
            else if (((Button)sender).Name == "s08")
            {
                cs_data.seans = 8;
            }
            else if (((Button)sender).Name == "s09")
            {
                cs_data.seans = 9;
            }
            else if (((Button)sender).Name == "s10")
            {
                cs_data.seans = 10;
            }
            else if (((Button)sender).Name == "s11")
            {
                cs_data.seans = 11;
            }
            else if (((Button)sender).Name == "s12")
            {
                cs_data.seans = 12;
            }
            else if (((Button)sender).Name == "s13")
            {
                cs_data.seans = 13;
            }
            else if (((Button)sender).Name == "s14")
            {
                cs_data.seans = 14;
            }
            else if (((Button)sender).Name == "s15")
            {
                cs_data.seans = 15;
            }
            else if (((Button)sender).Name == "s16")
            {
                cs_data.seans = 16;
            }
        }

        private void Categorypage_FormClosed(object sender, FormClosedEventArgs e)
        {

            DialogResult result1 = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else { 
                Categorypage ctgry = new Categorypage();
                ctgry.Show();
            }
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            connect();
            SqlCommand command = new SqlCommand("select * from seans", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(Convert.ToInt32(reader["id"]) == cs_data.seans)
                {
                    cs_data.seanss = reader["saat"].ToString();
                    cs_data.filmadi = reader["filmAdi"].ToString();
                    cs_data.salonno = "salon " + reader["salonAdi"].ToString();
                }
            }
            reader.Close();
            connection.Close();
            if (cs_data.seans != 0)
            {
                Detailpage dtlg = new Detailpage();
                dtlg.Show();
                this.Hide();
                IlerlemeButonu.BackColor = Color.Pink;
            }
            else
            {
                MessageBox.Show("Lütfen bir seans saati seçiniz!", "dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
     


