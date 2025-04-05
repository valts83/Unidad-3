namespace practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double Radius, Height;

            double BaseArea, LateralArea, TotalArea;

            double Volume;

            Radius = double.Parse(textBox1.Text);

            Height = double.Parse(textBox2.Text);

            BaseArea = Radius * Radius * Math.PI;

            LateralArea = 2 * Math.PI * Radius * Height;

            TotalArea = 2 * Math.PI * Radius * (Height + Radius);

            Volume = Math.PI * Radius * Radius * Height;

            textBox3.Text = BaseArea.ToString("0.##");

            textBox4.Text = LateralArea.ToString("0.##");

            textBox5.Text = TotalArea.ToString("0.##");

            textBox6.Text = Volume.ToString("0.##");
        }
    }
}
