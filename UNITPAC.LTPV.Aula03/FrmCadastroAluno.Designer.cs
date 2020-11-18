namespace UNITPAC.LTPV.Aula03
{
    partial class FrmCadastroAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GridAlunos = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSobreNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObservaçoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtObservacoes = new System.Windows.Forms.TextBox();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtAtualizar = new System.Windows.Forms.Button();
            this.BtExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(133, 93);
            this.TxtId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(105, 26);
            this.TxtId.TabIndex = 1;
            this.TxtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(133, 123);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNome.MaxLength = 150;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(181, 26);
            this.TxtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // TxtSobrenome
            // 
            this.TxtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSobrenome.Location = new System.Drawing.Point(133, 154);
            this.TxtSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSobrenome.MaxLength = 150;
            this.TxtSobrenome.Name = "TxtSobrenome";
            this.TxtSobrenome.Size = new System.Drawing.Size(181, 26);
            this.TxtSobrenome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sobrenome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matricula:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // GridAlunos
            // 
            this.GridAlunos.AllowUserToAddRows = false;
            this.GridAlunos.AllowUserToDeleteRows = false;
            this.GridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnSobreNome,
            this.ColumnDataNascimento,
            this.ColumnMatricula,
            this.ColumnObservaçoes});
            this.GridAlunos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridAlunos.Location = new System.Drawing.Point(0, 308);
            this.GridAlunos.Margin = new System.Windows.Forms.Padding(2);
            this.GridAlunos.MultiSelect = false;
            this.GridAlunos.Name = "GridAlunos";
            this.GridAlunos.ReadOnly = true;
            this.GridAlunos.RowHeadersWidth = 51;
            this.GridAlunos.RowTemplate.Height = 24;
            this.GridAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAlunos.Size = new System.Drawing.Size(678, 145);
            this.GridAlunos.TabIndex = 13;
            this.GridAlunos.DoubleClick += new System.EventHandler(this.GridAlunos_DoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 40;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "Nome";
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 80;
            // 
            // ColumnSobreNome
            // 
            this.ColumnSobreNome.DataPropertyName = "SobreNome";
            this.ColumnSobreNome.HeaderText = "SobreNome";
            this.ColumnSobreNome.Name = "ColumnSobreNome";
            this.ColumnSobreNome.ReadOnly = true;
            // 
            // ColumnDataNascimento
            // 
            this.ColumnDataNascimento.DataPropertyName = "DataNascimento";
            this.ColumnDataNascimento.HeaderText = "DataNascimento";
            this.ColumnDataNascimento.Name = "ColumnDataNascimento";
            this.ColumnDataNascimento.ReadOnly = true;
            this.ColumnDataNascimento.Width = 120;
            // 
            // ColumnMatricula
            // 
            this.ColumnMatricula.DataPropertyName = "Matricula";
            this.ColumnMatricula.HeaderText = "Matricula";
            this.ColumnMatricula.Name = "ColumnMatricula";
            this.ColumnMatricula.ReadOnly = true;
            this.ColumnMatricula.Width = 80;
            // 
            // ColumnObservaçoes
            // 
            this.ColumnObservaçoes.DataPropertyName = "Observacoes";
            this.ColumnObservaçoes.HeaderText = "Observações";
            this.ColumnObservaçoes.Name = "ColumnObservaçoes";
            this.ColumnObservaçoes.ReadOnly = true;
            this.ColumnObservaçoes.Width = 200;
            // 
            // TxtNascimento
            // 
            this.TxtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNascimento.Location = new System.Drawing.Point(441, 121);
            this.TxtNascimento.Mask = "00/00/0000";
            this.TxtNascimento.Name = "TxtNascimento";
            this.TxtNascimento.Size = new System.Drawing.Size(181, 29);
            this.TxtNascimento.TabIndex = 5;
            this.TxtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatricula.Location = new System.Drawing.Point(441, 156);
            this.TxtMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMatricula.MaxLength = 5;
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(181, 26);
            this.TxtMatricula.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Observações:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtObservacoes
            // 
            this.TxtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservacoes.Location = new System.Drawing.Point(133, 189);
            this.TxtObservacoes.Multiline = true;
            this.TxtObservacoes.Name = "TxtObservacoes";
            this.TxtObservacoes.Size = new System.Drawing.Size(489, 49);
            this.TxtObservacoes.TabIndex = 11;
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdicionar.Location = new System.Drawing.Point(173, 253);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(127, 36);
            this.BtAdicionar.TabIndex = 12;
            this.BtAdicionar.Text = "Adicionar";
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "CADASTRO DE NOVO PROFESSOR!\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(659, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Por favor informe os seguintes dados de acordo com os registro originais e confir" +
    "a antes de realizar a adiçao!";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // BtAtualizar
            // 
            this.BtAtualizar.Enabled = false;
            this.BtAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAtualizar.Location = new System.Drawing.Point(316, 253);
            this.BtAtualizar.Name = "BtAtualizar";
            this.BtAtualizar.Size = new System.Drawing.Size(127, 36);
            this.BtAtualizar.TabIndex = 16;
            this.BtAtualizar.Text = "Atualizar";
            this.BtAtualizar.UseVisualStyleBackColor = true;
            this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click);
            // 
            // BtExcluir
            // 
            this.BtExcluir.Enabled = false;
            this.BtExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExcluir.Location = new System.Drawing.Point(457, 253);
            this.BtExcluir.Name = "BtExcluir";
            this.BtExcluir.Size = new System.Drawing.Size(127, 36);
            this.BtExcluir.TabIndex = 17;
            this.BtExcluir.Text = "Excluir";
            this.BtExcluir.UseVisualStyleBackColor = true;
            this.BtExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // FrmCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 453);
            this.Controls.Add(this.BtExcluir);
            this.Controls.Add(this.BtAtualizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.TxtObservacoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNascimento);
            this.Controls.Add(this.GridAlunos);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastroAluno";
            this.Text = "Cadastro de Professor";
            this.Load += new System.EventHandler(this.FrmCadastroAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GridAlunos;
        private System.Windows.Forms.MaskedTextBox TxtNascimento;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtObservacoes;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSobreNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObservaçoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtAtualizar;
        private System.Windows.Forms.Button BtExcluir;
    }
}