namespace UI.Forms
{
    partial class NotaFiscalFRN
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
            this.txtPesquisaNota = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.cboRazaoSocial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNumeroDaNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grupoBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.txtIdItem = new System.Windows.Forms.TextBox();
            this.cboIdNotaFiscal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboItemProduto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvarItem = new System.Windows.Forms.Button();
            this.txtValorItem = new System.Windows.Forms.TextBox();
            this.dgvItemDaNota = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cboQuantidade = new System.Windows.Forms.ComboBox();
            this.TxtValorItemDaNota = new System.Windows.Forms.Label();
            this.txtQuantiade = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grupoBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDaNota)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaNota
            // 
            this.txtPesquisaNota.Location = new System.Drawing.Point(85, 19);
            this.txtPesquisaNota.Name = "txtPesquisaNota";
            this.txtPesquisaNota.Size = new System.Drawing.Size(129, 25);
            this.txtPesquisaNota.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPesquisaNota);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(212, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisar.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(234, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 26);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Número :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboProduto);
            this.groupBox2.Controls.Add(this.cboRazaoSocial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.txtNumeroDaNota);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(67, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 309);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(413, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(297, 253);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 29);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.label5.Location = new System.Drawing.Point(283, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Produto:";
            // 
            // cboProduto
            // 
            this.cboProduto.DisplayMember = "Nome";
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(287, 79);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(247, 27);
            this.cboProduto.TabIndex = 3;
            this.cboProduto.ValueMember = "Nome";
            // 
            // cboRazaoSocial
            // 
            this.cboRazaoSocial.DisplayMember = "Nome";
            this.cboRazaoSocial.FormattingEnabled = true;
            this.cboRazaoSocial.Location = new System.Drawing.Point(287, 155);
            this.cboRazaoSocial.Name = "cboRazaoSocial";
            this.cboRazaoSocial.Size = new System.Drawing.Size(247, 27);
            this.cboRazaoSocial.TabIndex = 5;
            this.cboRazaoSocial.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.label6.Location = new System.Drawing.Point(55, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID :";
            this.label6.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(95, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 25);
            this.txtId.TabIndex = 10;
            this.txtId.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(167, 253);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 29);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(20, 159);
            this.txtValor.MaxLength = 8;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 25);
            this.txtValor.TabIndex = 4;
            // 
            // txtNumeroDaNota
            // 
            this.txtNumeroDaNota.Location = new System.Drawing.Point(20, 79);
            this.txtNumeroDaNota.Name = "txtNumeroDaNota";
            this.txtNumeroDaNota.Size = new System.Drawing.Size(100, 25);
            this.txtNumeroDaNota.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.label2.Location = new System.Drawing.Point(283, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razão Sócial : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número :";
            // 
            // grupoBox3
            // 
            this.grupoBox3.Controls.Add(this.btnCancelar);
            this.grupoBox3.Controls.Add(this.btnEditarItem);
            this.grupoBox3.Controls.Add(this.txtIdItem);
            this.grupoBox3.Controls.Add(this.cboIdNotaFiscal);
            this.grupoBox3.Controls.Add(this.label8);
            this.grupoBox3.Controls.Add(this.cboItemProduto);
            this.grupoBox3.Controls.Add(this.label7);
            this.grupoBox3.Controls.Add(this.btnSalvarItem);
            this.grupoBox3.Controls.Add(this.txtValorItem);
            this.grupoBox3.Controls.Add(this.dgvItemDaNota);
            this.grupoBox3.Controls.Add(this.cboQuantidade);
            this.grupoBox3.Controls.Add(this.TxtValorItemDaNota);
            this.grupoBox3.Controls.Add(this.txtQuantiade);
            this.grupoBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.grupoBox3.Location = new System.Drawing.Point(67, 382);
            this.grupoBox3.Name = "grupoBox3";
            this.grupoBox3.Size = new System.Drawing.Size(891, 301);
            this.grupoBox3.TabIndex = 4;
            this.grupoBox3.TabStop = false;
            this.grupoBox3.Text = "Item da Nota";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(742, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 29);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditarItem.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarItem.Location = new System.Drawing.Point(742, 177);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(102, 29);
            this.btnEditarItem.TabIndex = 84;
            this.btnEditarItem.Text = "Editar";
            this.btnEditarItem.UseVisualStyleBackColor = false;
            this.btnEditarItem.Click += new System.EventHandler(this.BtnEditarItem_Click_1);
            // 
            // txtIdItem
            // 
            this.txtIdItem.Location = new System.Drawing.Point(314, 24);
            this.txtIdItem.MaxLength = 8;
            this.txtIdItem.Name = "txtIdItem";
            this.txtIdItem.Size = new System.Drawing.Size(36, 25);
            this.txtIdItem.TabIndex = 38;
            // 
            // cboIdNotaFiscal
            // 
            this.cboIdNotaFiscal.DisplayMember = "ID";
            this.cboIdNotaFiscal.FormattingEnabled = true;
            this.cboIdNotaFiscal.Location = new System.Drawing.Point(19, 68);
            this.cboIdNotaFiscal.Name = "cboIdNotaFiscal";
            this.cboIdNotaFiscal.Size = new System.Drawing.Size(121, 27);
            this.cboIdNotaFiscal.TabIndex = 9;
            this.cboIdNotaFiscal.ValueMember = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.label8.Location = new System.Drawing.Point(16, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Id Nota Fiscal :";
            // 
            // cboItemProduto
            // 
            this.cboItemProduto.DisplayMember = "Nome";
            this.cboItemProduto.FormattingEnabled = true;
            this.cboItemProduto.Location = new System.Drawing.Point(167, 64);
            this.cboItemProduto.Name = "cboItemProduto";
            this.cboItemProduto.Size = new System.Drawing.Size(247, 27);
            this.cboItemProduto.TabIndex = 10;
            this.cboItemProduto.ValueMember = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.label7.Location = new System.Drawing.Point(163, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Produto :";
            // 
            // btnSalvarItem
            // 
            this.btnSalvarItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarItem.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvarItem.Location = new System.Drawing.Point(742, 120);
            this.btnSalvarItem.Name = "btnSalvarItem";
            this.btnSalvarItem.Size = new System.Drawing.Size(102, 30);
            this.btnSalvarItem.TabIndex = 32;
            this.btnSalvarItem.Text = "Salvar";
            this.btnSalvarItem.UseVisualStyleBackColor = false;
            this.btnSalvarItem.Click += new System.EventHandler(this.btnSalvarItem_Click);
            // 
            // txtValorItem
            // 
            this.txtValorItem.Location = new System.Drawing.Point(616, 64);
            this.txtValorItem.MaxLength = 8;
            this.txtValorItem.Name = "txtValorItem";
            this.txtValorItem.Size = new System.Drawing.Size(100, 25);
            this.txtValorItem.TabIndex = 12;
            // 
            // dgvItemDaNota
            // 
            this.dgvItemDaNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemDaNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdNotaFiscal,
            this.Produto,
            this.Quantidade,
            this.Valor,
            this.Editar,
            this.Excluir});
            this.dgvItemDaNota.Location = new System.Drawing.Point(20, 110);
            this.dgvItemDaNota.Name = "dgvItemDaNota";
            this.dgvItemDaNota.Size = new System.Drawing.Size(696, 193);
            this.dgvItemDaNota.TabIndex = 13;
            this.dgvItemDaNota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgItemDaNota_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // IdNotaFiscal
            // 
            this.IdNotaFiscal.DataPropertyName = "IdNotaFiscal";
            this.IdNotaFiscal.HeaderText = "Id Nota Fiscal";
            this.IdNotaFiscal.Name = "IdNotaFiscal";
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "IdProduto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Width = 75;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.Width = 75;
            // 
            // cboQuantidade
            // 
            this.cboQuantidade.DisplayMember = "Quantidade";
            this.cboQuantidade.FormattingEnabled = true;
            this.cboQuantidade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cboQuantidade.Location = new System.Drawing.Point(450, 62);
            this.cboQuantidade.Name = "cboQuantidade";
            this.cboQuantidade.Size = new System.Drawing.Size(121, 27);
            this.cboQuantidade.TabIndex = 11;
            this.cboQuantidade.ValueMember = "Quantidade";
            // 
            // TxtValorItemDaNota
            // 
            this.TxtValorItemDaNota.AutoSize = true;
            this.TxtValorItemDaNota.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.TxtValorItemDaNota.Location = new System.Drawing.Point(612, 37);
            this.TxtValorItemDaNota.Name = "TxtValorItemDaNota";
            this.TxtValorItemDaNota.Size = new System.Drawing.Size(108, 20);
            this.TxtValorItemDaNota.TabIndex = 3;
            this.TxtValorItemDaNota.Text = "Valor do Item :";
            // 
            // txtQuantiade
            // 
            this.txtQuantiade.AutoSize = true;
            this.txtQuantiade.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.txtQuantiade.Location = new System.Drawing.Point(446, 39);
            this.txtQuantiade.Name = "txtQuantiade";
            this.txtQuantiade.Size = new System.Drawing.Size(95, 20);
            this.txtQuantiade.TabIndex = 1;
            this.txtQuantiade.Text = "Quantidade :";
            // 
            // NotaFiscalFRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 709);
            this.Controls.Add(this.grupoBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NotaFiscalFRN";
            this.Text = "NotaFiscalFRN";
            this.Load += new System.EventHandler(this.NotaFiscalFRN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grupoBox3.ResumeLayout(false);
            this.grupoBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDaNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtPesquisaNota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNumeroDaNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grupoBox3;
        private System.Windows.Forms.Label TxtValorItemDaNota;
        private System.Windows.Forms.Label txtQuantiade;
        private System.Windows.Forms.ComboBox cboQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItemDaNota;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtValorItem;
        private System.Windows.Forms.Button btnSalvarItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.ComboBox cboRazaoSocial;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboItemProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboIdNotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNotaFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.TextBox txtIdItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnCancelar;
    }
}