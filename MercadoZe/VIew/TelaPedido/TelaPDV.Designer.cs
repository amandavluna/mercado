namespace MercadoZe.VIew.TelaPedido
{
    partial class TelaPDV
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
            tbx_CodigoBarra = new TextBox();
            tbx_Qtde = new TextBox();
            btn_Confirmar = new Button();
            btrn_FecharVenda = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridViewPDV = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            prod = new DataGridViewTextBoxColumn();
            qtde = new DataGridViewTextBoxColumn();
            unitario = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            lbl_CodigoBarra = new Label();
            lbl_Produto = new Label();
            lbl_ValorUnitario = new Label();
            label10 = new Label();
            lbl_Venda = new Label();
            btn_Buscar = new Button();
            lbl_Total = new Label();
            label8 = new Label();
            lbl_Qtde = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPDV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(214, 28);
            label1.Name = "label1";
            label1.Size = new Size(278, 37);
            label1.TabIndex = 0;
            label1.Text = "PDV - Mercado do Zé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 110);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 1;
            label2.Text = "Código de barras";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(397, 110);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // tbx_CodigoBarra
            // 
            tbx_CodigoBarra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_CodigoBarra.Location = new Point(12, 134);
            tbx_CodigoBarra.Name = "tbx_CodigoBarra";
            tbx_CodigoBarra.Size = new Size(176, 29);
            tbx_CodigoBarra.TabIndex = 3;
            tbx_CodigoBarra.TextChanged += textBox1_TextChanged;
            // 
            // tbx_Qtde
            // 
            tbx_Qtde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_Qtde.Location = new Point(364, 134);
            tbx_Qtde.Name = "tbx_Qtde";
            tbx_Qtde.Size = new Size(159, 29);
            tbx_Qtde.TabIndex = 4;
            tbx_Qtde.TextChanged += tbx_Qtde_TextChanged;
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.Location = new Point(639, 481);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(117, 34);
            btn_Confirmar.TabIndex = 5;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = true;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // btrn_FecharVenda
            // 
            btrn_FecharVenda.Location = new Point(196, 543);
            btrn_FecharVenda.Name = "btrn_FecharVenda";
            btrn_FecharVenda.Size = new Size(392, 32);
            btrn_FecharVenda.TabIndex = 6;
            btrn_FecharVenda.Text = "Fechar Venda";
            btrn_FecharVenda.UseVisualStyleBackColor = true;
            btrn_FecharVenda.Click += btrn_FecharVenda_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(652, 181);
            label4.Name = "label4";
            label4.Size = new Size(106, 17);
            label4.TabIndex = 7;
            label4.Text = "Código de Barra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(700, 236);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 8;
            label5.Text = "Produto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(668, 354);
            label6.Name = "label6";
            label6.Size = new Size(90, 17);
            label6.TabIndex = 9;
            label6.Text = "Valor Unitário";
            // 
            // dataGridViewPDV
            // 
            dataGridViewPDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPDV.Columns.AddRange(new DataGridViewColumn[] { Codigo, prod, qtde, unitario, total });
            dataGridViewPDV.Location = new Point(12, 197);
            dataGridViewPDV.Name = "dataGridViewPDV";
            dataGridViewPDV.RowHeadersVisible = false;
            dataGridViewPDV.RowTemplate.Height = 25;
            dataGridViewPDV.Size = new Size(576, 266);
            dataGridViewPDV.TabIndex = 10;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            // 
            // prod
            // 
            prod.HeaderText = "Produto";
            prod.Name = "prod";
            // 
            // qtde
            // 
            qtde.HeaderText = "Quantidade";
            qtde.Name = "qtde";
            // 
            // unitario
            // 
            unitario.HeaderText = "Unitário";
            unitario.Name = "unitario";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            // 
            // lbl_CodigoBarra
            // 
            lbl_CodigoBarra.BackColor = SystemColors.ButtonHighlight;
            lbl_CodigoBarra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CodigoBarra.Location = new Point(626, 214);
            lbl_CodigoBarra.Name = "lbl_CodigoBarra";
            lbl_CodigoBarra.Size = new Size(130, 16);
            lbl_CodigoBarra.TabIndex = 11;
            // 
            // lbl_Produto
            // 
            lbl_Produto.BackColor = SystemColors.ButtonHighlight;
            lbl_Produto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Produto.Location = new Point(628, 269);
            lbl_Produto.Name = "lbl_Produto";
            lbl_Produto.Size = new Size(128, 21);
            lbl_Produto.TabIndex = 12;
            // 
            // lbl_ValorUnitario
            // 
            lbl_ValorUnitario.BackColor = SystemColors.ButtonHighlight;
            lbl_ValorUnitario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ValorUnitario.Location = new Point(628, 387);
            lbl_ValorUnitario.Name = "lbl_ValorUnitario";
            lbl_ValorUnitario.Size = new Size(130, 22);
            lbl_ValorUnitario.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(405, 466);
            label10.Name = "label10";
            label10.Size = new Size(118, 21);
            label10.TabIndex = 14;
            label10.Text = "Valor da Venda";
            // 
            // lbl_Venda
            // 
            lbl_Venda.BackColor = SystemColors.ButtonHighlight;
            lbl_Venda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Venda.Location = new Point(343, 492);
            lbl_Venda.Name = "lbl_Venda";
            lbl_Venda.Size = new Size(180, 23);
            lbl_Venda.TabIndex = 15;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(639, 130);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(113, 33);
            btn_Buscar.TabIndex = 16;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // lbl_Total
            // 
            lbl_Total.BackColor = SystemColors.ButtonHighlight;
            lbl_Total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Total.Location = new Point(630, 443);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(130, 22);
            lbl_Total.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(689, 419);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 17;
            label8.Text = "Valor Total";
            // 
            // lbl_Qtde
            // 
            lbl_Qtde.BackColor = SystemColors.ButtonHighlight;
            lbl_Qtde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Qtde.Location = new Point(630, 326);
            lbl_Qtde.Name = "lbl_Qtde";
            lbl_Qtde.Size = new Size(130, 16);
            lbl_Qtde.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(681, 302);
            label9.Name = "label9";
            label9.Size = new Size(79, 17);
            label9.TabIndex = 20;
            label9.Text = "Quantidade";
            // 
            // TelaPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 587);
            Controls.Add(label9);
            Controls.Add(lbl_Qtde);
            Controls.Add(lbl_Total);
            Controls.Add(label8);
            Controls.Add(btn_Buscar);
            Controls.Add(lbl_Venda);
            Controls.Add(label10);
            Controls.Add(lbl_ValorUnitario);
            Controls.Add(lbl_Produto);
            Controls.Add(lbl_CodigoBarra);
            Controls.Add(dataGridViewPDV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btrn_FecharVenda);
            Controls.Add(btn_Confirmar);
            Controls.Add(tbx_Qtde);
            Controls.Add(tbx_CodigoBarra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaPDV";
            Text = "TelaPDV";
            Load += TelaPDV_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbx_CodigoBarra;
        private TextBox tbx_Qtde;
        private Button btn_Confirmar;
        private Button btrn_FecharVenda;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_CodigoBarra;
        private Label lbl_Produto;
        private Label lbl_ValorUnitario;
        private Label label10;
        private Label lbl_Venda;
        private Button btn_Buscar;
        private Label lbl_Total;
        private Label label8;
        private Label lbl_Qtde;
        private Label label9;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn prod;
        private DataGridViewTextBoxColumn qtde;
        private DataGridViewTextBoxColumn unitario;
        private DataGridViewTextBoxColumn total;
        public DataGridView dataGridViewPDV;
    }
}