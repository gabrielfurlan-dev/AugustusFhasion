namespace AugustusFahsion.View
{
    partial class FrmProdutoCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutoCadastrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemoverImagem = new System.Windows.Forms.Button();
            this.BtnAdicionarImagem = new System.Windows.Forms.Button();
            this.lblInsiraUmaImagem = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblCaminhoImagem = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PtbImagemProduto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCondicao = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxtCodigoBarras = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.nupQuantidadeEstoque = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nupPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.nupPrecoCusto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagemProduto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Location = new System.Drawing.Point(25, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 614);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.btnRemoverImagem);
            this.panel3.Controls.Add(this.BtnAdicionarImagem);
            this.panel3.Controls.Add(this.lblInsiraUmaImagem);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.LblCaminhoImagem);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.PtbImagemProduto);
            this.panel3.Location = new System.Drawing.Point(152, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 495);
            this.panel3.TabIndex = 25;
            // 
            // btnRemoverImagem
            // 
            this.btnRemoverImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverImagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoverImagem.Location = new System.Drawing.Point(174, 433);
            this.btnRemoverImagem.Name = "btnRemoverImagem";
            this.btnRemoverImagem.Size = new System.Drawing.Size(126, 35);
            this.btnRemoverImagem.TabIndex = 1;
            this.btnRemoverImagem.Text = "Remover";
            this.btnRemoverImagem.UseVisualStyleBackColor = true;
            this.btnRemoverImagem.Click += new System.EventHandler(this.btnRemoverImagem_Click);
            // 
            // BtnAdicionarImagem
            // 
            this.BtnAdicionarImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdicionarImagem.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarImagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAdicionarImagem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnAdicionarImagem.Location = new System.Drawing.Point(44, 433);
            this.BtnAdicionarImagem.Name = "BtnAdicionarImagem";
            this.BtnAdicionarImagem.Size = new System.Drawing.Size(126, 35);
            this.BtnAdicionarImagem.TabIndex = 1;
            this.BtnAdicionarImagem.Text = "Adicionar";
            this.BtnAdicionarImagem.UseVisualStyleBackColor = false;
            this.BtnAdicionarImagem.Click += new System.EventHandler(this.BtnAdicionarImagem_Click);
            // 
            // lblInsiraUmaImagem
            // 
            this.lblInsiraUmaImagem.BackColor = System.Drawing.Color.Silver;
            this.lblInsiraUmaImagem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInsiraUmaImagem.ForeColor = System.Drawing.Color.White;
            this.lblInsiraUmaImagem.Location = new System.Drawing.Point(121, 191);
            this.lblInsiraUmaImagem.Name = "lblInsiraUmaImagem";
            this.lblInsiraUmaImagem.Size = new System.Drawing.Size(116, 50);
            this.lblInsiraUmaImagem.TabIndex = 8;
            this.lblInsiraUmaImagem.Text = "insira uma imagem";
            this.lblInsiraUmaImagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(44, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Imagem do produto";
            // 
            // LblCaminhoImagem
            // 
            this.LblCaminhoImagem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCaminhoImagem.Location = new System.Drawing.Point(98, 399);
            this.LblCaminhoImagem.Name = "LblCaminhoImagem";
            this.LblCaminhoImagem.Size = new System.Drawing.Size(202, 31);
            this.LblCaminhoImagem.TabIndex = 6;
            this.LblCaminhoImagem.Text = "none";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(44, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "caminho:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(44, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "O Tamanho máximo da imagem deve ser de 512px x 512px";
            // 
            // PtbImagemProduto
            // 
            this.PtbImagemProduto.BackColor = System.Drawing.Color.Silver;
            this.PtbImagemProduto.Location = new System.Drawing.Point(44, 90);
            this.PtbImagemProduto.Name = "PtbImagemProduto";
            this.PtbImagemProduto.Size = new System.Drawing.Size(256, 256);
            this.PtbImagemProduto.TabIndex = 0;
            this.PtbImagemProduto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.cbCondicao);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.mtxtCodigoBarras);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.nupQuantidadeEstoque);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nupPrecoVenda);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.nupPrecoCusto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtFabricante);
            this.panel2.Location = new System.Drawing.Point(505, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 495);
            this.panel2.TabIndex = 25;
            // 
            // cbCondicao
            // 
            this.cbCondicao.AutoCompleteCustomSource.AddRange(new string[] {
            "Ativo",
            "Inativo"});
            this.cbCondicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cbCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCondicao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbCondicao.FormattingEnabled = true;
            this.cbCondicao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbCondicao.Location = new System.Drawing.Point(236, 360);
            this.cbCondicao.Name = "cbCondicao";
            this.cbCondicao.Size = new System.Drawing.Size(88, 23);
            this.cbCondicao.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtNome.Location = new System.Drawing.Point(25, 106);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 20);
            this.txtNome.TabIndex = 1;
            // 
            // mtxtCodigoBarras
            // 
            this.mtxtCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.mtxtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtCodigoBarras.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mtxtCodigoBarras.Location = new System.Drawing.Point(29, 313);
            this.mtxtCodigoBarras.Mask = "000000000000";
            this.mtxtCodigoBarras.Name = "mtxtCodigoBarras";
            this.mtxtCodigoBarras.Size = new System.Drawing.Size(295, 20);
            this.mtxtCodigoBarras.TabIndex = 11;
            this.mtxtCodigoBarras.ValidatingType = typeof(int);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(25, 191);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Preço de Custo";
            // 
            // nupQuantidadeEstoque
            // 
            this.nupQuantidadeEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nupQuantidadeEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupQuantidadeEstoque.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupQuantidadeEstoque.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupQuantidadeEstoque.Location = new System.Drawing.Point(29, 361);
            this.nupQuantidadeEstoque.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupQuantidadeEstoque.Name = "nupQuantidadeEstoque";
            this.nupQuantidadeEstoque.Size = new System.Drawing.Size(201, 23);
            this.nupQuantidadeEstoque.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preço de Venda";
            // 
            // nupPrecoVenda
            // 
            this.nupPrecoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nupPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupPrecoVenda.DecimalPlaces = 2;
            this.nupPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupPrecoVenda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupPrecoVenda.Location = new System.Drawing.Point(29, 259);
            this.nupPrecoVenda.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoVenda.Name = "nupPrecoVenda";
            this.nupPrecoVenda.Size = new System.Drawing.Size(295, 23);
            this.nupPrecoVenda.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(25, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Informações";
            // 
            // nupPrecoCusto
            // 
            this.nupPrecoCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nupPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupPrecoCusto.DecimalPlaces = 2;
            this.nupPrecoCusto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupPrecoCusto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupPrecoCusto.Location = new System.Drawing.Point(27, 209);
            this.nupPrecoCusto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoCusto.Name = "nupPrecoCusto";
            this.nupPrecoCusto.Size = new System.Drawing.Size(297, 23);
            this.nupPrecoCusto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Qtd estoque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(236, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Condição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fabricante";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(29, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Código de Barras";
            // 
            // txtFabricante
            // 
            this.txtFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtFabricante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFabricante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFabricante.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtFabricante.Location = new System.Drawing.Point(25, 157);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(297, 20);
            this.txtFabricante.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnCancelar.Location = new System.Drawing.Point(658, 567);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 47);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(377, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cadastrar Produto";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnEnviar.Location = new System.Drawing.Point(758, 562);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(94, 49);
            this.btnEnviar.TabIndex = 22;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmProdutoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProdutoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoCadastrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagemProduto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.MaskedTextBox mtxtCodigoBarras;
        private System.Windows.Forms.NumericUpDown nupQuantidadeEstoque;
        private System.Windows.Forms.NumericUpDown nupPrecoVenda;
        private System.Windows.Forms.NumericUpDown nupPrecoCusto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbCondicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemoverImagem;
        private System.Windows.Forms.Button BtnAdicionarImagem;
        private System.Windows.Forms.Label lblInsiraUmaImagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox PtbImagemProduto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblCaminhoImagem;
        private System.Windows.Forms.Label label9;
    }
}