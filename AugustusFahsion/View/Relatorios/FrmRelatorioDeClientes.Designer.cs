
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.cbDirecaoOrdem = new System.Windows.Forms.ComboBox();
            this.cbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.cbFiltrarPor = new System.Windows.Forms.ComboBox();
            this.nupQuantidadeClientes = new System.Windows.Forms.NumericUpDown();
            this.nupAPartirDe = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFecharFiltros = new System.Windows.Forms.Button();
            this.btnFiltrarPorCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListaRelatorioClientes = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.btnMostrarFiltros = new System.Windows.Forms.Button();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.lblTotalLiquido = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalDesconto = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidadeClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAPartirDe)).BeginInit();
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
            this.panelFiltros.Controls.Add(this.cbDirecaoOrdem);
            this.panelFiltros.Controls.Add(this.cbOrdenarPor);
            this.panelFiltros.Controls.Add(this.cbFiltrarPor);
            this.panelFiltros.Controls.Add(this.nupQuantidadeClientes);
            this.panelFiltros.Controls.Add(this.nupAPartirDe);
            this.panelFiltros.Controls.Add(this.label5);
            this.panelFiltros.Controls.Add(this.txtNomeCliente);
            this.panelFiltros.Controls.Add(this.label16);
            this.panelFiltros.Controls.Add(this.label15);
            this.panelFiltros.Controls.Add(this.dtDataInicial);
            this.panelFiltros.Controls.Add(this.label6);
            this.panelFiltros.Controls.Add(this.label10);
            this.panelFiltros.Controls.Add(this.label7);
            this.panelFiltros.Controls.Add(this.label4);
            this.panelFiltros.Controls.Add(this.dtDataFinal);
            this.panelFiltros.Controls.Add(this.label13);
            this.panelFiltros.Controls.Add(this.button2);
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.BtnFecharFiltros);
            this.panelFiltros.Controls.Add(this.btnFiltrarPorCliente);
            this.panelFiltros.Controls.Add(this.label3);
            this.panelFiltros.Location = new System.Drawing.Point(760, 27);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(264, 745);
            this.panelFiltros.TabIndex = 63;
            this.panelFiltros.Visible = false;
            // 
            // cbDirecaoOrdem
            // 
            this.cbDirecaoOrdem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.cbDirecaoOrdem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirecaoOrdem.Enabled = false;
            this.cbDirecaoOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDirecaoOrdem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbDirecaoOrdem.FormattingEnabled = true;
            this.cbDirecaoOrdem.Items.AddRange(new object[] {
            "Crescente",
            "Decrescente"});
            this.cbDirecaoOrdem.Location = new System.Drawing.Point(165, 346);
            this.cbDirecaoOrdem.Name = "cbDirecaoOrdem";
            this.cbDirecaoOrdem.Size = new System.Drawing.Size(82, 23);
            this.cbDirecaoOrdem.TabIndex = 51;
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.cbOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOrdenarPor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbOrdenarPor.FormattingEnabled = true;
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "Quantidade",
            "Total desconto",
            "Total liquido"});
            this.cbOrdenarPor.Location = new System.Drawing.Point(16, 346);
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(143, 23);
            this.cbOrdenarPor.TabIndex = 50;
            this.cbOrdenarPor.SelectedIndexChanged += new System.EventHandler(this.cbOrdenarPor_SelectedIndexChanged);
            // 
            // cbFiltrarPor
            // 
            this.cbFiltrarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.cbFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFiltrarPor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbFiltrarPor.FormattingEnabled = true;
            this.cbFiltrarPor.Items.AddRange(new object[] {
            "Quantidade",
            "Total  desconto",
            "Total  liquido"});
            this.cbFiltrarPor.Location = new System.Drawing.Point(18, 234);
            this.cbFiltrarPor.Name = "cbFiltrarPor";
            this.cbFiltrarPor.Size = new System.Drawing.Size(231, 23);
            this.cbFiltrarPor.TabIndex = 49;
            // 
            // nupQuantidadeClientes
            // 
            this.nupQuantidadeClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.nupQuantidadeClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupQuantidadeClientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupQuantidadeClientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupQuantidadeClientes.Location = new System.Drawing.Point(16, 453);
            this.nupQuantidadeClientes.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nupQuantidadeClientes.Name = "nupQuantidadeClientes";
            this.nupQuantidadeClientes.Size = new System.Drawing.Size(231, 21);
            this.nupQuantidadeClientes.TabIndex = 48;
            // 
            // nupAPartirDe
            // 
            this.nupAPartirDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.nupAPartirDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupAPartirDe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nupAPartirDe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupAPartirDe.Location = new System.Drawing.Point(16, 287);
            this.nupAPartirDe.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nupAPartirDe.Name = "nupAPartirDe";
            this.nupAPartirDe.Size = new System.Drawing.Size(233, 21);
            this.nupAPartirDe.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(16, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nome cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeCliente.Location = new System.Drawing.Point(16, 402);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(231, 18);
            this.txtNomeCliente.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(16, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "A partir:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(16, 435);
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
            this.dtDataInicial.Size = new System.Drawing.Size(109, 23);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(165, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Direcao:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(16, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ordenar por:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(18, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Filtrar por:";
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFinal.Location = new System.Drawing.Point(138, 159);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(111, 23);
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
            this.btnFiltrarPorCliente.Location = new System.Drawing.Point(78, 510);
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
            this.dgvListaRelatorioClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaRelatorioClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaRelatorioClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaRelatorioClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaRelatorioClientes.GridColor = System.Drawing.Color.Black;
            this.dgvListaRelatorioClientes.Location = new System.Drawing.Point(58, 180);
            this.dgvListaRelatorioClientes.Name = "dgvListaRelatorioClientes";
            this.dgvListaRelatorioClientes.ReadOnly = true;
            this.dgvListaRelatorioClientes.RowHeadersVisible = false;
            this.dgvListaRelatorioClientes.RowHeadersWidth = 51;
            this.dgvListaRelatorioClientes.RowTemplate.Height = 25;
            this.dgvListaRelatorioClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRelatorioClientes.Size = new System.Drawing.Size(901, 441);
            this.dgvListaRelatorioClientes.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(291, 649);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Total bruto:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(58, 649);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 15);
            this.label8.TabIndex = 51;
            this.label8.Text = "Quantidade de vendas:";
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalVendas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalVendas.Location = new System.Drawing.Point(192, 649);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(13, 15);
            this.lblTotalVendas.TabIndex = 61;
            this.lblTotalVendas.Text = "0";
            // 
            // btnMostrarFiltros
            // 
            this.btnMostrarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarFiltros.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrarFiltros.BackgroundImage")));
            this.btnMostrarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnMostrarFiltros.Location = new System.Drawing.Point(881, 128);
            this.btnMostrarFiltros.Name = "btnMostrarFiltros";
            this.btnMostrarFiltros.Size = new System.Drawing.Size(78, 46);
            this.btnMostrarFiltros.TabIndex = 65;
            this.btnMostrarFiltros.Text = "Filtrar";
            this.btnMostrarFiltros.UseVisualStyleBackColor = false;
            this.btnMostrarFiltros.Click += new System.EventHandler(this.btnMostrarFiltros_Click);
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBruto.AutoSize = true;
            this.lblTotalBruto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalBruto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalBruto.Location = new System.Drawing.Point(364, 649);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(13, 15);
            this.lblTotalBruto.TabIndex = 61;
            this.lblTotalBruto.Text = "0";
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLiquido.AutoSize = true;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalLiquido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalLiquido.Location = new System.Drawing.Point(736, 649);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(13, 15);
            this.lblTotalLiquido.TabIndex = 61;
            this.lblTotalLiquido.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(655, 649);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "Total liquido:";
            // 
            // lblTotalDesconto
            // 
            this.lblTotalDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDesconto.AutoSize = true;
            this.lblTotalDesconto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDesconto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalDesconto.Location = new System.Drawing.Point(556, 649);
            this.lblTotalDesconto.Name = "lblTotalDesconto";
            this.lblTotalDesconto.Size = new System.Drawing.Size(13, 15);
            this.lblTotalDesconto.TabIndex = 61;
            this.lblTotalDesconto.Text = "0";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(463, 649);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 15);
            this.label17.TabIndex = 55;
            this.label17.Text = "Total desconto:";
            // 
            // FrmRelatorioDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.dgvListaRelatorioClientes);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalDesconto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalLiquido);
            this.Controls.Add(this.lblTotalBruto);
            this.Controls.Add(this.lblTotalVendas);
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
            ((System.ComponentModel.ISupportInitialize)(this.nupAPartirDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRelatorioClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.ComboBox cbFiltrarPor;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Button btnMostrarFiltros;
        private System.Windows.Forms.NumericUpDown nupQuantidadeClientes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Label lblTotalLiquido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalDesconto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbOrdenarPor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDirecaoOrdem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nupAPartirDe;
    }
}