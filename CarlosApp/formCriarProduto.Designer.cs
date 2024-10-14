namespace CarlosApp
{
    partial class formCriarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCriarProduto));
            Frabricante = new TextBox();
            nomeProduto = new TextBox();
            precoCompra = new NumericUpDown();
            precoVenda = new NumericUpDown();
            labelNomedoProduto = new Label();
            buttonFabricante = new Label();
            labelPrecoDeCompra = new Label();
            labelPrecodeVenda = new Label();
            buttonOk = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)precoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)precoVenda).BeginInit();
            SuspendLayout();
            // 
            // Frabricante
            // 
            Frabricante.Location = new Point(174, 47);
            Frabricante.Name = "Frabricante";
            Frabricante.Size = new Size(100, 23);
            Frabricante.TabIndex = 0;
            Frabricante.TextChanged += textBox1_TextChanged;
            // 
            // nomeProduto
            // 
            nomeProduto.Location = new Point(174, 10);
            nomeProduto.Name = "nomeProduto";
            nomeProduto.Size = new Size(100, 23);
            nomeProduto.TabIndex = 1;
            nomeProduto.TextChanged += textBox2_TextChanged;
            // 
            // precoCompra
            // 
            precoCompra.BorderStyle = BorderStyle.None;
            precoCompra.DecimalPlaces = 2;
            precoCompra.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            precoCompra.Location = new Point(174, 95);
            precoCompra.Name = "precoCompra";
            precoCompra.Size = new Size(100, 19);
            precoCompra.TabIndex = 2;
            precoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // precoVenda
            // 
            precoVenda.DecimalPlaces = 2;
            precoVenda.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            precoVenda.Location = new Point(174, 120);
            precoVenda.Name = "precoVenda";
            precoVenda.Size = new Size(100, 23);
            precoVenda.TabIndex = 3;
            precoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // labelNomedoProduto
            // 
            labelNomedoProduto.AutoSize = true;
            labelNomedoProduto.BackColor = SystemColors.ControlLight;
            labelNomedoProduto.ForeColor = Color.Black;
            labelNomedoProduto.Location = new Point(22, 13);
            labelNomedoProduto.Name = "labelNomedoProduto";
            labelNomedoProduto.Size = new Size(103, 15);
            labelNomedoProduto.TabIndex = 4;
            labelNomedoProduto.Text = "Nome do Produto";
            labelNomedoProduto.Click += label1_Click;
            // 
            // buttonFabricante
            // 
            buttonFabricante.AutoSize = true;
            buttonFabricante.BackColor = Color.White;
            buttonFabricante.ForeColor = SystemColors.ActiveCaptionText;
            buttonFabricante.Location = new Point(22, 50);
            buttonFabricante.Name = "buttonFabricante";
            buttonFabricante.Size = new Size(60, 15);
            buttonFabricante.TabIndex = 5;
            buttonFabricante.Text = "fabricante";
            // 
            // labelPrecoDeCompra
            // 
            labelPrecoDeCompra.AutoSize = true;
            labelPrecoDeCompra.BackColor = Color.MintCream;
            labelPrecoDeCompra.ForeColor = SystemColors.ActiveCaptionText;
            labelPrecoDeCompra.Location = new Point(22, 95);
            labelPrecoDeCompra.Name = "labelPrecoDeCompra";
            labelPrecoDeCompra.Size = new Size(99, 15);
            labelPrecoDeCompra.TabIndex = 6;
            labelPrecoDeCompra.Text = "Preco de Compra";
            labelPrecoDeCompra.Click += labelPrecoDeCompra_Click;
            // 
            // labelPrecodeVenda
            // 
            labelPrecodeVenda.AutoSize = true;
            labelPrecodeVenda.BackColor = Color.White;
            labelPrecodeVenda.ForeColor = Color.Black;
            labelPrecodeVenda.Location = new Point(22, 120);
            labelPrecodeVenda.Name = "labelPrecodeVenda";
            labelPrecodeVenda.Size = new Size(88, 15);
            labelPrecodeVenda.TabIndex = 7;
            labelPrecodeVenda.Text = "Preco de Venda";
            labelPrecodeVenda.Click += labelPrecodeVenda_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(22, 151);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(48, 23);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.ForeColor = SystemColors.ControlText;
            buttonCancel.Location = new Point(174, 151);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // formCriarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(284, 193);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(labelPrecodeVenda);
            Controls.Add(labelPrecoDeCompra);
            Controls.Add(buttonFabricante);
            Controls.Add(labelNomedoProduto);
            Controls.Add(precoVenda);
            Controls.Add(precoCompra);
            Controls.Add(nomeProduto);
            Controls.Add(Frabricante);
            Name = "formCriarProduto";
            Text = "formCriarProduto";
            ((System.ComponentModel.ISupportInitialize)precoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)precoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Frabricante;
        private TextBox nomeProduto;
        private NumericUpDown precoCompra;
        private NumericUpDown precoVenda;
        private Label labelNomedoProduto;
        private Label buttonFabricante;
        private Label labelPrecoDeCompra;
        private Label labelPrecodeVenda;
        private Button buttonOk;
        private Button buttonCancel;
    }
}