using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışıOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int atu1, atu2, atu3, atu4, atu5;

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            int at1g = pictureBox1.Width;
            int at2g = pictureBox2.Width;
            int at3g = pictureBox3.Width;
            int at4g = pictureBox4.Width;
            int at5g = pictureBox5.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rast.Next(10, 25);
            pictureBox2.Left = pictureBox2.Left + rast.Next(10, 25);
            pictureBox3.Left = pictureBox3.Left + rast.Next(10, 25);
            pictureBox4.Left = pictureBox4.Left + rast.Next(10, 25);
            pictureBox5.Left = pictureBox5.Left + rast.Next(10, 25);

            if (at1g + pictureBox1.Left >= bitisuzaklıgı)
            {
                MessageBox.Show("1 numarada ŞİMŞEK kazandı");
                timer1.Enabled = false;
                timer1.Stop();
            }
            else if (at2g + pictureBox2.Left >= bitisuzaklıgı)
            {
                MessageBox.Show("2 numalaı at kazandı");
                timer1.Enabled = false;
                timer1.Stop();
            }
            else if (at3g + pictureBox1.Left >= bitisuzaklıgı)
            {
                MessageBox.Show("PRENSES CEMAL KAZANDI");
                timer1.Enabled = false;
                timer1.Stop();
            }
            else if (at4g + pictureBox4.Left >= bitisuzaklıgı)
            {
                MessageBox.Show("4 numaralı at yarışı kazandı");
                timer1.Enabled = false;
                timer1.Stop();
            }
            else if (at5g + pictureBox5.Left >= bitisuzaklıgı)
            {
                MessageBox.Show("5 numara kazandı");
                timer1.Enabled = false;
                timer1.Stop();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        Random rast = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            atu1 = pictureBox1.Left;
            atu2 = pictureBox2.Left;
            atu3 = pictureBox3.Left;
            atu4 = pictureBox4.Left;
            atu5 = pictureBox5.Left;
        }
    }
}
