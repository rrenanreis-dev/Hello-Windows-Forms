namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = $"IMC Calculado:{imc:F2}";

            if (imc < 18.5)
            {
                lblSituacao.Text = "Situação: Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                lblSituacao.Text = "Situação: Peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                lblSituacao.Text = "Situação: Acima do peso (Sobrepeso)";
            }
            else
            {
                lblSituacao.Text = "Situação: Obesidade";
            }
        }
    }
}
