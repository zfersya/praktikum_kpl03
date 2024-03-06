using System.Numerics;

namespace Modul3_1302223090
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();

        }
        int a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text += button1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text += button0.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            a = Int32.Parse(label1.Text);
            label1.Text = "";
   
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = Int32.Parse(label1.Text);
            label1.Text = (a +b).ToString();    
        }
    }
}
