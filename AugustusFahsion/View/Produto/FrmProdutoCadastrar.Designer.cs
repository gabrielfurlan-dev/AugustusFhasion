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
            this.btnFechar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 614);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
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
            this.panel2.Location = new System.Drawing.Point(235, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 335);
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
            this.cbCondicao.Location = new System.Drawing.Point(181, 223);
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
            this.txtNome.Location = new System.Drawing.Point(48, 120);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 20);
            this.txtNome.TabIndex = 1;
            // 
            // mtxtCodigoBarras
            // 
            this.mtxtCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.mtxtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtCodigoBarras.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mtxtCodigoBarras.Location = new System.Drawing.Point(48, 226);
            this.mtxtCodigoBarras.Mask = "000000000000";
            this.mtxtCodigoBarras.Name = "mtxtCodigoBarras";
            this.mtxtCodigoBarras.Size = new System.Drawing.Size(116, 20);
            this.mtxtCodigoBarras.TabIndex = 11;
            this.mtxtCodigoBarras.ValidatingType = typeof(int);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(48, 155);
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
            this.nupQuantidadeEstoque.Location = new System.Drawing.Point(315, 173);
            this.nupQuantidadeEstoque.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupQuantidadeEstoque.Name = "nupQuantidadeEstoque";
            this.nupQuantidadeEstoque.Size = new System.Drawing.Size(108, 23);
            this.nupQuantidadeEstoque.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 155);
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
            this.nupPrecoVenda.Location = new System.Drawing.Point(181, 173);
            this.nupPrecoVenda.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoVenda.Name = "nupPrecoVenda";
            this.nupPrecoVenda.Size = new System.Drawing.Size(114, 23);
            this.nupPrecoVenda.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(50, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Informações do produto";
            // 
            // nupPrecoCusto
            // 
            this.nupPrecoCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nupPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupPrecoCusto.DecimalPlaces = 2;
            this.nupPrecoCusto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupPrecoCusto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupPrecoCusto.Location = new System.Drawing.Point(50, 173);
            this.nupPrecoCusto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoCusto.Name = "nupPrecoCusto";
            this.nupPrecoCusto.Size = new System.Drawing.Size(114, 23);
            this.nupPrecoCusto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(315, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Qtd estoque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Condição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(270, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fabricante";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(48, 208);
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
            this.txtFabricante.Location = new System.Drawing.Point(270, 120);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(153, 20);
            this.txtFabricante.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnCancelar.Location = new System.Drawing.Point(505, 444);
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
            this.label4.Location = new System.Drawing.Point(385, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cadastrar Produto";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnEnviar.Location = new System.Drawing.Point(605, 445);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(94, 49);
            this.btnEnviar.TabIndex = 22;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 6.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnFechar.Location = new System.Drawing.Point(960, 40);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 40);
            this.btnFechar.TabIndex = 60;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(165)))), ((int)(((byte)(218)))));
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmProdutoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProdutoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoCadastrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}