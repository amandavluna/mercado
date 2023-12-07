namespace MercadoZe.VIew.TelasProduto
{
    partial class AlterarProduto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbx_MatriculaProduto = new TextBox();
            tbx_Marca = new TextBox();
            tbx_Nome = new TextBox();
            btn_Alterar = new Button();
            tbx_Valor = new TextBox();
            btn_Buscar1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 32);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 0;
            label1.Text = "Alterar Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 116);
            label2.Name = "label2";
            label2.Size = new Size(170, 21);
            label2.TabIndex = 1;
            label2.Text = "Matrícula do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 186);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(103, 231);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(103, 276);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Valor:";
            // 
            // tbx_MatriculaProduto
            // 
            tbx_MatriculaProduto.Location = new Point(201, 116);
            tbx_MatriculaProduto.Name = "tbx_MatriculaProduto";
            tbx_MatriculaProduto.Size = new Size(178, 23);
            tbx_MatriculaProduto.TabIndex = 5;
            // 
            // tbx_Marca
            // 
            tbx_Marca.Location = new Point(164, 232);
            tbx_Marca.Name = "tbx_Marca";
            tbx_Marca.Size = new Size(244, 23);
            tbx_Marca.TabIndex = 6;
            tbx_Marca.TextChanged += textBox2_TextChanged;
            // 
            // tbx_Nome
            // 
            tbx_Nome.Location = new Point(164, 187);
            tbx_Nome.Name = "tbx_Nome";
            tbx_Nome.Size = new Size(244, 23);
            tbx_Nome.TabIndex = 7;
            // 
            // btn_Alterar
            // 
            btn_Alterar.Location = new Point(231, 323);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(83, 34);
            btn_Alterar.TabIndex = 10;
            btn_Alterar.Text = "Alterar";
            btn_Alterar.UseVisualStyleBackColor = true;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // tbx_Valor
            // 
            tbx_Valor.Location = new Point(164, 277);
            tbx_Valor.Name = "tbx_Valor";
            tbx_Valor.Size = new Size(244, 23);
            tbx_Valor.TabIndex = 11;
            // 
            // btn_Buscar1
            // 
            btn_Buscar1.Location = new Point(412, 115);
            btn_Buscar1.Name = "btn_Buscar1";
            btn_Buscar1.Size = new Size(75, 23);
            btn_Buscar1.TabIndex = 12;
            btn_Buscar1.Text = "Buscar";
            btn_Buscar1.UseVisualStyleBackColor = true;
            btn_Buscar1.Click += btn_Buscar1_Click;
            // 
            // AlterarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 369);
            Controls.Add(btn_Buscar1);
            Controls.Add(tbx_Valor);
            Controls.Add(btn_Alterar);
            Controls.Add(tbx_Nome);
            Controls.Add(tbx_Marca);
            Controls.Add(tbx_MatriculaProduto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlterarProduto";
            Text = "AlterarProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbx_MatriculaProduto;
        private TextBox tbx_Marca;
        private TextBox tbx_Nome;
        private Button btn_Alterar;
        private TextBox tbx_Valor;
        private Button btn_Buscar1;
    }
}