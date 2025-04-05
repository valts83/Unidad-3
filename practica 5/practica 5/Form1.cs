namespace practica_5
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textBox1.Text);
            float valor2 = float.Parse(textBox2.Text);
            float valor3 = valor1 * valor2 / 2;

            textBox3.Text = valor3.ToString();
        }
    }
}
