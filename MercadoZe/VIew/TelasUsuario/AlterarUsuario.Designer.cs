namespace MercadoZe.VIew.TelasUsuario
{
    partial class AlterarUsuario
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
            groupBox1 = new GroupBox();
            tbx_SenhaAlterar = new TextBox();
            label6 = new Label();
            cbx_TipoAlterar = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tbx_EmailAlterar = new TextBox();
            label3 = new Label();
            tbx_nomeAlterar = new TextBox();
            btn_AlterarUsuario = new Button();
            btn_BuscarAlterar = new Button();
            tbx_MatriculaAlterar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_SenhaAlterar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbx_TipoAlterar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_EmailAlterar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbx_nomeAlterar);
            groupBox1.Controls.Add(btn_AlterarUsuario);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(38, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 279);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMAÇÕES";
            // 
            // tbx_SenhaAlterar
            // 
            tbx_SenhaAlterar.Location = new Point(280, 189);
            tbx_SenhaAlterar.Name = "tbx_SenhaAlterar";
            tbx_SenhaAlterar.Size = new Size(110, 25);
            tbx_SenhaAlterar.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(306, 166);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 10;
            label6.Text = "SENHA";
            // 
            // cbx_TipoAlterar
            // 
            cbx_TipoAlterar.FormattingEnabled = true;
            cbx_TipoAlterar.Items.AddRange(new object[] { "Gerente", "Atendente", "Caixa" });
            cbx_TipoAlterar.Location = new Point(101, 189);
            cbx_TipoAlterar.Name = "cbx_TipoAlterar";
            cbx_TipoAlterar.Size = new Size(121, 25);
            cbx_TipoAlterar.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(92, 51);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "NOME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(92, 101);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "EMAIL:";
            // 
            // tbx_EmailAlterar
            // 
            tbx_EmailAlterar.Location = new Point(156, 98);
            tbx_EmailAlterar.Name = "tbx_EmailAlterar";
            tbx_EmailAlterar.Size = new Size(202, 25);
            tbx_EmailAlterar.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(136, 166);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "TIPO";
            // 
            // tbx_nomeAlterar
            // 
            tbx_nomeAlterar.Location = new Point(156, 48);
            tbx_nomeAlterar.Name = "tbx_nomeAlterar";
            tbx_nomeAlterar.Size = new Size(202, 25);
            tbx_nomeAlterar.TabIndex = 8;
            // 
            // btn_AlterarUsuario
            // 
            btn_AlterarUsuario.BackColor = SystemColors.MenuBar;
            btn_AlterarUsuario.Location = new Point(382, 239);
            btn_AlterarUsuario.Name = "btn_AlterarUsuario";
            btn_AlterarUsuario.Size = new Size(100, 34);
            btn_AlterarUsuario.TabIndex = 5;
            btn_AlterarUsuario.Text = "ALTERAR";
            btn_AlterarUsuario.UseVisualStyleBackColor = false;
            btn_AlterarUsuario.Click += btn_CadastrarUsuario_Click;
            // 
            // btn_BuscarAlterar
            // 
            btn_BuscarAlterar.BackColor = SystemColors.MenuBar;
            btn_BuscarAlterar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_BuscarAlterar.Location = new Point(420, 144);
            btn_BuscarAlterar.Name = "btn_BuscarAlterar";
            btn_BuscarAlterar.Size = new Size(96, 32);
            btn_BuscarAlterar.TabIndex = 18;
            btn_BuscarAlterar.Text = "BUSCAR";
            btn_BuscarAlterar.UseVisualStyleBackColor = false;
            btn_BuscarAlterar.Click += button1_Click;
            // 
            // tbx_MatriculaAlterar
            // 
            tbx_MatriculaAlterar.Location = new Point(59, 153);
            tbx_MatriculaAlterar.Name = "tbx_MatriculaAlterar";
            tbx_MatriculaAlterar.Size = new Size(188, 23);
            tbx_MatriculaAlterar.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(107, 130);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 16;
            label2.Text = "MATRÍCULA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 36);
            label1.Name = "label1";
            label1.Size = new Size(250, 37);
            label1.TabIndex = 19;
            label1.Text = "ALTERAR USUÁRIO";
            // 
            // AlterarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(581, 530);
            Controls.Add(label1);
            Controls.Add(btn_BuscarAlterar);
            Controls.Add(tbx_MatriculaAlterar);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "AlterarUsuario";
            Text = "Sistema de Gerenciamento de Vendas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbx_SenhaAlterar;
        private Label label6;
        private ComboBox cbx_TipoAlterar;
        private Label label4;
        private Label label5;
        private TextBox tbx_EmailAlterar;
        private Label label3;
        private TextBox tbx_nomeAlterar;
        private Button btn_AlterarUsuario;
        private Button btn_BuscarAlterar;
        private TextBox tbx_MatriculaAlterar;
        private Label label2;
        private Label label1;
    }
}