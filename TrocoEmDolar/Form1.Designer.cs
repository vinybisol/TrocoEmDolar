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
            this.labelTroco = new System.Windows.Forms.Label();
            this.labelTrocoValor = new System.Windows.Forms.Label();
            this.labelEstadoCotacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 25);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(61, 15);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Valor Total";
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Location = new System.Drawing.Point(12, 52);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(63, 15);
            this.labelPago.TabIndex = 1;
            this.labelPago.Text = "Valor Pago";
            // 
            // labelCotacao
            // 
            this.labelCotacao.AutoSize = true;
            this.labelCotacao.Location = new System.Drawing.Point(189, 25);
            this.labelCotacao.Name = "labelCotacao";
            this.labelCotacao.Size = new System.Drawing.Size(51, 15);
            this.labelCotacao.TabIndex = 2;
            this.labelCotacao.Text = "Cotação";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(82, 22);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotal.TabIndex = 3;
            // 
            // textBoxPago
            // 
            this.textBoxPago.Location = new System.Drawing.Point(82, 49);
            this.textBoxPago.Name = "textBoxPago";
            this.textBoxPago.Size = new System.Drawing.Size(100, 23);
            this.textBoxPago.TabIndex = 4;
            // 
            // textBoxCotacao
            // 
            this.textBoxCotacao.Location = new System.Drawing.Point(245, 22);
            this.textBoxCotacao.Name = "textBoxCotacao";
            this.textBoxCotacao.Size = new System.Drawing.Size(100, 23);
            this.textBoxCotacao.TabIndex = 5;
            // 
            // labelTroco
            // 
            this.labelTroco.AutoSize = true;
            this.labelTroco.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTroco.Location = new System.Drawing.Point(12, 105);
            this.labelTroco.Name = "labelTroco";
            this.labelTroco.Size = new System.Drawing.Size(58, 25);
            this.labelTroco.TabIndex = 6;
            this.labelTroco.Text = "Troco";
            // 
            // labelTrocoValor
            // 
            this.labelTrocoValor.AutoSize = true;
            this.labelTrocoValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrocoValor.Location = new System.Drawing.Point(82, 105);
            this.labelTrocoValor.Name = "labelTrocoValor";
            this.labelTrocoValor.Size = new System.Drawing.Size(61, 25);
            this.labelTrocoValor.TabIndex = 7;
            this.labelTrocoValor.Text = "$ 0,00";
            // 
            // labelEstadoCotacao
            // 
            this.labelEstadoCotacao.AutoSize = true;
            this.labelEstadoCotacao.Location = new System.Drawing.Point(245, 52);
            this.labelEstadoCotacao.Name = "labelEstadoCotacao";
            this.labelEstadoCotacao.Size = new System.Drawing.Size(63, 15);
            this.labelEstadoCotacao.TabIndex = 8;
            this.labelEstadoCotacao.Text = "Atualizado";
            // 
            // Troco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 155);
            this.Controls.Add(this.labelEstadoCotacao);
            this.Controls.Add(this.labelTrocoValor);
            this.Controls.Add(this.labelTroco);
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
        private Label labelTroco;
        private Label labelTrocoValor;
        private Label labelEstadoCotacao;
    }
}