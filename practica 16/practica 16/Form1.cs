namespace practica_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(textBox1.Text);
            if (num % 2 == 0) MessageBox.Show(" EL NUMERO ES PAR");
            else

            if (num % 3 == 0) MessageBox.Show(" EL NUMERO ES IMPAR Y ES DIVISIBLE POR 3");
            else MessageBox.Show("EL NUMERO ES IMPAR ES NO ES DIVISIBLE POR 3");
        }
    }
}
