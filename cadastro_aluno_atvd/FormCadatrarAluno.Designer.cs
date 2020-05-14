namespace cadastro_aluno_atvd
{
    partial class FormCadatrarAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnCancelar;
            System.Windows.Forms.Button btnLimpar;
            this.tabCadastro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConceito = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.btnRemover = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.numero_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceito_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto_aluno = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFechar = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            btnCancelar = new System.Windows.Forms.Button();
            btnLimpar = new System.Windows.Forms.Button();
            this.tabCadastro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = global::cadastro_aluno_atvd.Properties.Resources.delete_40623;
            btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelar.Location = new System.Drawing.Point(505, 287);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(114, 45);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            btnLimpar.Image = global::cadastro_aluno_atvd.Properties.Resources.delete_40623;
            btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLimpar.Location = new System.Drawing.Point(534, 304);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new System.Drawing.Size(114, 45);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "&Limpar";
            btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.tabPage1);
            this.tabCadastro.Controls.Add(this.tabConsulta);
            this.tabCadastro.Location = new System.Drawing.Point(12, 12);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.SelectedIndex = 0;
            this.tabCadastro.Size = new System.Drawing.Size(672, 396);
            this.tabCadastro.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar Alunos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtConceito);
            this.panel1.Controls.Add(this.txtMedia);
            this.panel1.Controls.Add(btnCancelar);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.btnFoto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNota2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNota1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 358);
            this.panel1.TabIndex = 12;
            // 
            // txtConceito
            // 
            this.txtConceito.AutoSize = true;
            this.txtConceito.Location = new System.Drawing.Point(85, 211);
            this.txtConceito.Name = "txtConceito";
            this.txtConceito.Size = new System.Drawing.Size(0, 13);
            this.txtConceito.TabIndex = 17;
            // 
            // txtMedia
            // 
            this.txtMedia.AutoSize = true;
            this.txtMedia.Location = new System.Drawing.Point(85, 174);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(0, 13);
            this.txtMedia.TabIndex = 16;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::cadastro_aluno_atvd.Properties.Resources.add_icon_icons_com_74429;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.Location = new System.Drawing.Point(385, 287);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(114, 45);
            this.btnIncluir.TabIndex = 14;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::cadastro_aluno_atvd.Properties.Resources.check_ok_accept_apply_1582__1_;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(265, 287);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 45);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Image = global::cadastro_aluno_atvd.Properties.Resources.iPhoto_photo_picture_camera_2661;
            this.btnFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoto.Location = new System.Drawing.Point(464, 195);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(155, 45);
            this.btnFoto.TabIndex = 12;
            this.btnFoto.Text = "F&oto";
            this.btnFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Conceito:";
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(464, 22);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(155, 165);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Média:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "2ª Nota:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(88, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "1ª Nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(88, 134);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(88, 96);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 3;
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota1_KeyPress);
            // 
            // tabConsulta
            // 
            this.tabConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabConsulta.Controls.Add(btnLimpar);
            this.tabConsulta.Controls.Add(this.btnRemover);
            this.tabConsulta.Controls.Add(this.grid);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(664, 370);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consultar dados do Aluno";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::cadastro_aluno_atvd.Properties.Resources.Delete_27010;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.Location = new System.Drawing.Point(414, 304);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(114, 45);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_aluno,
            this.nome_aluno,
            this.nota1,
            this.nota2,
            this.media_aluno,
            this.conceito_aluno,
            this.foto_aluno});
            this.grid.Location = new System.Drawing.Point(6, 6);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(650, 277);
            this.grid.TabIndex = 0;
            // 
            // numero_aluno
            // 
            this.numero_aluno.HeaderText = "Número";
            this.numero_aluno.Name = "numero_aluno";
            this.numero_aluno.Width = 69;
            // 
            // nome_aluno
            // 
            this.nome_aluno.HeaderText = "Nome";
            this.nome_aluno.Name = "nome_aluno";
            this.nome_aluno.Width = 60;
            // 
            // nota1
            // 
            this.nota1.HeaderText = "1ªNota";
            this.nota1.Name = "nota1";
            this.nota1.Width = 65;
            // 
            // nota2
            // 
            this.nota2.HeaderText = "2ªNota";
            this.nota2.Name = "nota2";
            this.nota2.Width = 65;
            // 
            // media_aluno
            // 
            this.media_aluno.HeaderText = "Média";
            this.media_aluno.Name = "media_aluno";
            this.media_aluno.Width = 61;
            // 
            // conceito_aluno
            // 
            this.conceito_aluno.HeaderText = "Conceito";
            this.conceito_aluno.Name = "conceito_aluno";
            this.conceito_aluno.Width = 74;
            // 
            // foto_aluno
            // 
            this.foto_aluno.HeaderText = "Foto";
            this.foto_aluno.Name = "foto_aluno";
            this.foto_aluno.Width = 34;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::cadastro_aluno_atvd.Properties.Resources.logout256_24927;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.Location = new System.Drawing.Point(293, 427);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(114, 45);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // FormCadatrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 484);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.tabCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCadatrarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desenvolvimento de Sistemas - TabControl";
            this.tabCadastro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCadastro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn media_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceito_aluno;
        private System.Windows.Forms.DataGridViewImageColumn foto_aluno;
        private System.Windows.Forms.Label txtConceito;
        private System.Windows.Forms.Label txtMedia;
    }
}

