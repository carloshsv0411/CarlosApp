

using System.Windows.Forms;

namespace CarlosApp
{
    public partial class formCriarProduto : Form
    {

        public formCriarProduto()
        {
            InitializeComponent();
        }
        public string NomeProduto { get { return this.nomeProduto.Text; } }
        public string Fabricante { get { return this.buttonFabricante.Text; } }
        public float PrecoCompra { get { return (float)this.precoCompra.Value; } }
        public float PrecoVenda { get { return (float)this.precoVenda.Value; } }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPrecodeVenda_Click(object sender, EventArgs e)
        {

        }

        private void labelPrecoDeCompra_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
