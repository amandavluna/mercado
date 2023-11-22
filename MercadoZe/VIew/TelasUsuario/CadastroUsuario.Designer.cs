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
            tbx_TipoUsuario = new TextBox();
            tbx_CodigoCliente = new TextBox();
            tbx_CodigoFuncionario = new TextBox();
            btn_BuscarUsuario = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
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
            // tbx_TipoUsuario
            // 
            tbx_TipoUsuario.Location = new Point(89, 131);
            tbx_TipoUsuario.Name = "tbx_TipoUsuario";
            tbx_TipoUsuario.Size = new Size(188, 23);
            tbx_TipoUsuario.TabIndex = 6;
            // 
            // tbx_CodigoCliente
            // 
            tbx_CodigoCliente.Location = new Point(170, 106);
            tbx_CodigoCliente.Name = "tbx_CodigoCliente";
            tbx_CodigoCliente.Size = new Size(202, 25);
            tbx_CodigoCliente.TabIndex = 7;
            // 
            // tbx_CodigoFuncionario
            // 
            tbx_CodigoFuncionario.Location = new Point(170, 56);
            tbx_CodigoFuncionario.Name = "tbx_CodigoFuncionario";
            tbx_CodigoFuncionario.Size = new Size(202, 25);
            tbx_CodigoFuncionario.TabIndex = 8;
            // 
            // btn_BuscarUsuario
            // 
            btn_BuscarUsuario.BackColor = SystemColors.MenuBar;
            btn_BuscarUsuario.Location = new Point(412, 125);
            btn_BuscarUsuario.Name = "btn_BuscarUsuario";
            btn_BuscarUsuario.Size = new Size(96, 32);
            btn_BuscarUsuario.TabIndex = 10;
            btn_BuscarUsuario.Text = "BUSCAR";
            btn_BuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_CodigoCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbx_CodigoFuncionario);
            groupBox1.Controls.Add(btn_CadastrarUsuario);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(41, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 279);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMAÇÕES";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 11;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(115, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 9;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(581, 470);
            Controls.Add(groupBox1);
            Controls.Add(btn_BuscarUsuario);
            Controls.Add(tbx_TipoUsuario);
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
        private TextBox tbx_TipoUsuario;
        private TextBox tbx_CodigoCliente;
        private TextBox tbx_CodigoFuncionario;
        private Button btn_BuscarUsuario;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label6;
    }
}