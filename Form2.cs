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

namespace BilgiYarismasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-HEQ774N\\SQLEXPRESS;Initial Catalog=sorularım;Integrated Security=True");
        int sayac = 0;
        int puan = 0;
        int zaman = 20;

        private void btnbasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 20;


            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            
            btnbasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            lblbitti.Visible = false;
            btnbasla.Text = "Sonraki Soru";
            sayac++;
            lblsoru.Text = sayac.ToString();

            if (sayac == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru1 order by NEWID()", baglan); //rastgele veri getirir.
                SqlDataReader oku = komut.ExecuteReader();//verilerin okunması için
                
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = ("1.Soru: " + oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru2 order by NEWID()",baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = ("2.Soru: " + oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();

            }
            if (sayac == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = ("3.Soru: " + oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();

            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = ("4.Soru: " + oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();

            }
            if (sayac == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = ("5.Soru: " + oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();

            }
            if (sayac == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = ("6.Soru: " + oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();

            }
            if (sayac == 7)
            {
                
                btnbasla.Enabled = false;
               

                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from soru7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = ("7.Soru: " + oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                
                baglan.Close();

            }
            if(sayac == 8)
            {
                lblsoru.Visible = false;
                btnbasla.Text = "Oyun Bitti";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                timer1.Enabled = false;
                if(puan == 70)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblsoru.Text = sayac.ToString();
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            lbldogru.Visible = false;
            lblbitti.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zaman = zaman+0;
            timer1.Enabled = false;
            lblkalanzaman.Text = zaman.ToString();

            if(button1.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button1.BackColor = Color.Green;

            }
            else
            {
                button1.BackColor = Color.Red;
            }
            if (button2.Text == lbldogru.Text)
            {
                button2.BackColor = Color.Green;
            }
            if(button3.Text == lbldogru.Text)
            {
                button3.BackColor = Color.Green;
            }
            if(button4.Text == lbldogru.Text)
            {
                button4.BackColor = Color.Green;
            }
            
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zaman = zaman + 0;
            timer1.Enabled = false;
            lblkalanzaman.Text = zaman.ToString();

            if (button2.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button2.BackColor = Color.Green;

            }
            else
            {
                button2.BackColor = Color.Red;
            }
            if (button1.Text == lbldogru.Text)
            {
                button1.BackColor = Color.Green;
            }
            if (button3.Text == lbldogru.Text)
            {
                button3.BackColor = Color.Green;
            }
            if (button4.Text == lbldogru.Text)
            {
                button4.BackColor = Color.Green;
            }
            

            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zaman = zaman + 0;
            timer1.Enabled = false;
            lblkalanzaman.Text = zaman.ToString();

            if (button3.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button3.BackColor = Color.Green;

            }
            else
            {
                button3.BackColor = Color.Red;
            }
            if (button1.Text == lbldogru.Text)
            {
                button1.BackColor = Color.Green;
            }
            if(button2.Text == lbldogru.Text)
            {
                button2.BackColor = Color.Green;
            }
            if(button4.Text == lbldogru.Text)
            {
                button4.BackColor = Color.Green;
            }
           
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zaman = zaman + 0;
            timer1.Enabled = false;
            lblkalanzaman.Text = zaman.ToString();

            if (button4.Text == lbldogru.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                button4.BackColor = Color.Green;

            }
            else
            {
                button4.BackColor = Color.Red;
            }
            if (button1.Text == lbldogru.Text)
            {
                button1.BackColor = Color.Green;
            }
            if(button2.Text == lbldogru.Text)
            {
                button2.BackColor = Color.Green;
            }
            if(button3.Text == lbldogru.Text)
            {
                button3.BackColor = Color.Green;
            }
            
            btnbasla.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblkalanzaman.Text = zaman.ToString();
            if(zaman == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnbasla.Enabled = true;
                lblbitti.Visible = true;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
