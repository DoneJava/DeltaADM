namespace DeltaADM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var produtos = new List<object>
        {
            new { Nome = "Camisa Branca", Preco = 49.90m },
            new { Nome = "Camisa Preta", Preco = 59.90m },
            new { Nome = "Camisa Azul", Preco = 54.90m }
        };
            DGV_Produtos.DataSource = produtos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
