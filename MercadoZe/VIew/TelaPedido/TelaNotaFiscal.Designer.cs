namespace MercadoZe.VIew.TelaPedido
{
    partial class TelaNotaFiscal
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
            btn_Finalizado = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_Data = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lbl_TotalFinal = new Label();
            lbl_prodPedido = new Label();
            lbl_qtdPedido = new Label();
            lbl_valorUnitPedido = new Label();
            lbl_valorTotalPedido = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(77, 45);
            label1.Name = "label1";
            label1.Size = new Size(448, 54);
            label1.TabIndex = 0;
            label1.Text = "MERCADO DO ZÉ LTDA";
            // 
            // btn_Finalizado
            // 
            btn_Finalizado.BackColor = SystemColors.ActiveCaption;
            btn_Finalizado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Finalizado.ForeColor = SystemColors.ButtonHighlight;
            btn_Finalizado.Location = new Point(240, 491);
            btn_Finalizado.Name = "btn_Finalizado";
            btn_Finalizado.Size = new Size(108, 29);
            btn_Finalizado.TabIndex = 1;
            btn_Finalizado.Text = "Finalizado";
            btn_Finalizado.TextAlign = ContentAlignment.TopCenter;
            btn_Finalizado.UseVisualStyleBackColor = false;
            btn_Finalizado.Click += btn_Finalizado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(157, 99);
            label2.Name = "label2";
            label2.Size = new Size(305, 21);
            label2.TabIndex = 2;
            label2.Text = "Avenida Senador Queiros, 400 - SBC - SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(214, 130);
            label3.Name = "label3";
            label3.Size = new Size(195, 21);
            label3.TabIndex = 3;
            label3.Text = "CNPJ: 15.325.987/0001-00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(357, 174);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 4;
            label4.Text = "12365 CCF 002 COD:002";
            // 
            // lbl_Data
            // 
            lbl_Data.AutoSize = true;
            lbl_Data.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Data.ForeColor = SystemColors.ButtonHighlight;
            lbl_Data.Location = new Point(100, 174);
            lbl_Data.Name = "lbl_Data";
            lbl_Data.Size = new Size(85, 20);
            lbl_Data.TabIndex = 5;
            lbl_Data.Text = "00/00/0000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(110, 234);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 6;
            label6.Text = "Itens";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(225, 234);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 8;
            label8.Text = "Qtd";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(311, 234);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 9;
            label9.Text = "Valor Unitário";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(451, 234);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 10;
            label10.Text = "Total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(225, 448);
            label11.Name = "label11";
            label11.Size = new Size(60, 28);
            label11.TabIndex = 11;
            label11.Text = "Total:";
            // 
            // lbl_TotalFinal
            // 
            lbl_TotalFinal.AutoSize = true;
            lbl_TotalFinal.BackColor = SystemColors.ActiveCaption;
            lbl_TotalFinal.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalFinal.ForeColor = SystemColors.ButtonHighlight;
            lbl_TotalFinal.Location = new Point(291, 451);
            lbl_TotalFinal.Name = "lbl_TotalFinal";
            lbl_TotalFinal.Size = new Size(82, 25);
            lbl_TotalFinal.TabIndex = 12;
            lbl_TotalFinal.Text = "R$ 00,00";
            // 
            // lbl_prodPedido
            // 
            lbl_prodPedido.BackColor = SystemColors.ButtonHighlight;
            lbl_prodPedido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_prodPedido.Location = new Point(77, 254);
            lbl_prodPedido.Name = "lbl_prodPedido";
            lbl_prodPedido.Size = new Size(111, 182);
            lbl_prodPedido.TabIndex = 15;
            lbl_prodPedido.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_qtdPedido
            // 
            lbl_qtdPedido.BackColor = SystemColors.ButtonHighlight;
            lbl_qtdPedido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_qtdPedido.Location = new Point(187, 254);
            lbl_qtdPedido.Name = "lbl_qtdPedido";
            lbl_qtdPedido.Size = new Size(118, 182);
            lbl_qtdPedido.TabIndex = 17;
            lbl_qtdPedido.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_valorUnitPedido
            // 
            lbl_valorUnitPedido.BackColor = SystemColors.ButtonHighlight;
            lbl_valorUnitPedido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_valorUnitPedido.Location = new Point(305, 254);
            lbl_valorUnitPedido.Name = "lbl_valorUnitPedido";
            lbl_valorUnitPedido.Size = new Size(129, 182);
            lbl_valorUnitPedido.TabIndex = 18;
            lbl_valorUnitPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_valorTotalPedido
            // 
            lbl_valorTotalPedido.BackColor = SystemColors.ButtonHighlight;
            lbl_valorTotalPedido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_valorTotalPedido.Location = new Point(431, 254);
            lbl_valorTotalPedido.Name = "lbl_valorTotalPedido";
            lbl_valorTotalPedido.Size = new Size(87, 182);
            lbl_valorTotalPedido.TabIndex = 19;
            // 
            // TelaNotaFiscal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(605, 532);
            Controls.Add(lbl_valorTotalPedido);
            Controls.Add(lbl_valorUnitPedido);
            Controls.Add(lbl_qtdPedido);
            Controls.Add(lbl_prodPedido);
            Controls.Add(lbl_TotalFinal);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(lbl_Data);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Finalizado);
            Controls.Add(label1);
            Name = "TelaNotaFiscal";
            Text = "TelaNotaFiscal";
            Load += TelaNotaFiscal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Finalizado;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_Data;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lbl_TotalFinal;
        private Label lbl_prodPedido;
        private Label lbl_qtdPedido;
        private Label lbl_valorUnitPedido;
        private Label lbl_valorTotalPedido;
    }
}