namespace MercadoZe.VIew.TelasProduto
{
    partial class CadastroProduto
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
            btn_CadastrarProduto = new Button();
            tbx_NomeProduto = new TextBox();
            tbx_MarcaProduto = new TextBox();
            tbx_ValorProduto = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(107, 47);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO PRODUTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(207, 130);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "NOME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(208, 211);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "MARCA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(206, 282);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 3;
            label4.Text = "VALOR:";
            // 
            // btn_CadastrarProduto
            // 
            btn_CadastrarProduto.BackColor = SystemColors.ControlLightLight;
            btn_CadastrarProduto.Location = new Point(193, 379);
            btn_CadastrarProduto.Name = "btn_CadastrarProduto";
            btn_CadastrarProduto.Size = new Size(99, 33);
            btn_CadastrarProduto.TabIndex = 4;
            btn_CadastrarProduto.Text = "Cadastrar";
            btn_CadastrarProduto.UseVisualStyleBackColor = false;
            btn_CadastrarProduto.Click += button1_Click;
            // 
            // tbx_NomeProduto
            // 
            tbx_NomeProduto.Location = new Point(148, 153);
            tbx_NomeProduto.Name = "tbx_NomeProduto";
            tbx_NomeProduto.Size = new Size(185, 23);
            tbx_NomeProduto.TabIndex = 5;
            // 
            // tbx_MarcaProduto
            // 
            tbx_MarcaProduto.Location = new Point(148, 242);
            tbx_MarcaProduto.Name = "tbx_MarcaProduto";
            tbx_MarcaProduto.Size = new Size(185, 23);
            tbx_MarcaProduto.TabIndex = 6;
            // 
            // tbx_ValorProduto
            // 
            tbx_ValorProduto.Location = new Point(148, 316);
            tbx_ValorProduto.Name = "tbx_ValorProduto";
            tbx_ValorProduto.Size = new Size(185, 23);
            tbx_ValorProduto.TabIndex = 7;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(tbx_ValorProduto);
            Controls.Add(tbx_MarcaProduto);
            Controls.Add(tbx_NomeProduto);
            Controls.Add(btn_CadastrarProduto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_CadastrarProduto;
        private TextBox tbx_NomeProduto;
        private TextBox tbx_MarcaProduto;
        private TextBox tbx_ValorProduto;
    }
}