namespace CarlosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCriarProduto fcp = new formCriarProduto();
            var resultado = fcp.ShowDialog();
            if (resultado == DialogResult.OK) {
                string textoProduto = $"{fcp.NomeProduto}({fcp.Fabricante}) " +
                    $"pre�o de compra  [R$ {fcp.PrecoCompra}] " +
                    $"pre�o de Venda  [R$ {fcp.PrecoVenda}]";
                listBox1.Items.Add(textoProduto);
        }
        }
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
