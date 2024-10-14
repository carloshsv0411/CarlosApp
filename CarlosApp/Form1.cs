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
                    $"preço de compra  [R$ {fcp.PrecoCompra}] " +
                    $"preço de Venda  [R$ {fcp.PrecoVenda}]";
                listBox1.Items.Add(textoProduto);
        }
        }
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
