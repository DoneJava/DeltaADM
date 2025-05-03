namespace DeltaADM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            DGV_Produtos = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGV_Produtos).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(412, 184);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 115);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "TEXTO BASE";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // DGV_Produtos
            // 
            DGV_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Produtos.Columns.AddRange(new DataGridViewColumn[] { Nome, Preço });
            DGV_Produtos.Location = new Point(38, 133);
            DGV_Produtos.Name = "DGV_Produtos";
            DGV_Produtos.Size = new Size(351, 192);
            DGV_Produtos.TabIndex = 2;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Preço
            // 
            Preço.DataPropertyName = "Preco";
            Preço.HeaderText = "Preço";
            Preço.Name = "Preço";
            Preço.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGV_Produtos);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV_Produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView DGV_Produtos;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preço;
    }
}
