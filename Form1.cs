namespace Practica_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;
            lado1 = double.Parse(textBox1.Text);
            lado2 = double.Parse(textBox2.Text);
            lado3 = double.Parse(textBox3.Text);

            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                textBox4.Text = "No es un tri�ngulo v�lido";
            }
            else if (lado1 == lado2 && lado2 == lado3)
            {
                textBox4.Text = "Equil�tero";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                textBox4.Text = "Is�sceles";
            }
            else
            {
                textBox4.Text = "Escaleno";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}