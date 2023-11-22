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
            tabPage2 = new TabPage();
            tbx_TipoUsuario = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            tbx_CodigoCliente = new TextBox();
            label7 = new Label();
            tbx_CodigoFuncionario = new TextBox();
            btn_CadastrarUsuario = new Button();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ma = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            nom = new DataGridViewTextBoxColumn();
            tip = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(158, 100);
            label1.Name = "label1";
            label1.Size = new Size(296, 37);
            label1.TabIndex = 0;
            label1.Text = "PESQUISAR USUARIOS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 175);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(619, 358);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(611, 330);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Buscar por Código";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(tbx_TipoUsuario);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(611, 330);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar por Usuário";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbx_TipoUsuario
            // 
            tbx_TipoUsuario.Location = new Point(228, 21);
            tbx_TipoUsuario.Name = "tbx_TipoUsuario";
            tbx_TipoUsuario.Size = new Size(210, 23);
            tbx_TipoUsuario.TabIndex = 16;
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
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.Location = new Point(490, 21);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 17;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuBar;
            button2.Location = new Point(486, 17);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 20;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 19;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_CodigoCliente);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbx_CodigoFuncionario);
            groupBox1.Controls.Add(btn_CadastrarUsuario);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(26, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 274);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMAÇÕES";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(374, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 9;
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
            // tbx_CodigoCliente
            // 
            tbx_CodigoCliente.Location = new Point(85, 100);
            tbx_CodigoCliente.Name = "tbx_CodigoCliente";
            tbx_CodigoCliente.Size = new Size(202, 25);
            tbx_CodigoCliente.TabIndex = 7;
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
            // tbx_CodigoFuncionario
            // 
            tbx_CodigoFuncionario.Location = new Point(85, 50);
            tbx_CodigoFuncionario.Name = "tbx_CodigoFuncionario";
            tbx_CodigoFuncionario.Size = new Size(202, 25);
            tbx_CodigoFuncionario.TabIndex = 8;
            // 
            // btn_CadastrarUsuario
            // 
            btn_CadastrarUsuario.BackColor = SystemColors.MenuBar;
            btn_CadastrarUsuario.Location = new Point(230, 234);
            btn_CadastrarUsuario.Name = "btn_CadastrarUsuario";
            btn_CadastrarUsuario.Size = new Size(91, 34);
            btn_CadastrarUsuario.TabIndex = 5;
            btn_CadastrarUsuario.Text = "CADASTRAR";
            btn_CadastrarUsuario.UseVisualStyleBackColor = false;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(146, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 25);
            dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ma, email, nom, tip });
            dataGridView1.Location = new Point(25, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(558, 175);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ma
            // 
            ma.HeaderText = "Matricula";
            ma.Name = "ma";
            // 
            // email
            // 
            email.HeaderText = "E-mail";
            email.Name = "email";
            // 
            // nom
            // 
            nom.HeaderText = "Nome";
            nom.Name = "nom";
            // 
            // tip
            // 
            tip.HeaderText = "Tipo";
            tip.Name = "tip";
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox tbx_TipoUsuario;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label3;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private TextBox tbx_CodigoCliente;
        private Label label7;
        private TextBox tbx_CodigoFuncionario;
        private Button btn_CadastrarUsuario;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ma;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn tip;
    }
}