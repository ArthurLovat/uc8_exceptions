namespace uc8_exceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try
            {
                float valor = 0, total = 0;
                int quantidade = 0;

                valor = float.Parse(txtvalor.Text);
                quantidade = Convert.ToInt32(txtQuantidade.Text);

                total = valor * quantidade;

                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar calcular: " + ex.Message);
            }
        }
    }
}
