namespace Menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            btn_Editar = new Button();
            btn_CadastrarFrete = new Button();
            btn_Motorista = new Button();
            btn_Documentos = new Button();
            btn_Veiculo = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            tbn_ExRelatorio = new Button();
            btn_Filtrar = new Button();
            lbl_IdFrete = new Label();
            lbl_FreteNumero = new Label();
            llb_ChaveCTe = new Label();
            lbl_NumeroCTe = new Label();
            lbl_NumeroNFe = new Label();
            lbl_NomeMotorista = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12 , 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1450 , 422);
            dataGridView1.TabIndex = 0;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(1332 , 591);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(130 , 29);
            btn_Editar.TabIndex = 1;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_CadastrarFrete
            // 
            btn_CadastrarFrete.Location = new Point(1196 , 591);
            btn_CadastrarFrete.Name = "btn_CadastrarFrete";
            btn_CadastrarFrete.Size = new Size(130 , 29);
            btn_CadastrarFrete.TabIndex = 2;
            btn_CadastrarFrete.Text = "Novo Frete";
            btn_CadastrarFrete.UseVisualStyleBackColor = true;
            // 
            // btn_Motorista
            // 
            btn_Motorista.Location = new Point(12 , 591);
            btn_Motorista.Name = "btn_Motorista";
            btn_Motorista.Size = new Size(130 , 29);
            btn_Motorista.TabIndex = 3;
            btn_Motorista.Text = "Motorista";
            btn_Motorista.UseVisualStyleBackColor = true;
            // 
            // btn_Documentos
            // 
            btn_Documentos.Location = new Point(148 , 591);
            btn_Documentos.Name = "btn_Documentos";
            btn_Documentos.Size = new Size(130 , 29);
            btn_Documentos.TabIndex = 4;
            btn_Documentos.Text = "Documentos";
            btn_Documentos.UseVisualStyleBackColor = true;
            // 
            // btn_Veiculo
            // 
            btn_Veiculo.Location = new Point(284 , 591);
            btn_Veiculo.Name = "btn_Veiculo";
            btn_Veiculo.Size = new Size(130 , 29);
            btn_Veiculo.TabIndex = 5;
            btn_Veiculo.Text = "Veiculo";
            btn_Veiculo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43 , 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(37 , 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145 , 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100 , 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143 , 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(371 , 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(583 , 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(63 , 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(583 , 41);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(98 , 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(583 , 70);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221 , 23);
            textBox6.TabIndex = 11;
            // 
            // tbn_ExRelatorio
            // 
            tbn_ExRelatorio.Location = new Point(1332 , 12);
            tbn_ExRelatorio.Name = "tbn_ExRelatorio";
            tbn_ExRelatorio.Size = new Size(130 , 29);
            tbn_ExRelatorio.TabIndex = 12;
            tbn_ExRelatorio.Text = "Relatórios";
            tbn_ExRelatorio.UseVisualStyleBackColor = true;
            // 
            // btn_Filtrar
            // 
            btn_Filtrar.Location = new Point(1196 , 12);
            btn_Filtrar.Name = "btn_Filtrar";
            btn_Filtrar.Size = new Size(130 , 29);
            btn_Filtrar.TabIndex = 13;
            btn_Filtrar.Text = "Filtrar";
            btn_Filtrar.UseVisualStyleBackColor = true;
            // 
            // lbl_IdFrete
            // 
            lbl_IdFrete.AutoSize = true;
            lbl_IdFrete.Location = new Point(13 , 15);
            lbl_IdFrete.Name = "lbl_IdFrete";
            lbl_IdFrete.Size = new Size(27 , 15);
            lbl_IdFrete.TabIndex = 14;
            lbl_IdFrete.Text = "N° :";
            // 
            // lbl_FreteNumero
            // 
            lbl_FreteNumero.AutoSize = true;
            lbl_FreteNumero.Location = new Point(86 , 15);
            lbl_FreteNumero.Name = "lbl_FreteNumero";
            lbl_FreteNumero.Size = new Size(56 , 15);
            lbl_FreteNumero.TabIndex = 15;
            lbl_FreteNumero.Text = "N° Frete :";
            // 
            // llb_ChaveCTe
            // 
            llb_ChaveCTe.AutoSize = true;
            llb_ChaveCTe.Location = new Point(12 , 44);
            llb_ChaveCTe.Name = "llb_ChaveCTe";
            llb_ChaveCTe.Size = new Size(131 , 15);
            llb_ChaveCTe.TabIndex = 16;
            llb_ChaveCTe.Text = "Chave de Acesso CT-e :";
            // 
            // lbl_NumeroCTe
            // 
            lbl_NumeroCTe.AutoSize = true;
            lbl_NumeroCTe.Location = new Point(522 , 15);
            lbl_NumeroCTe.Name = "lbl_NumeroCTe";
            lbl_NumeroCTe.Size = new Size(56 , 15);
            lbl_NumeroCTe.TabIndex = 17;
            lbl_NumeroCTe.Text = "N° CT-e :";
            // 
            // lbl_NumeroNFe
            // 
            lbl_NumeroNFe.AutoSize = true;
            lbl_NumeroNFe.Location = new Point(522 , 44);
            lbl_NumeroNFe.Name = "lbl_NumeroNFe";
            lbl_NumeroNFe.Size = new Size(56 , 15);
            lbl_NumeroNFe.TabIndex = 18;
            lbl_NumeroNFe.Text = "N° NF-e :";
            // 
            // lbl_NomeMotorista
            // 
            lbl_NomeMotorista.AutoSize = true;
            lbl_NomeMotorista.Location = new Point(513 , 73);
            lbl_NomeMotorista.Name = "lbl_NomeMotorista";
            lbl_NomeMotorista.Size = new Size(64 , 15);
            lbl_NomeMotorista.TabIndex = 19;
            lbl_NomeMotorista.Text = "Motorista :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F , 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474 , 684);
            Controls.Add(lbl_NomeMotorista);
            Controls.Add(lbl_NumeroNFe);
            Controls.Add(lbl_NumeroCTe);
            Controls.Add(llb_ChaveCTe);
            Controls.Add(lbl_FreteNumero);
            Controls.Add(lbl_IdFrete);
            Controls.Add(btn_Filtrar);
            Controls.Add(tbn_ExRelatorio);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_Veiculo);
            Controls.Add(btn_Documentos);
            Controls.Add(btn_Motorista);
            Controls.Add(btn_CadastrarFrete);
            Controls.Add(btn_Editar);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de frete";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Editar;
        private Button btn_CadastrarFrete;
        private Button btn_Motorista;
        private Button btn_Documentos;
        private Button btn_Veiculo;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button tbn_ExRelatorio;
        private Button btn_Filtrar;
        private Label lbl_IdFrete;
        private Label lbl_FreteNumero;
        private Label llb_ChaveCTe;
        private Label lbl_NumeroCTe;
        private Label lbl_NumeroNFe;
        private Label lbl_NomeMotorista;
    }
}
