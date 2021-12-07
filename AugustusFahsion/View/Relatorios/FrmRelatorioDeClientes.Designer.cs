
namespace AugustusFahsion.View.Relatorios
{
    partial class FrmRelatorioDeClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioDeClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.cbOdenarPor = new System.Windows.Forms.ComboBox();
            this.nupQuantidadeClientes = new System.Windows.Forms.NumericUpDown();
            this.nupTotalLiquidoInicial = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFecharFiltros = new System.Windows.Forms.Button();
            this.btnFiltrarPorCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListaRelatorioClientes = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLucro = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblPrecoLiquido = new System.Windows.Forms.Label();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.lblPrecoBruto = new System.Windows.Forms.Label();
            this.lblProdutosVendidos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMostrarFiltros = new System.Windows.Forms.Button();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalLiquidoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRelatorioClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 6.15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnFechar.Location = new System.Drawing.Point(960, 40);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 40);
            this.btnFechar.TabIndex = 6;
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
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(390, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 64;
            this.label1.Text = "Relatorio de Clientes";
            // 
            // panelFiltros
            // 
            this.panelFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelFiltros.Controls.Add(this.cbOdenarPor);
            this.panelFiltros.Controls.Add(this.nupQuantidadeClientes);
            this.panelFiltros.Controls.Add(this.nupTotalLiquidoInicial);
            this.panelFiltros.Controls.Add(this.label5);
            this.panelFiltros.Controls.Add(this.txtNomeCliente);
            this.panelFiltros.Controls.Add(this.label16);
            this.panelFiltros.Controls.Add(this.label15);
            this.panelFiltros.Controls.Add(this.dtDataInicial);
            this.panelFiltros.Controls.Add(this.label6);
            this.panelFiltros.Controls.Add(this.label4);
            this.panelFiltros.Controls.Add(this.dtDataFinal);
            this.panelFiltros.Controls.Add(this.label13);
            this.panelFiltros.Controls.Add(this.button2);
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.BtnFecharFiltros);
            this.panelFiltros.Controls.Add(this.btnFiltrarPorCliente);
            this.panelFiltros.Controls.Add(this.label3);
            this.panelFiltros.Location = new System.Drawing.Point(760, 25);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(264, 745);
            this.panelFiltros.TabIndex = 63;
            this.panelFiltros.Visible = false;
            // 
            // cbOdenarPor
            // 
            this.cbOdenarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.cbOdenarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOdenarPor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbOdenarPor.FormattingEnabled = true;
            this.cbOdenarPor.Items.AddRange(new object[] {
            "Quantidade",
            "Total  desconto",
            "Total  liquido (Crescente)",
            "Total  liquido (Decrescente)"});
            this.cbOdenarPor.Location = new System.Drawing.Point(18, 234);
            this.cbOdenarPor.Name = "cbOdenarPor";
            this.cbOdenarPor.Size = new System.Drawing.Size(231, 23);
            this.cbOdenarPor.TabIndex = 49;
            // 
            // nupQuantidadeClientes
            // 
            this.nupQuantidadeClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.nupQuantidadeClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupQuantidadeClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupQuantidadeClientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupQuantidadeClientes.Location = new System.Drawing.Point(18, 398);
            this.nupQuantidadeClientes.Name = "nupQuantidadeClientes";
            this.nupQuantidadeClientes.Size = new System.Drawing.Size(231, 21);
            this.nupQuantidadeClientes.TabIndex = 48;
            // 
            // nupTotalLiquidoInicial
            // 
            this.nupTotalLiquidoInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.nupTotalLiquidoInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupTotalLiquidoInicial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupTotalLiquidoInicial.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupTotalLiquidoInicial.Location = new System.Drawing.Point(18, 341);
            this.nupTotalLiquidoInicial.Name = "nupTotalLiquidoInicial";
            this.nupTotalLiquidoInicial.Size = new System.Drawing.Size(231, 21);
            this.nupTotalLiquidoInicial.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(18, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeCliente.Location = new System.Drawing.Point(18, 290);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(231, 18);
            this.txtNomeCliente.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(18, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "Total liquido a partir de:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(18, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "Quantidade de clientes";
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicial.Location = new System.Drawing.Point(18, 159);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(107, 23);
            this.dtDataInicial.TabIndex = 44;
            this.dtDataInicial.Value = new System.DateTime(2021, 11, 10, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(18, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(18, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ordenar por:";
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(147, 159);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(102, 23);
            this.dtDataFinal.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(98, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 30);
            this.label13.TabIndex = 36;
            this.label13.Text = "Filtros";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button2.Location = new System.Drawing.Point(215, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(18, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Data Inicial:";
            // 
            // BtnFecharFiltros
            // 
            this.BtnFecharFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFecharFiltros.BackColor = System.Drawing.Color.Transparent;
            this.BtnFecharFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFecharFiltros.BackgroundImage")));
            this.BtnFecharFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFecharFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFecharFiltros.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFecharFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BtnFecharFiltros.Location = new System.Drawing.Point(279, 18);
            this.BtnFecharFiltros.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFecharFiltros.Name = "BtnFecharFiltros";
            this.BtnFecharFiltros.Size = new System.Drawing.Size(40, 40);
            this.BtnFecharFiltros.TabIndex = 6;
            this.BtnFecharFiltros.UseVisualStyleBackColor = false;
            // 
            // btnFiltrarPorCliente
            // 
            this.btnFiltrarPorCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrarPorCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrarPorCliente.BackgroundImage")));
            this.btnFiltrarPorCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrarPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrarPorCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnFiltrarPorCliente.Location = new System.Drawing.Point(79, 445);
            this.btnFiltrarPorCliente.Name = "btnFiltrarPorCliente";
            this.btnFiltrarPorCliente.Size = new System.Drawing.Size(112, 48);
            this.btnFiltrarPorCliente.TabIndex = 42;
            this.btnFiltrarPorCliente.Text = "Filtrar";
            this.btnFiltrarPorCliente.UseVisualStyleBackColor = false;
            this.btnFiltrarPorCliente.Click += new System.EventHandler(this.btnFiltrarPorCliente_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(147, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data Final:";
            // 
            // dgvListaRelatorioClientes
            // 
            this.dgvListaRelatorioClientes.AllowUserToAddRows = false;
            this.dgvListaRelatorioClientes.AllowUserToDeleteRows = false;
            this.dgvListaRelatorioClientes.AllowUserToResizeColumns = false;
            this.dgvListaRelatorioClientes.AllowUserToResizeRows = false;
            this.dgvListaRelatorioClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaRelatorioClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaRelatorioClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaRelatorioClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaRelatorioClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaRelatorioClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaRelatorioClientes.GridColor = System.Drawing.Color.Black;
            this.dgvListaRelatorioClientes.Location = new System.Drawing.Point(16, 180);
            this.dgvListaRelatorioClientes.Name = "dgvListaRelatorioClientes";
            this.dgvListaRelatorioClientes.ReadOnly = true;
            this.dgvListaRelatorioClientes.RowHeadersVisible = false;
            this.dgvListaRelatorioClientes.RowHeadersWidth = 51;
            this.dgvListaRelatorioClientes.RowTemplate.Height = 25;
            this.dgvListaRelatorioClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRelatorioClientes.Size = new System.Drawing.Size(960, 480);
            this.dgvListaRelatorioClientes.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(825, 696);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 52;
            this.label12.Text = "Lucro:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(692, 696);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "Custo:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(519, 696);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 54;
            this.label10.Text = "Preço Liquido:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(370, 696);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Descontos:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(205, 696);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 51;
            this.label8.Text = "Preço Bruto:";
            // 
            // lblLucro
            // 
            this.lblLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLucro.AutoSize = true;
            this.lblLucro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLucro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLucro.Location = new System.Drawing.Point(866, 696);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(0, 15);
            this.lblLucro.TabIndex = 57;
            // 
            // lblCusto
            // 
            this.lblCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCusto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCusto.Location = new System.Drawing.Point(734, 696);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(0, 15);
            this.lblCusto.TabIndex = 58;
            // 
            // lblPrecoLiquido
            // 
            this.lblPrecoLiquido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecoLiquido.AutoSize = true;
            this.lblPrecoLiquido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoLiquido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecoLiquido.Location = new System.Drawing.Point(603, 696);
            this.lblPrecoLiquido.Name = "lblPrecoLiquido";
            this.lblPrecoLiquido.Size = new System.Drawing.Size(0, 15);
            this.lblPrecoLiquido.TabIndex = 59;
            // 
            // lblDescontos
            // 
            this.lblDescontos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescontos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDescontos.Location = new System.Drawing.Point(437, 696);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(0, 15);
            this.lblDescontos.TabIndex = 60;
            // 
            // lblPrecoBruto
            // 
            this.lblPrecoBruto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecoBruto.AutoSize = true;
            this.lblPrecoBruto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoBruto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecoBruto.Location = new System.Drawing.Point(279, 696);
            this.lblPrecoBruto.Name = "lblPrecoBruto";
            this.lblPrecoBruto.Size = new System.Drawing.Size(0, 15);
            this.lblPrecoBruto.TabIndex = 61;
            // 
            // lblProdutosVendidos
            // 
            this.lblProdutosVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdutosVendidos.AutoSize = true;
            this.lblProdutosVendidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProdutosVendidos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblProdutosVendidos.Location = new System.Drawing.Point(123, 696);
            this.lblProdutosVendidos.Name = "lblProdutosVendidos";
            this.lblProdutosVendidos.Size = new System.Drawing.Size(0, 15);
            this.lblProdutosVendidos.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(16, 696);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "Produtos vendidos:";
            // 
            // btnMostrarFiltros
            // 
            this.btnMostrarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarFiltros.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarFiltros.BackgroundImage")));
            this.btnMostrarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnMostrarFiltros.Location = new System.Drawing.Point(904, 130);
            this.btnMostrarFiltros.Name = "btnMostrarFiltros";
            this.btnMostrarFiltros.Size = new System.Drawing.Size(78, 46);
            this.btnMostrarFiltros.TabIndex = 65;
            this.btnMostrarFiltros.Text = "Filtrar";
            this.btnMostrarFiltros.UseVisualStyleBackColor = false;
            this.btnMostrarFiltros.Click += new System.EventHandler(this.btnMostrarFiltros_Click);
            // 
            // FrmRelatorioDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.dgvListaRelatorioClientes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLucro);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.lblPrecoLiquido);
            this.Controls.Add(this.lblDescontos);
            this.Controls.Add(this.lblPrecoBruto);
            this.Controls.Add(this.lblProdutosVendidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMostrarFiltros);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorioDeClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorioDeClientes";
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalLiquidoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRelatorioClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.ComboBox cbOdenarPor;
        private System.Windows.Forms.NumericUpDown nupTotalLiquidoInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFecharFiltros;
        private System.Windows.Forms.Button btnFiltrarPorCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListaRelatorioClientes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLucro;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblPrecoLiquido;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label lblPrecoBruto;
        private System.Windows.Forms.Label lblProdutosVendidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMostrarFiltros;
        private System.Windows.Forms.NumericUpDown nupQuantidadeClientes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}