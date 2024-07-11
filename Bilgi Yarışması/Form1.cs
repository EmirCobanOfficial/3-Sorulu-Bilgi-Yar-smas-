namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruno = 0;
        int doğru = 0;
        int yanlış = 0;
        int süre = 20;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            süre = 20;
            label9.Text = süre.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            button5.Text = "İLERİ";
            soruno++;
            label2.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Mustafa Kemal kaç  yılındı vefat etti";
                button1.Text = "1938";
                button2.Text = "1937";
                button3.Text = "1927";
                button4.Text = "1923";
                label4.Text = "1938";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiye Çoğrafi konumda kaça ayrılır?";
                button1.Text = "7";
                button2.Text = "21";
                button3.Text = "69";
                button4.Text = "81";
                label4.Text = "7";

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Türkiye'nin en büyük yüz ölçümü hangisidir?";

                button1.Text = "Konya";
                button2.Text = "Ankara";
                button3.Text = "Aydın";
                button4.Text = "Manisa";
                label4.Text = "Konya";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;


            label3.Text = button1.Text;
            if (label3.Text == label4.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;

            label3.Text = button3.Text;
            if (label3.Text == label4.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;

            label3.Text = button2.Text;
            if (label3.Text == label4.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;

            label3.Text = button4.Text;
            if (label3.Text == label4.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre = Convert.ToInt32(label9.Text);

            süre = süre - 1;
            label9.Text = süre.ToString();

            if (süre == 0)
            {
                timer1.Enabled = false;
                yanlış++;
                label8.Text = yanlış.ToString();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}