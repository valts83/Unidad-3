using System.Numerics;

namespace practica_3_do
{
    public partial class Form1 : Form
    {
        float f_num, Total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton SumarNumeros
            textBox2.Text = Total.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        { 
            //Bot�n A�adir
            listBox1.Items.Add(textBox1.Text);
            //Aqui es donde pasamos el par�metro
            f_num = float.Parse(textBox1.Text);
            Total += f_num;
            textBox1.Text = "";
            textBox1.Focus();
        }

       
        

        }
    }


