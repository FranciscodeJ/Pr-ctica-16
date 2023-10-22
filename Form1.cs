namespace Práctica_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;                       //Se declaran las variables a usar.
            num = int.Parse(textBox1.Text);           //Se declara que el número será el que escribamos en la caja 1.
            if (num % 2 == 0) MessageBox.Show("El número es par");   //Se aplica un condicional que activará un mensaje si se sumple, si no, no lo hará.
            else                                                     //Si no lo hace, activará otro condicional.
            {
                if (num % 3 == 0) MessageBox.Show("El número es impar y divisible por 3"); //Este, si se cumple, activará otro mensaje, si no, entonces otro más.
                else MessageBox.Show("El número es impar y no es divisible por 3");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";      //Se declara que al apretar el botón se elimine lo aparecido en caja 1 y 2.
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}