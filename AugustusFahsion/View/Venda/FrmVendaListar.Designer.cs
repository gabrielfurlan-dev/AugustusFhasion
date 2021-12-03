
namespace AugustusFahsion.View.Venda
{
    partial class FrmVendaListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendaListar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFiltrarPorCliente = new System.Windows.Forms.Button();
            this.txtFiltrarPorCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaVenda = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscarPorProduto = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorProduto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltrarPorColaborador = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorColaborador = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrarPorCliente
            // 
            this.btnFiltrarPorCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFiltrarPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarPorCliente.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarPorCliente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFiltrarPorCliente.Location = new System.Drawing.Point(189, 141);
            this.btnFiltrarPorCliente.Name = "btnFiltrarPorCliente";
            this.btnFiltrarPorCliente.Size = new System.Drawing.Size(23, 22);
            this.btnFiltrarPorCliente.TabIndex = 23;
            this.btnFiltrarPorCliente.Text = "🔎";
            this.btnFiltrarPorCliente.UseVisualStyleBackColor = false;
            this.btnFiltrarPorCliente.Click += new System.EventHandler(this.btnFiltrarPorCliente_Click);
            // 
            // txtFiltrarPorCliente
            // 
            this.txtFiltrarPorCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFiltrarPorCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarPorCliente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltrarPorCliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtFiltrarPorCliente.Location = new System.Drawing.Point(39, 141);
            this.txtFiltrarPorCliente.Name = "txtFiltrarPorCliente";
            this.txtFiltrarPorCliente.Size = new System.Drawing.Size(144, 22);
            this.txtFiltrarPorCliente.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(39, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cliente:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnAlterar.Location = new System.Drawing.Point(500, 690);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(114, 41);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnFechar.Location = new System.Drawing.Point(398, 690);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(96, 41);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(421, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista de vendas";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaVenda.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaVenda.GridColor = System.Drawing.Color.Black;
            this.dgvListaVenda.Location = new System.Drawing.Point(39, 173);
            this.dgvListaVenda.Name = "dgvListaVenda";
            this.dgvListaVenda.ReadOnly = true;
            this.dgvListaVenda.RowHeadersVisible = false;
            this.dgvListaVenda.RowTemplate.Height = 25;
            this.dgvListaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVenda.Size = new System.Drawing.Size(947, 483);
            this.dgvListaVenda.TabIndex = 17;
            this.dgvListaVenda.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaVenda_CellMouseClick);
            this.dgvListaVenda.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaVenda_CellMouseDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 6.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnCancelar.Location = new System.Drawing.Point(960, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 40);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // dateDataFinal
            // 
            this.dateDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataFinal.Location = new System.Drawing.Point(884, 141);
            this.dateDataFinal.Name = "dateDataFinal";
            this.dateDataFinal.Size = new System.Drawing.Size(102, 23);
            this.dateDataFinal.TabIndex = 31;
            this.dateDataFinal.ValueChanged += new System.EventHandler(this.dateDataFinal_ValueChanged);
            // 
            // dateDataInicial
            // 
            this.dateDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataInicial.Location = new System.Drawing.Point(760, 141);
            this.dateDataInicial.Name = "dateDataInicial";
            this.dateDataInicial.Size = new System.Drawing.Size(102, 23);
            this.dateDataInicial.TabIndex = 31;
            this.dateDataInicial.ValueChanged += new System.EventHandler(this.dateDataInicial_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(760, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data Inicial:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(884, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(421, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Produto:";
            // 
            // txtBuscarPorProduto
            // 
            this.txtBuscarPorProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtBuscarPorProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPorProduto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscarPorProduto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtBuscarPorProduto.Location = new System.Drawing.Point(421, 141);
            this.txtBuscarPorProduto.Name = "txtBuscarPorProduto";
            this.txtBuscarPorProduto.Size = new System.Drawing.Size(140, 22);
            this.txtBuscarPorProduto.TabIndex = 22;
            // 
            // btnFiltrarPorProduto
            // 
            this.btnFiltrarPorProduto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFiltrarPorProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarPorProduto.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarPorProduto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFiltrarPorProduto.Location = new System.Drawing.Point(567, 141);
            this.btnFiltrarPorProduto.Name = "btnFiltrarPorProduto";
            this.btnFiltrarPorProduto.Size = new System.Drawing.Size(23, 22);
            this.btnFiltrarPorProduto.TabIndex = 23;
            this.btnFiltrarPorProduto.Text = "🔎";
            this.btnFiltrarPorProduto.UseVisualStyleBackColor = false;
            this.btnFiltrarPorProduto.Click += new System.EventHandler(this.btnFiltrarPorProduto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(232, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Colaborador:";
            // 
            // txtFiltrarPorColaborador
            // 
            this.txtFiltrarPorColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFiltrarPorColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarPorColaborador.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltrarPorColaborador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtFiltrarPorColaborador.Location = new System.Drawing.Point(232, 141);
            this.txtFiltrarPorColaborador.Name = "txtFiltrarPorColaborador";
            this.txtFiltrarPorColaborador.Size = new System.Drawing.Size(140, 22);
            this.txtFiltrarPorColaborador.TabIndex = 22;
            // 
            // btnFiltrarPorColaborador
            // 
            this.btnFiltrarPorColaborador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFiltrarPorColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarPorColaborador.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarPorColaborador.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFiltrarPorColaborador.Location = new System.Drawing.Point(378, 141);
            this.btnFiltrarPorColaborador.Name = "btnFiltrarPorColaborador";
            this.btnFiltrarPorColaborador.Size = new System.Drawing.Size(23, 22);
            this.btnFiltrarPorColaborador.TabIndex = 23;
            this.btnFiltrarPorColaborador.Text = "🔎";
            this.btnFiltrarPorColaborador.UseVisualStyleBackColor = false;
            this.btnFiltrarPorColaborador.Click += new System.EventHandler(this.btnFiltrarPorColaborador_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(165)))), ((int)(((byte)(218)))));
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmVendaListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateDataInicial);
            this.Controls.Add(this.dateDataFinal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFiltrarPorColaborador);
            this.Controls.Add(this.btnFiltrarPorProduto);
            this.Controls.Add(this.btnFiltrarPorCliente);
            this.Controls.Add(this.txtFiltrarPorColaborador);
            this.Controls.Add(this.txtBuscarPorProduto);
            this.Controls.Add(this.txtFiltrarPorCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaVenda);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVendaListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListarVenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltrarPorCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateDataFinal;
        private System.Windows.Forms.DateTimePicker dateDataInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarPorProduto;
        private System.Windows.Forms.Button btnFiltrarPorProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltrarPorColaborador;
        private System.Windows.Forms.Button btnFiltrarPorColaborador;
        private System.Windows.Forms.Button btnFiltrarPorCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}