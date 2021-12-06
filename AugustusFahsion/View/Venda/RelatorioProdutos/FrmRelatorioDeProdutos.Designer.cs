
namespace AugustusFahsion.View.Venda
{
    partial class FrmRelatorioDeProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioDeProdutos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dateDataFinal = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarPorProduto = new System.Windows.Forms.Button();
            this.txtFiltrarPorColaborador = new System.Windows.Forms.TextBox();
            this.txtBuscarPorProduto = new System.Windows.Forms.TextBox();
            this.txtFiltrarPorCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListaVenda = new System.Windows.Forms.DataGridView();
            this.BtnAbrirFiltros = new System.Windows.Forms.Button();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.BtnFecharFiltros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenda)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.BackColor = System.Drawing.Color.Transparent;
            this.BtnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFechar.BackgroundImage")));
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Segoe UI", 6.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BtnFechar.Location = new System.Drawing.Point(1097, 53);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(56, 53);
            this.BtnFechar.TabIndex = 6;
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(165)))), ((int)(((byte)(218)))));
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateDataInicial
            // 
            this.dateDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataInicial.Location = new System.Drawing.Point(17, 208);
            this.dateDataInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateDataInicial.Name = "dateDataInicial";
            this.dateDataInicial.Size = new System.Drawing.Size(116, 27);
            this.dateDataInicial.TabIndex = 44;
            // 
            // dateDataFinal
            // 
            this.dateDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataFinal.Location = new System.Drawing.Point(159, 208);
            this.dateDataFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateDataFinal.Name = "dateDataFinal";
            this.dateDataFinal.Size = new System.Drawing.Size(116, 27);
            this.dateDataFinal.TabIndex = 45;
            // 
            // btnFiltrarPorProduto
            // 
            this.btnFiltrarPorProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrarPorProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrarPorProduto.BackgroundImage")));
            this.btnFiltrarPorProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrarPorProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarPorProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnFiltrarPorProduto.Location = new System.Drawing.Point(83, 460);
            this.btnFiltrarPorProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrarPorProduto.Name = "btnFiltrarPorProduto";
            this.btnFiltrarPorProduto.Size = new System.Drawing.Size(128, 64);
            this.btnFiltrarPorProduto.TabIndex = 42;
            this.btnFiltrarPorProduto.Text = "Filtrar";
            this.btnFiltrarPorProduto.UseVisualStyleBackColor = false;
            this.btnFiltrarPorProduto.Click += new System.EventHandler(this.btnFiltrarPorProduto_Click);
            // 
            // txtFiltrarPorColaborador
            // 
            this.txtFiltrarPorColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFiltrarPorColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarPorColaborador.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltrarPorColaborador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtFiltrarPorColaborador.Location = new System.Drawing.Point(19, 337);
            this.txtFiltrarPorColaborador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltrarPorColaborador.Name = "txtFiltrarPorColaborador";
            this.txtFiltrarPorColaborador.Size = new System.Drawing.Size(256, 25);
            this.txtFiltrarPorColaborador.TabIndex = 38;
            // 
            // txtBuscarPorProduto
            // 
            this.txtBuscarPorProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtBuscarPorProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPorProduto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscarPorProduto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtBuscarPorProduto.Location = new System.Drawing.Point(19, 397);
            this.txtBuscarPorProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarPorProduto.Name = "txtBuscarPorProduto";
            this.txtBuscarPorProduto.Size = new System.Drawing.Size(256, 25);
            this.txtBuscarPorProduto.TabIndex = 39;
            // 
            // txtFiltrarPorCliente
            // 
            this.txtFiltrarPorCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFiltrarPorCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarPorCliente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltrarPorCliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtFiltrarPorCliente.Location = new System.Drawing.Point(19, 277);
            this.txtFiltrarPorCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltrarPorCliente.Name = "txtFiltrarPorCliente";
            this.txtFiltrarPorCliente.Size = new System.Drawing.Size(256, 25);
            this.txtFiltrarPorCliente.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(19, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Colaborador:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(159, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(19, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(17, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Data Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(19, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cliente:";
            // 
            // dgvListaVenda
            // 
            this.dgvListaVenda.AllowUserToAddRows = false;
            this.dgvListaVenda.AllowUserToDeleteRows = false;
            this.dgvListaVenda.AllowUserToResizeColumns = false;
            this.dgvListaVenda.AllowUserToResizeRows = false;
            this.dgvListaVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaVenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaVenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaVenda.GridColor = System.Drawing.Color.Black;
            this.dgvListaVenda.Location = new System.Drawing.Point(35, 260);
            this.dgvListaVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaVenda.Name = "dgvListaVenda";
            this.dgvListaVenda.ReadOnly = true;
            this.dgvListaVenda.RowHeadersVisible = false;
            this.dgvListaVenda.RowHeadersWidth = 51;
            this.dgvListaVenda.RowTemplate.Height = 25;
            this.dgvListaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVenda.Size = new System.Drawing.Size(1097, 640);
            this.dgvListaVenda.TabIndex = 32;
            // 
            // BtnAbrirFiltros
            // 
            this.BtnAbrirFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbrirFiltros.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbrirFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAbrirFiltros.BackgroundImage")));
            this.BtnAbrirFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAbrirFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirFiltros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAbrirFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BtnAbrirFiltros.Location = new System.Drawing.Point(1064, 188);
            this.BtnAbrirFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAbrirFiltros.Name = "BtnAbrirFiltros";
            this.BtnAbrirFiltros.Size = new System.Drawing.Size(51, 60);
            this.BtnAbrirFiltros.TabIndex = 42;
            this.BtnAbrirFiltros.UseVisualStyleBackColor = false;
            this.BtnAbrirFiltros.Click += new System.EventHandler(this.BtnAbrirFiltros_Click);
            // 
            // panelFiltros
            // 
            this.panelFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelFiltros.Controls.Add(this.dateDataInicial);
            this.panelFiltros.Controls.Add(this.label4);
            this.panelFiltros.Controls.Add(this.dateDataFinal);
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.BtnFecharFiltros);
            this.panelFiltros.Controls.Add(this.label5);
            this.panelFiltros.Controls.Add(this.btnFiltrarPorProduto);
            this.panelFiltros.Controls.Add(this.label3);
            this.panelFiltros.Controls.Add(this.txtFiltrarPorColaborador);
            this.panelFiltros.Controls.Add(this.label6);
            this.panelFiltros.Controls.Add(this.txtBuscarPorProduto);
            this.panelFiltros.Controls.Add(this.txtFiltrarPorCliente);
            this.panelFiltros.Location = new System.Drawing.Point(879, 25);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(291, 1000);
            this.panelFiltros.TabIndex = 46;
            // 
            // BtnFecharFiltros
            // 
            this.BtnFecharFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFecharFiltros.BackColor = System.Drawing.Color.Transparent;
            this.BtnFecharFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFecharFiltros.BackgroundImage")));
            this.BtnFecharFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFecharFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFecharFiltros.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFecharFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BtnFecharFiltros.Location = new System.Drawing.Point(19, 20);
            this.BtnFecharFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFecharFiltros.Name = "BtnFecharFiltros";
            this.BtnFecharFiltros.Size = new System.Drawing.Size(51, 60);
            this.BtnFecharFiltros.TabIndex = 6;
            this.BtnFecharFiltros.Text = ">";
            this.BtnFecharFiltros.UseVisualStyleBackColor = false;
            this.BtnFecharFiltros.Click += new System.EventHandler(this.BtnFecharFiltros_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(416, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 47;
            this.label1.Text = "Relatorio de Produtos";
            // 
            // FrmRelatorioDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1170, 1024);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.BtnAbrirFiltros);
            this.Controls.Add(this.dgvListaVenda);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRelatorioDeProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioDeVendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioDeVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenda)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dateDataInicial;
        private System.Windows.Forms.DateTimePicker dateDataFinal;
        private System.Windows.Forms.Button btnFiltrarPorProduto;
        private System.Windows.Forms.TextBox txtFiltrarPorColaborador;
        private System.Windows.Forms.TextBox txtBuscarPorProduto;
        private System.Windows.Forms.TextBox txtFiltrarPorCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListaVenda;
        private System.Windows.Forms.Button BtnAbrirFiltros;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFecharFiltros;
    }
}