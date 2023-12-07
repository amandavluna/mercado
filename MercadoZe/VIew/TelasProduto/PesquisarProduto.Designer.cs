namespace MercadoZe.VIew.TelasProduto
{
    partial class PesquisarProduto
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            tbx_Valor = new TextBox();
            label7 = new Label();
            tbx_Marca = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbx_Nome = new TextBox();
            btn_Buscar = new Button();
            tbx_Matricula = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            dataGridViewUsuarios = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            Codigo = new DataGridViewTextBoxColumn();
            nomeProduto = new DataGridViewTextBoxColumn();
            marcaProduto = new DataGridViewTextBoxColumn();
            valorProduto = new DataGridViewTextBoxColumn();
            tbx_Pesquisa = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(40, 140);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(619, 376);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btn_Buscar);
            tabPage1.Controls.Add(tbx_Matricula);
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
            groupBox1.Controls.Add(tbx_Valor);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbx_Marca);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_Nome);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 274);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "INFORMAÇÕES";
            // 
            // tbx_Valor
            // 
            tbx_Valor.Location = new Point(195, 157);
            tbx_Valor.Name = "tbx_Valor";
            tbx_Valor.Size = new Size(202, 25);
            tbx_Valor.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(130, 157);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 13;
            label7.Text = "VALOR:";
            // 
            // tbx_Marca
            // 
            tbx_Marca.Location = new Point(194, 105);
            tbx_Marca.Name = "tbx_Marca";
            tbx_Marca.Size = new Size(202, 25);
            tbx_Marca.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(194, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 25);
            dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(84, 231);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 10;
            label6.Text = "Último Acesso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(130, 51);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "NOME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(124, 106);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "MARCA:";
            // 
            // tbx_Nome
            // 
            tbx_Nome.Location = new Point(194, 51);
            tbx_Nome.Name = "tbx_Nome";
            tbx_Nome.Size = new Size(202, 25);
            tbx_Nome.TabIndex = 8;
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = SystemColors.MenuBar;
            btn_Buscar.Location = new Point(466, 17);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(84, 23);
            btn_Buscar.TabIndex = 20;
            btn_Buscar.Text = "BUSCAR";
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // tbx_Matricula
            // 
            tbx_Matricula.Location = new Point(238, 17);
            tbx_Matricula.Name = "tbx_Matricula";
            tbx_Matricula.Size = new Size(199, 23);
            tbx_Matricula.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 18);
            label3.Name = "label3";
            label3.Size = new Size(125, 19);
            label3.TabIndex = 18;
            label3.Text = "Digite a Matrícula:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tbx_Pesquisa);
            tabPage2.Controls.Add(dataGridViewUsuarios);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(611, 348);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar por Produto";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { Codigo, nomeProduto, marcaProduto, valorProduto });
            dataGridViewUsuarios.Location = new Point(103, 104);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersVisible = false;
            dataGridViewUsuarios.RowTemplate.Height = 25;
            dataGridViewUsuarios.Size = new Size(420, 225);
            dataGridViewUsuarios.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(489, 40);
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
            label2.Location = new Point(25, 39);
            label2.Name = "label2";
            label2.Size = new Size(195, 20);
            label2.TabIndex = 15;
            label2.Text = "Digite o Nome do Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(204, 47);
            label1.Name = "label1";
            label1.Size = new Size(291, 37);
            label1.TabIndex = 2;
            label1.Text = "PESQUISAR PRODUTO";
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // nomeProduto
            // 
            nomeProduto.HeaderText = "Nome";
            nomeProduto.Name = "nomeProduto";
            // 
            // marcaProduto
            // 
            marcaProduto.HeaderText = "Marca";
            marcaProduto.Name = "marcaProduto";
            // 
            // valorProduto
            // 
            valorProduto.HeaderText = "Valor";
            valorProduto.Name = "valorProduto";
            // 
            // tbx_Pesquisa
            // 
            tbx_Pesquisa.Location = new Point(226, 40);
            tbx_Pesquisa.Name = "tbx_Pesquisa";
            tbx_Pesquisa.Size = new Size(199, 23);
            tbx_Pesquisa.TabIndex = 20;
            // 
            // PesquisarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 520);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "PesquisarProduto";
            Text = "PesquisarProduto";
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

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TextBox tbx_Marca;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox tbx_Nome;
        private Button btn_Buscar;
        private TextBox tbx_Matricula;
        private Label label3;
        private TabPage tabPage2;
        private DataGridView dataGridViewUsuarios;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox tbx_Valor;
        private Label label7;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn nomeProduto;
        private DataGridViewTextBoxColumn marcaProduto;
        private DataGridViewTextBoxColumn valorProduto;
        private TextBox tbx_Pesquisa;
    }
}