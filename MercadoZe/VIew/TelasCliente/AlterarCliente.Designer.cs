namespace MercadoZe.VIew.TelasCliente
{
    partial class AlterarCliente
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
            mtbx_Fone = new MaskedTextBox();
            btn_Buscar = new Button();
            btn_Alterar = new Button();
            tbx_Nome = new TextBox();
            tbx_Email = new TextBox();
            tbx_Matricula = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // mtbx_Fone
            // 
            mtbx_Fone.Location = new Point(152, 292);
            mtbx_Fone.Mask = "(99) 0000-0000";
            mtbx_Fone.Name = "mtbx_Fone";
            mtbx_Fone.Size = new Size(244, 23);
            mtbx_Fone.TabIndex = 35;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(414, 130);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 34;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Alterar
            // 
            btn_Alterar.Location = new Point(204, 346);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(83, 34);
            btn_Alterar.TabIndex = 33;
            btn_Alterar.Text = "Alterar";
            btn_Alterar.UseVisualStyleBackColor = true;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // tbx_Nome
            // 
            tbx_Nome.Location = new Point(152, 202);
            tbx_Nome.Name = "tbx_Nome";
            tbx_Nome.Size = new Size(244, 23);
            tbx_Nome.TabIndex = 32;
            // 
            // tbx_Email
            // 
            tbx_Email.Location = new Point(152, 247);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(244, 23);
            tbx_Email.TabIndex = 31;
            // 
            // tbx_Matricula
            // 
            tbx_Matricula.Location = new Point(204, 132);
            tbx_Matricula.Name = "tbx_Matricula";
            tbx_Matricula.Size = new Size(178, 23);
            tbx_Matricula.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(84, 295);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 29;
            label5.Text = "Celular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(91, 246);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 28;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(91, 201);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 27;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 132);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 26;
            label2.Text = "Matrícula do Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 44);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 25;
            label1.Text = "Alterar Cliente";
            // 
            // AlterarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 392);
            Controls.Add(mtbx_Fone);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Alterar);
            Controls.Add(tbx_Nome);
            Controls.Add(tbx_Email);
            Controls.Add(tbx_Matricula);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlterarCliente";
            Text = "AlterarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbx_Fone;
        private Button btn_Buscar;
        private Button btn_Alterar;
        private TextBox tbx_Nome;
        private TextBox tbx_Email;
        private TextBox tbx_Matricula;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}