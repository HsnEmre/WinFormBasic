using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int toplamben = 0;
        int toplampc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            int a = rastgele.Next(1, 7);
            int b = rastgele.Next(1, 7);

            toplamben = toplamben + a + b;

            lbl3.Text = a.ToString();
            lbl4.Text = b.ToString();
            label12.Text = toplamben.ToString();

            if (a==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\1.png";

            }
            if (a==2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\2.jpg";

            }
            if (a==3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\3.png";
            }
            if (a==4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\4.jpg";
            }
            if (a==5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\5.png";
            }
            if (a==6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\6.png";
            }


            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\1.png";

            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\2.jpg";

            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\4.jpg";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\6.png";
            }


            if (toplamben > 100 && toplamben > toplampc)
            {
                label9.Text = "kazanan sizsiniz Tebrikler!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);

            toplampc = toplampc + c + d;

            label11.Text = toplampc.ToString();
            label6.Text = c.ToString();
            label5.Text = d.ToString();


            if (c==1)
            {
                pictureBox1.ImageLocation= "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\1.png";
            }
            if (c==2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\2.jpg";
            }
            if (c==3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\3.png";
            }
            if (c==4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\4.jpg";
            }
            if (c==5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\5.png";
            }
            if (c==6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\6.png";
            }


            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\1.png";

            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\2.jpg";

            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\3.png";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\4.jpg";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\5.png";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Hasan\\OneDrive\\Masaüstü\\zar\\6.png";
            }


            if (toplampc>100 && toplampc > toplamben)
            {
                label9.Text = "kazanan bilgisayar siz kaybettiniz ";
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
