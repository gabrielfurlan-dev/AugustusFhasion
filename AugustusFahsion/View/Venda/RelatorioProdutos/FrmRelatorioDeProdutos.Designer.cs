
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
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarPorProduto = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListaVenda = new System.Windows.Forms.DataGridView();
            this.btnListarRelatorios = new System.Windows.Forms.Button();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.BtnFecharFiltros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarFiltros = new System.Windows.Forms.Button();
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
            this.BtnFechar.Location = new System.Drawing.Point(960, 40);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(49, 40);
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
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicial.Location = new System.Drawing.Point(24, 156);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(102, 23);
            this.dtDataInicial.TabIndex = 44;
            this.dtDataInicial.Value = new System.DateTime(2021, 11, 10, 0, 0, 0, 0);
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(148, 156);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(102, 23);
            this.dtDataFinal.TabIndex = 45;
            // 
            // btnFiltrarPorProduto
            // 
            this.btnFiltrarPorProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrarPorProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrarPorProduto.BackgroundImage")));
            this.btnFiltrarPorProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrarPorProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarPorProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnFiltrarPorProduto.Location = new System.Drawing.Point(72, 306);
            this.btnFiltrarPorProduto.Name = "btnFiltrarPorProduto";
            this.btnFiltrarPorProduto.Size = new System.Drawing.Size(112, 48);
            this.btnFiltrarPorProduto.TabIndex = 42;
            this.btnFiltrarPorProduto.Text = "Filtrar";
            this.btnFiltrarPorProduto.UseVisualStyleBackColor = false;
            this.btnFiltrarPorProduto.Click += new System.EventHandler(this.btnFiltrarPorProduto_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdCliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdCliente.Location = new System.Drawing.Point(12, 265);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(231, 22);
            this.txtIdCliente.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(148, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data Final:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Data Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cliente (id):";
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
            this.dgvListaVenda.Location = new System.Drawing.Point(31, 195);
            this.dgvListaVenda.Name = "dgvListaVenda";
            this.dgvListaVenda.ReadOnly = true;
            this.dgvListaVenda.RowHeadersVisible = false;
            this.dgvListaVenda.RowHeadersWidth = 51;
            this.dgvListaVenda.RowTemplate.Height = 25;
            this.dgvListaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVenda.Size = new System.Drawing.Size(960, 480);
            this.dgvListaVenda.TabIndex = 32;
            // 
            // btnListarRelatorios
            // 
            this.btnListarRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnListarRelatorios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListarRelatorios.BackgroundImage")));
            this.btnListarRelatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListarRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarRelatorios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListarRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnListarRelatorios.Location = new System.Drawing.Point(832, 136);
            this.btnListarRelatorios.Name = "btnListarRelatorios";
            this.btnListarRelatorios.Size = new System.Drawing.Size(50, 56);
            this.btnListarRelatorios.TabIndex = 42;
            this.btnListarRelatorios.UseVisualStyleBackColor = false;
            // 
            // panelFiltros
            // 
            this.panelFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelFiltros.Controls.Add(this.label5);
            this.panelFiltros.Controls.Add(this.txtNomeProduto);
            this.panelFiltros.Controls.Add(this.dtDataInicial);
            this.panelFiltros.Controls.Add(this.label4);
            this.panelFiltros.Controls.Add(this.dtDataFinal);
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.BtnFecharFiltros);
            this.panelFiltros.Controls.Add(this.btnFiltrarPorProduto);
            this.panelFiltros.Controls.Add(this.label3);
            this.panelFiltros.Controls.Add(this.txtIdCliente);
            this.panelFiltros.Location = new System.Drawing.Point(760, 27);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(264, 745);
            this.panelFiltros.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Produto:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProduto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeProduto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 216);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(231, 22);
            this.txtNomeProduto.TabIndex = 47;
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
            this.BtnFecharFiltros.Location = new System.Drawing.Point(26, 15);
            this.BtnFecharFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFecharFiltros.Name = "BtnFecharFiltros";
            this.BtnFecharFiltros.Size = new System.Drawing.Size(45, 45);
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
            this.label1.Location = new System.Drawing.Point(364, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 47;
            this.label1.Text = "Relatorio de Produtos";
            // 
            // btnMostrarFiltros
            // 
            this.btnMostrarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarFiltros.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarFiltros.BackgroundImage")));
            this.btnMostrarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnMostrarFiltros.Location = new System.Drawing.Point(887, 140);
            this.btnMostrarFiltros.Name = "btnMostrarFiltros";
            this.btnMostrarFiltros.Size = new System.Drawing.Size(116, 46);
            this.btnMostrarFiltros.TabIndex = 48;
            this.btnMostrarFiltros.Text = "Filtrar";
            this.btnMostrarFiltros.UseVisualStyleBackColor = false;
            this.btnMostrarFiltros.Click += new System.EventHandler(this.btnMostrarFiltros_Click);
            // 
            // FrmRelatorioDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.dgvListaVenda);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnListarRelatorios);
            this.Controls.Add(this.btnMostrarFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.Button btnFiltrarPorProduto;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListaVenda;
        private System.Windows.Forms.Button btnListarRelatorios;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFecharFiltros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnMostrarFiltros;
    }
}