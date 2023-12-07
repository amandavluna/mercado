namespace MercadoZe.VIew.TelasCliente
{
    partial class DeletarCliente
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
            btn_Buscar = new Button();
            groupBox1 = new GroupBox();
            mtbx_Fone = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbx_Email = new TextBox();
            tbx_Nome = new TextBox();
            btn_Excluir = new Button();
            tbx_Matricula = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = SystemColors.MenuBar;
            btn_Buscar.Location = new Point(414, 119);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(96, 32);
            btn_Buscar.TabIndex = 30;
            btn_Buscar.Text = "BUSCAR";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtbx_Fone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_Email);
            groupBox1.Controls.Add(tbx_Nome);
            groupBox1.Controls.Add(btn_Excluir);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(19, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 279);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMAÇÕES";
            // 
            // mtbx_Fone
            // 
            mtbx_Fone.Location = new Point(158, 169);
            mtbx_Fone.Mask = "(99) 0000-0000";
            mtbx_Fone.Name = "mtbx_Fone";
            mtbx_Fone.Size = new Size(204, 25);
            mtbx_Fone.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(82, 174);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 12;
            label3.Text = "CELULAR:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 72);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "NOME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(94, 122);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "EMAIL:";
            // 
            // tbx_Email
            // 
            tbx_Email.Location = new Point(158, 119);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(202, 25);
            tbx_Email.TabIndex = 7;
            // 
            // tbx_Nome
            // 
            tbx_Nome.Location = new Point(158, 69);
            tbx_Nome.Name = "tbx_Nome";
            tbx_Nome.Size = new Size(202, 25);
            tbx_Nome.TabIndex = 8;
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = SystemColors.MenuBar;
            btn_Excluir.Location = new Point(216, 228);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(91, 34);
            btn_Excluir.TabIndex = 5;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = false;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // tbx_Matricula
            // 
            tbx_Matricula.Location = new Point(33, 128);
            tbx_Matricula.Name = "tbx_Matricula";
            tbx_Matricula.Size = new Size(255, 23);
            tbx_Matricula.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 37);
            label1.Name = "label1";
            label1.Size = new Size(234, 37);
            label1.TabIndex = 27;
            label1.Text = "DELETAR CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(106, 104);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 28;
            label2.Text = "MATRICULA";
            // 
            // DeletarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 476);
            Controls.Add(btn_Buscar);
            Controls.Add(groupBox1);
            Controls.Add(tbx_Matricula);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "DeletarCliente";
            Text = "DeletarCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Buscar;
        private GroupBox groupBox1;
        private MaskedTextBox mtbx_Fone;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbx_Email;
        private TextBox tbx_Nome;
        private Button btn_Excluir;
        private TextBox tbx_Matricula;
        private Label label1;
        private Label label2;
    }
}