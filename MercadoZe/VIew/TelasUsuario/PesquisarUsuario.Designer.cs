namespace MercadoZe.VIew.TelasUsuario
{
    partial class PesquisarUsuario
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            tbx_Email = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            cbx_TipoPesquisa = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            tbx_NomePessquisar = new TextBox();
            btn_BuscarPesquisar = new Button();
            tbx_MatriculaPesquisa = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            cbx_TipoUsuario = new ComboBox();
            dataGridViewUsuarios = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Matricula = new DataGridViewTextBoxColumn();
            Função = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 55);
            label1.Name = "label1";
            label1.Size = new Size(296, 37);
            label1.TabIndex = 0;
            label1.Text = "PESQUISAR USUARIOS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 157);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(619, 376);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btn_BuscarPesquisar);
            tabPage1.Controls.Add(tbx_MatriculaPesquisa);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(611, 348);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Buscar por Código";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_Email);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbx_TipoPesquisa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbx_NomePessquisar);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 274);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMAÇÕES";
            // 
            // tbx_Email
            // 
            tbx_Email.Location = new Point(85, 98);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(202, 25);
            tbx_Email.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(146, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 25);
            dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(35, 172);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 10;
            label6.Text = "Último Acesso";
            // 
            // cbx_TipoPesquisa
            // 
            cbx_TipoPesquisa.FormattingEnabled = true;
            cbx_TipoPesquisa.Location = new Point(374, 79);
            cbx_TipoPesquisa.Name = "cbx_TipoPesquisa";
            cbx_TipoPesquisa.Size = new Size(121, 25);
            cbx_TipoPesquisa.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 51);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "NOME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 103);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "EMAIL:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(409, 56);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 2;
            label7.Text = "TIPO";
            // 
            // tbx_NomePessquisar
            // 
            tbx_NomePessquisar.Location = new Point(85, 50);
            tbx_NomePessquisar.Name = "tbx_NomePessquisar";
            tbx_NomePessquisar.Size = new Size(202, 25);
            tbx_NomePessquisar.TabIndex = 8;
            // 
            // btn_BuscarPesquisar
            // 
            btn_BuscarPesquisar.BackColor = SystemColors.MenuBar;
            btn_BuscarPesquisar.Location = new Point(486, 17);
            btn_BuscarPesquisar.Name = "btn_BuscarPesquisar";
            btn_BuscarPesquisar.Size = new Size(84, 23);
            btn_BuscarPesquisar.TabIndex = 20;
            btn_BuscarPesquisar.Text = "BUSCAR";
            btn_BuscarPesquisar.UseVisualStyleBackColor = false;
            btn_BuscarPesquisar.Click += btn_BuscarPesquisar_Click;
            // 
            // tbx_MatriculaPesquisa
            // 
            tbx_MatriculaPesquisa.Location = new Point(256, 17);
            tbx_MatriculaPesquisa.Name = "tbx_MatriculaPesquisa";
            tbx_MatriculaPesquisa.Size = new Size(199, 23);
            tbx_MatriculaPesquisa.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 19);
            label3.Name = "label3";
            label3.Size = new Size(197, 19);
            label3.TabIndex = 18;
            label3.Text = "Digite a Matricula do Usuário:";
            label3.Click += label3_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbx_TipoUsuario);
            tabPage2.Controls.Add(dataGridViewUsuarios);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(611, 348);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar por Usuário";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbx_TipoUsuario
            // 
            cbx_TipoUsuario.FormattingEnabled = true;
            cbx_TipoUsuario.Items.AddRange(new object[] { "Gerente", "Atendente", "Caixa" });
            cbx_TipoUsuario.Location = new Point(242, 22);
            cbx_TipoUsuario.Name = "cbx_TipoUsuario";
            cbx_TipoUsuario.Size = new Size(121, 23);
            cbx_TipoUsuario.TabIndex = 19;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { Codigo, Matricula, Função });
            dataGridViewUsuarios.Location = new Point(25, 149);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.RowTemplate.Height = 25;
            dataGridViewUsuarios.Size = new Size(558, 175);
            dataGridViewUsuarios.TabIndex = 18;
            dataGridViewUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Matricula
            // 
            Matricula.HeaderText = "Matricula";
            Matricula.Name = "Matricula";
            // 
            // Função
            // 
            Função.HeaderText = "Função";
            Função.Name = "Função";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Location = new Point(490, 21);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 17;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(210, 20);
            label2.TabIndex = 15;
            label2.Text = "Digite a Matricula do Usuário";
            label2.Click += label2_Click;
            // 
            // PesquisarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(643, 561);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "PesquisarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gerenciamento de Vendas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Button button1;
        private Button btn_BuscarPesquisar;
        private TextBox tbx_MatriculaPesquisa;
        private Label label3;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox cbx_TipoPesquisa;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox tbx_NomePessquisar;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridViewUsuarios;
        private TextBox tbx_Email;
        private ComboBox cbx_TipoUsuario;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Função;
    }
}