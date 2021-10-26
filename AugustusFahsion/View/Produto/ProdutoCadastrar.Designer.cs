
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(144, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cadastrar Produto";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnEnviar);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(4, -25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 391);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(250, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 47);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(364, 320);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(113, 49);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // mtxtCodigoBarras
            // 
            this.mtxtCodigoBarras.Location = new System.Drawing.Point(25, 181);
            this.mtxtCodigoBarras.Mask = "000000000000";
            this.mtxtCodigoBarras.Name = "mtxtCodigoBarras";
            this.mtxtCodigoBarras.Size = new System.Drawing.Size(116, 23);
            this.mtxtCodigoBarras.TabIndex = 11;
            this.mtxtCodigoBarras.ValidatingType = typeof(int);
            // 
            // nupPrecoPromocao
            // 
            this.nupPrecoPromocao.DecimalPlaces = 2;
            this.nupPrecoPromocao.Location = new System.Drawing.Point(292, 128);
            this.nupPrecoPromocao.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoPromocao.Name = "nupPrecoPromocao";
            this.nupPrecoPromocao.Size = new System.Drawing.Size(114, 23);
            this.nupPrecoPromocao.TabIndex = 8;
            // 
            // nupPrecoVenda
            // 
            this.nupPrecoVenda.DecimalPlaces = 2;
            this.nupPrecoVenda.Location = new System.Drawing.Point(158, 128);
            this.nupPrecoVenda.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoVenda.Name = "nupPrecoVenda";
            this.nupPrecoVenda.Size = new System.Drawing.Size(114, 23);
            this.nupPrecoVenda.TabIndex = 8;
            // 
            // nupPrecoCusto
            // 
            this.nupPrecoCusto.DecimalPlaces = 2;
            this.nupPrecoCusto.Location = new System.Drawing.Point(27, 128);
            this.nupPrecoCusto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupPrecoCusto.Name = "nupPrecoCusto";
            this.nupPrecoCusto.Size = new System.Drawing.Size(114, 23);
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
            this.txtNome.Location = new System.Drawing.Point(25, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(247, 75);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(188, 23);
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
            this.ClientSize = new System.Drawing.Size(505, 380);
            this.Controls.Add(this.groupBox3);
            this.Name = "ProdutoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoCadastrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
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