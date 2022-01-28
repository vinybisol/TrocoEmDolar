namespace TrocoEmDolar
{
    partial class Troco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPago = new System.Windows.Forms.Label();
            this.labelCotacao = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxPago = new System.Windows.Forms.TextBox();
            this.textBoxCotacao = new System.Windows.Forms.TextBox();
            this.labelTrocoDolares = new System.Windows.Forms.Label();
            this.labelTrocoValorDolares = new System.Windows.Forms.Label();
            this.labelEstadoCotacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTrocoValorReais = new System.Windows.Forms.Label();
            this.labelTrocoReais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 25);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(77, 15);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Valor Total R$";
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Location = new System.Drawing.Point(12, 52);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(82, 15);
            this.labelPago.TabIndex = 1;
            this.labelPago.Text = "Valor Pago R$ ";
            // 
            // labelCotacao
            // 
            this.labelCotacao.AutoSize = true;
            this.labelCotacao.Location = new System.Drawing.Point(208, 25);
            this.labelCotacao.Name = "labelCotacao";
            this.labelCotacao.Size = new System.Drawing.Size(51, 15);
            this.labelCotacao.TabIndex = 2;
            this.labelCotacao.Text = "Cotação";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(101, 22);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotal.TabIndex = 3;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTotal_KeyPress);
            this.textBoxTotal.Validated += new System.EventHandler(this.textBoxTotal_Validated);
            // 
            // textBoxPago
            // 
            this.textBoxPago.Location = new System.Drawing.Point(101, 49);
            this.textBoxPago.Name = "textBoxPago";
            this.textBoxPago.Size = new System.Drawing.Size(100, 23);
            this.textBoxPago.TabIndex = 4;
            this.textBoxPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPago_KeyPress);
            this.textBoxPago.Validated += new System.EventHandler(this.textBoxPago_Validated);
            // 
            // textBoxCotacao
            // 
            this.textBoxCotacao.Location = new System.Drawing.Point(264, 22);
            this.textBoxCotacao.Name = "textBoxCotacao";
            this.textBoxCotacao.Size = new System.Drawing.Size(100, 23);
            this.textBoxCotacao.TabIndex = 5;
            this.textBoxCotacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCotacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCotacao_KeyPress);
            this.textBoxCotacao.Validated += new System.EventHandler(this.textBoxCotacao_Validated);
            // 
            // labelTrocoDolares
            // 
            this.labelTrocoDolares.AutoSize = true;
            this.labelTrocoDolares.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrocoDolares.Location = new System.Drawing.Point(12, 105);
            this.labelTrocoDolares.Name = "labelTrocoDolares";
            this.labelTrocoDolares.Size = new System.Drawing.Size(158, 25);
            this.labelTrocoDolares.TabIndex = 6;
            this.labelTrocoDolares.Text = "Troco em Dólares";
            // 
            // labelTrocoValorDolares
            // 
            this.labelTrocoValorDolares.AutoSize = true;
            this.labelTrocoValorDolares.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrocoValorDolares.Location = new System.Drawing.Point(185, 105);
            this.labelTrocoValorDolares.Name = "labelTrocoValorDolares";
            this.labelTrocoValorDolares.Size = new System.Drawing.Size(61, 25);
            this.labelTrocoValorDolares.TabIndex = 7;
            this.labelTrocoValorDolares.Text = "$ 0,00";
            // 
            // labelEstadoCotacao
            // 
            this.labelEstadoCotacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEstadoCotacao.AutoSize = true;
            this.labelEstadoCotacao.Location = new System.Drawing.Point(208, 52);
            this.labelEstadoCotacao.Name = "labelEstadoCotacao";
            this.labelEstadoCotacao.Size = new System.Drawing.Size(63, 15);
            this.labelEstadoCotacao.TabIndex = 8;
            this.labelEstadoCotacao.Text = "Atualizado";
            this.labelEstadoCotacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Image = global::TrocoEmDolar.Properties.Resources.atualizar;
            this.button1.Location = new System.Drawing.Point(370, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTrocoValorReais
            // 
            this.labelTrocoValorReais.AutoSize = true;
            this.labelTrocoValorReais.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrocoValorReais.Location = new System.Drawing.Point(185, 80);
            this.labelTrocoValorReais.Name = "labelTrocoValorReais";
            this.labelTrocoValorReais.Size = new System.Drawing.Size(72, 25);
            this.labelTrocoValorReais.TabIndex = 11;
            this.labelTrocoValorReais.Text = "R$ 0,00";
            // 
            // labelTrocoReais
            // 
            this.labelTrocoReais.AutoSize = true;
            this.labelTrocoReais.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrocoReais.Location = new System.Drawing.Point(12, 80);
            this.labelTrocoReais.Name = "labelTrocoReais";
            this.labelTrocoReais.Size = new System.Drawing.Size(137, 25);
            this.labelTrocoReais.TabIndex = 10;
            this.labelTrocoReais.Text = "Troco em Reais";
            // 
            // Troco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 155);
            this.Controls.Add(this.labelTrocoValorReais);
            this.Controls.Add(this.labelTrocoReais);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelEstadoCotacao);
            this.Controls.Add(this.labelTrocoValorDolares);
            this.Controls.Add(this.labelTrocoDolares);
            this.Controls.Add(this.textBoxCotacao);
            this.Controls.Add(this.textBoxPago);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelCotacao);
            this.Controls.Add(this.labelPago);
            this.Controls.Add(this.labelTotal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Troco";
            this.Text = "Troco";
            this.Load += new System.EventHandler(this.Troco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTotal;
        private Label labelPago;
        private Label labelCotacao;
        private TextBox textBoxTotal;
        private TextBox textBoxPago;
        private TextBox textBoxCotacao;
        private Label labelTrocoDolares;
        private Label labelTrocoValorDolares;
        private Label labelEstadoCotacao;
        private Button button1;
        private Label labelTrocoValorReais;
        private Label labelTrocoReais;
    }
}