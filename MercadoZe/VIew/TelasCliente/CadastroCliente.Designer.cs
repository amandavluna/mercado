namespace MercadoZe.VIew.TelasCliente
{
    partial class CadastroCliente
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
            label4 = new Label();
            tbx_NomeCliente = new TextBox();
            tbx_EmailCliente = new TextBox();
            btn_Cadastrar = new Button();
            mtbx_CelularCliente = new MaskedTextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(312, 29);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de CLiente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 99);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 233);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 3;
            label4.Text = "Celular:";
            // 
            // tbx_NomeCliente
            // 
            tbx_NomeCliente.Location = new Point(25, 123);
            tbx_NomeCliente.Name = "tbx_NomeCliente";
            tbx_NomeCliente.Size = new Size(301, 23);
            tbx_NomeCliente.TabIndex = 4;
            // 
            // tbx_EmailCliente
            // 
            tbx_EmailCliente.Location = new Point(25, 190);
            tbx_EmailCliente.Name = "tbx_EmailCliente";
            tbx_EmailCliente.Size = new Size(301, 23);
            tbx_EmailCliente.TabIndex = 5;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = SystemColors.ButtonHighlight;
            btn_Cadastrar.ForeColor = SystemColors.ControlText;
            btn_Cadastrar.Location = new Point(305, 257);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(91, 28);
            btn_Cadastrar.TabIndex = 7;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // mtbx_CelularCliente
            // 
            mtbx_CelularCliente.Location = new Point(25, 257);
            mtbx_CelularCliente.Mask = "(99) 0000-0000";
            mtbx_CelularCliente.Name = "mtbx_CelularCliente";
            mtbx_CelularCliente.Size = new Size(124, 23);
            mtbx_CelularCliente.TabIndex = 8;
            mtbx_CelularCliente.TextMaskFormat = MaskFormat.IncludePrompt;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 166);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 2;
            label5.Text = "Email:";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(420, 311);
            Controls.Add(mtbx_CelularCliente);
            Controls.Add(btn_Cadastrar);
            Controls.Add(tbx_EmailCliente);
            Controls.Add(tbx_NomeCliente);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            Load += CadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox tbx_NomeCliente;
        private TextBox tbx_EmailCliente;
        private Button btn_Cadastrar;
        private MaskedTextBox mtbx_CelularCliente;
        private Label label5;
    }
}