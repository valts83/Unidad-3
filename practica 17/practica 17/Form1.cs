namespace practica_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);

            if (a > b)
            {
                if (b > c)
                {
                    if (b > c) // Esta condición es redundante, ya se comprobó b > c
                    {
                        textBox4.Text = a.ToString();
                        textBox5.Text = b.ToString();
                        textBox6.Text = c.ToString();
                    }
                    else
                    {
                        textBox4.Text = a.ToString();
                        textBox5.Text = c.ToString();
                        textBox6.Text = b.ToString();
                    }
                }
                else
                {
                    textBox4.Text = c.ToString();
                    textBox5.Text = a.ToString();
                    textBox6.Text = b.ToString();
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        textBox4.Text = b.ToString();
                        textBox5.Text = a.ToString();
                        textBox6.Text = c.ToString();
                    }
                    else
                    {
                        textBox4.Text = b.ToString();
                        textBox5.Text = c.ToString();
                        textBox6.Text = a.ToString();
                    }
                }
                else
                {
                    textBox4.Text = c.ToString();
                    textBox5.Text = b.ToString();
                    textBox6.Text = a.ToString();
                }
            }
        }
    }
}
