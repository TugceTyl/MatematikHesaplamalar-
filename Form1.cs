namespace MatematikHesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar, alan, çevre;

            birkenar = Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            çevre = birkenar * 4;

            label4.Text = alan.ToString();
            label6.Text = çevre.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
            //textBox2.Visible = false;
            label1.Text = "KARE";
            button2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button4.Visible = false;
            //button2.Visible=true; 
            label1.Text = "DİKTÖRTGEN";
            label2.Text = "Kısa Kenar";
            panel1.Visible = true;




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kısa, uzun, alan, çevre;
            
            kısa= Convert.ToInt32(textBox1.Text);   
            uzun= Convert.ToInt32(textBox2.Text);

            alan = kısa * uzun;
            çevre = (2 * kısa) + (2 * uzun);

            label4.Text = alan.ToString();
            label6.Text = çevre.ToString();
        }
    }
}