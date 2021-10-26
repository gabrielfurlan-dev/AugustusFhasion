
namespace AugustusFahsion.View.Alterar
{
    partial class ProdutoAlterar
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnConsultarId = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(4, -4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 459);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.btnConsultarId);
            this.groupBox2.Location = new System.Drawing.Point(17, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID do Cliente:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(155, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(175, 32);
            this.txtId.TabIndex = 1;
            // 
            // btnConsultarId
            // 
            this.btnConsultarId.BackColor = System.Drawing.Color.DimGray;
            this.btnConsultarId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarId.Location = new System.Drawing.Point(382, 29);
            this.btnConsultarId.Name = "btnConsultarId";
            this.btnConsultarId.Size = new System.Drawing.Size(70, 32);
            this.btnConsultarId.TabIndex = 2;
            this.btnConsultarId.Text = "Ok";
            this.btnConsultarId.UseVisualStyleBackColor = false;
            this.btnConsultarId.Click += new System.EventHandler(this.btnConsultarId_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(254, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 47);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(159, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Alterar Produto";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(368, 388);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 49);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(17, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // mtxtCodigoBarras
            // 
            this.mtxtCodigoBarras.Location = new System.Drawing.Point(25, 181);
            this.mtxtCodigoBarras.Mask = "000000000000";
            this.mtxtCodigoBarras.Name = "mtxtCodigoBarras";
            this.mtxtCodigoBarras.Size = new System.Drawing.Size(100, 23);
            this.mtxtCodigoBarras.TabIndex = 8;
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
            this.nupPrecoPromocao.TabIndex = 7;
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
            this.nupPrecoVenda.TabIndex = 6;
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
            this.nupPrecoCusto.TabIndex = 5;
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
            this.txtNome.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(247, 75);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(188, 23);
            this.txtMarca.TabIndex = 4;
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
            // ProdutoAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.groupBox3);
            this.Name = "ProdutoAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoAlterar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecoCusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnConsultarId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
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