﻿
namespace AugustusFahsion.View
{
    partial class ProdutoCadastrar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtCodigoBarras = new System.Windows.Forms.MaskedTextBox();
            this.nupPrecoPromocao = new System.Windows.Forms.NumericUpDown();
            this.nupPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.nupPrecoCusto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 367);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnCancelar.Location = new System.Drawing.Point(255, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 47);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(149, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cadastrar Produto";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnEnviar.Location = new System.Drawing.Point(369, 289);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(113, 49);
            this.btnEnviar.TabIndex = 22;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtCodigoBarras);
            this.groupBox1.Controls.Add(this.nupPrecoPromocao);
            this.groupBox1.Controls.Add(this.nupPrecoVenda);
            this.groupBox1.Controls.Add(this.nupPrecoCusto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(18, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 222);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // mtxtCodigoBarras
            // 
            this.mtxtCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mtxtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtCodigoBarras.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mtxtCodigoBarras.Location = new System.Drawing.Point(25, 181);
            this.mtxtCodigoBarras.Mask = "000000000000";
            this.mtxtCodigoBarras.Name = "mtxtCodigoBarras";
            this.mtxtCodigoBarras.Size = new System.Drawing.Size(116, 16);
            this.mtxtCodigoBarras.TabIndex = 11;
            this.mtxtCodigoBarras.ValidatingType = typeof(int);
            // 
            // nupPrecoPromocao
            // 
            this.nupPrecoPromocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nupPrecoPromocao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupPrecoPromocao.DecimalPlaces = 2;
            this.nupPrecoPromocao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupPrecoPromocao.Location = new System.Drawing.Point(292, 128);
            this.nupPrecoPromocao.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoPromocao.Name = "nupPrecoPromocao";
            this.nupPrecoPromocao.Size = new System.Drawing.Size(114, 19);
            this.nupPrecoPromocao.TabIndex = 8;
            // 
            // nupPrecoVenda
            // 
            this.nupPrecoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nupPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupPrecoVenda.DecimalPlaces = 2;
            this.nupPrecoVenda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupPrecoVenda.Location = new System.Drawing.Point(158, 128);
            this.nupPrecoVenda.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoVenda.Name = "nupPrecoVenda";
            this.nupPrecoVenda.Size = new System.Drawing.Size(114, 19);
            this.nupPrecoVenda.TabIndex = 8;
            // 
            // nupPrecoCusto
            // 
            this.nupPrecoCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nupPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupPrecoCusto.DecimalPlaces = 2;
            this.nupPrecoCusto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nupPrecoCusto.Location = new System.Drawing.Point(27, 128);
            this.nupPrecoCusto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoCusto.Name = "nupPrecoCusto";
            this.nupPrecoCusto.Size = new System.Drawing.Size(114, 19);
            this.nupPrecoCusto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Marca";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtNome.Location = new System.Drawing.Point(25, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 16);
            this.txtNome.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtMarca.Location = new System.Drawing.Point(247, 75);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(188, 16);
            this.txtMarca.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "Código de Barras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Preço de Promoção";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(25, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(216, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Informações do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preço de Venda";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "Preço de Custo";
            // 
            // ProdutoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(505, 380);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdutoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoCadastrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtCodigoBarras;
        private System.Windows.Forms.NumericUpDown nupPrecoPromocao;
        private System.Windows.Forms.NumericUpDown nupPrecoVenda;
        private System.Windows.Forms.NumericUpDown nupPrecoCusto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
    }
}