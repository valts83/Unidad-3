


using System;
using System.Windows.Forms;

namespace practica_6_do
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBox1.Text);
                if (numero % 2 == 0)
                    listBox1.Items.Add(numero + " Par");
                else
                    listBox1.Items.Add(numero + " Impar");

                textBox1.Focus();
                textBox1.SelectAll(); // Opcional: selecciona todo el texto para facilitar nueva entrada
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

