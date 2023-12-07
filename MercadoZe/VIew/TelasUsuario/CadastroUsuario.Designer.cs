namespace MercadoZe.VIew.TelasUsuario
{
    partial class CadastroUsuario
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
            btn_CadastrarUsuario = new Button();
            tbx_MatriculaFuncionario = new TextBox();
            tbx_EmailUsuario = new TextBox();
            tbx_NomeUsuario = new TextBox();
            btn_BuscarFuncionario = new Button();
            groupBox1 = new GroupBox();
            tbx_SenhaUsuario = new TextBox();
            label6 = new Label();
            cbx_TipoUsuario = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 32);
            label1.Name = "label1";
            label1.Size = new Size(279, 37);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO USUÁRIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(89, 108);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "MATRICULA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(150, 174);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "TIPO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(106, 59);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "NOME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(106, 109);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "EMAIL:";
            // 
            // btn_CadastrarUsuario
            // 
            btn_CadastrarUsuario.BackColor = SystemColors.Control;
            btn_CadastrarUsuario.Location = new Point(401, 243);
            btn_CadastrarUsuario.Name = "btn_CadastrarUsuario";
            btn_CadastrarUsuario.Size = new Size(96, 30);
            btn_CadastrarUsuario.TabIndex = 5;
            btn_CadastrarUsuario.Text = "CADASTRAR";
            btn_CadastrarUsuario.UseVisualStyleBackColor = false;
            btn_CadastrarUsuario.Click += btn_CadastrarUsuario_Click;
            // 
            // tbx_MatriculaFuncionario
            // 
            tbx_MatriculaFuncionario.Location = new Point(89, 131);
            tbx_MatriculaFuncionario.Name = "tbx_MatriculaFuncionario";
            tbx_MatriculaFuncionario.Size = new Size(188, 23);
            tbx_MatriculaFuncionario.TabIndex = 6;
            // 
            // tbx_EmailUsuario
            // 
            tbx_EmailUsuario.Location = new Point(170, 106);
            tbx_EmailUsuario.Name = "tbx_EmailUsuario";
            tbx_EmailUsuario.Size = new Size(202, 25);
            tbx_EmailUsuario.TabIndex = 7;
            // 
            // tbx_NomeUsuario
            // 
            tbx_NomeUsuario.Location = new Point(170, 56);
            tbx_NomeUsuario.Name = "tbx_NomeUsuario";
            tbx_NomeUsuario.Size = new Size(202, 25);
            tbx_NomeUsuario.TabIndex = 8;
            // 
            // btn_BuscarFuncionario
            // 
            btn_BuscarFuncionario.BackColor = SystemColors.MenuBar;
            btn_BuscarFuncionario.Location = new Point(412, 125);
            btn_BuscarFuncionario.Name = "btn_BuscarFuncionario";
            btn_BuscarFuncionario.Size = new Size(96, 32);
            btn_BuscarFuncionario.TabIndex = 10;
            btn_BuscarFuncionario.Text = "BUSCAR";
            btn_BuscarFuncionario.UseVisualStyleBackColor = false;
            btn_BuscarFuncionario.Click += btn_BuscarUsuario_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_SenhaUsuario);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbx_TipoUsuario);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_EmailUsuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbx_NomeUsuario);
            groupBox1.Controls.Add(btn_CadastrarUsuario);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(41, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 279);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMAÇÕES";
            // 
            // tbx_SenhaUsuario
            // 
            tbx_SenhaUsuario.Location = new Point(294, 197);
            tbx_SenhaUsuario.Name = "tbx_SenhaUsuario";
            tbx_SenhaUsuario.Size = new Size(100, 25);
            tbx_SenhaUsuario.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(314, 174);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 10;
            label6.Text = "SENHA";
            // 
            // cbx_TipoUsuario
            // 
            cbx_TipoUsuario.FormattingEnabled = true;
            cbx_TipoUsuario.Items.AddRange(new object[] { "Gerente", "Caixa", "Atendente" });
            cbx_TipoUsuario.Location = new Point(115, 197);
            cbx_TipoUsuario.Name = "cbx_TipoUsuario";
            cbx_TipoUsuario.Size = new Size(121, 25);
            cbx_TipoUsuario.TabIndex = 9;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(581, 470);
            Controls.Add(groupBox1);
            Controls.Add(btn_BuscarFuncionario);
            Controls.Add(tbx_MatriculaFuncionario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroUsuario";
            Text = "Sistema de Gerenciamento de Vendas";
            Load += CadastroUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_CadastrarUsuario;
        private TextBox tbx_MatriculaFuncionario;
        private TextBox tbx_EmailUsuario;
        private TextBox tbx_NomeUsuario;
        private Button btn_BuscarFuncionario;
        private GroupBox groupBox1;
        private ComboBox cbx_TipoUsuario;
        private TextBox tbx_SenhaUsuario;
        private Label label6;
    }
}