namespace MercadoZe.VIew.TelasFuncionario
{
    partial class CadastroFuncionario
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
            btn_CadastrarFuncionario = new Button();
            tbx_EmailFuncionario = new TextBox();
            tbx_NomeFuncionario = new TextBox();
            label5 = new Label();
            mtbx_FoneFuncionario = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 42);
            label1.Name = "label1";
            label1.Size = new Size(395, 29);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 163);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // btn_CadastrarFuncionario
            // 
            btn_CadastrarFuncionario.BackColor = SystemColors.ButtonHighlight;
            btn_CadastrarFuncionario.Location = new Point(329, 254);
            btn_CadastrarFuncionario.Name = "btn_CadastrarFuncionario";
            btn_CadastrarFuncionario.Size = new Size(87, 25);
            btn_CadastrarFuncionario.TabIndex = 5;
            btn_CadastrarFuncionario.Text = "Cadastrar";
            btn_CadastrarFuncionario.UseVisualStyleBackColor = false;
            btn_CadastrarFuncionario.Click += btn_CadastrarFuncionario_Click;
            // 
            // tbx_EmailFuncionario
            // 
            tbx_EmailFuncionario.Location = new Point(21, 187);
            tbx_EmailFuncionario.Name = "tbx_EmailFuncionario";
            tbx_EmailFuncionario.Size = new Size(304, 23);
            tbx_EmailFuncionario.TabIndex = 7;
            // 
            // tbx_NomeFuncionario
            // 
            tbx_NomeFuncionario.Location = new Point(21, 122);
            tbx_NomeFuncionario.Name = "tbx_NomeFuncionario";
            tbx_NomeFuncionario.Size = new Size(304, 23);
            tbx_NomeFuncionario.TabIndex = 8;
            tbx_NomeFuncionario.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 230);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 3;
            label5.Text = "Fone:";
            // 
            // mtbx_FoneFuncionario
            // 
            mtbx_FoneFuncionario.Location = new Point(21, 254);
            mtbx_FoneFuncionario.Mask = "(99) 0000-0000";
            mtbx_FoneFuncionario.Name = "mtbx_FoneFuncionario";
            mtbx_FoneFuncionario.Size = new Size(148, 23);
            mtbx_FoneFuncionario.TabIndex = 9;
            // 
            // CadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(448, 303);
            Controls.Add(mtbx_FoneFuncionario);
            Controls.Add(tbx_NomeFuncionario);
            Controls.Add(tbx_EmailFuncionario);
            Controls.Add(btn_CadastrarFuncionario);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroFuncionario";
            Text = "CadastroFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_CadastrarFuncionario;
        private TextBox tbx_EmailFuncionario;
        private TextBox tbx_NomeFuncionario;
        private Label label5;
        private MaskedTextBox mtbx_FoneFuncionario;
    }
}