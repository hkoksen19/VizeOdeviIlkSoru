using System;
using System.Windows.Forms;

namespace VizeOdeviIlkSoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Denklem Sistemini Çözme";
            label1.Text = "a Değeri:";
            label2.Text = "b Değeri:";
            label3.Text = "c Değeri:";
            label4.Text = "d Değeri:";
            label5.Text = "e Değeri:";
            label6.Text = "f Değeri:";
            label7.Text = "Denklem sistemi";
            button1.Text = "Denkem Sistemini Çöz";
            button2.Text = "Çıkış";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double A, B, C, D, E, F;
            double x, y;

            A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            C = Convert.ToDouble(textBox3.Text);
            D = Convert.ToDouble(textBox4.Text);
            E = Convert.ToDouble(textBox5.Text);
            F = Convert.ToDouble(textBox6.Text);
            if (A * D - B * C == 0)
            { MessageBox.Show("Payda 0 lütfen sayıları değiştiriniz."); }

            else if (A * D - B * C != 0) { 
            listBox1.Items.Add(A.ToString() + "x+" + B.ToString() + "y=e");
            listBox1.Items.Add(C.ToString() + "x+" + D.ToString() + "y=f");
            x = ((E * D) - (B * F)) / ((A * D) - (B * C));
            y = ((A * F) - (C * E)) / ((A * D) - (B * C));




            listBox1.Items.Add("x= " + x.ToString());
            listBox1.Items.Add("y= " + y.ToString());
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
