namespace TrocoEmDolar
{
    public partial class Troco : Form
    {
        public Troco()
        {
            InitializeComponent();
        }
        #region Metodos Privados

        private async void Troco_Load(object sender, EventArgs e)
        {
            await AtualizarCotacao();
        }
        private async Task AtualizarCotacao()
        {
            var cotacao = await new Requisicoes.RequisicaoCotacao().FazerCotacao();
            if (cotacao == null)
            {
                labelEstadoCotacao.Text = $"Erro ao atualizar os dados";
                return;
            }
            textBoxCotacao.Text = cotacao.Cotacao.ToString();
            labelEstadoCotacao.Text = $"Atualizado em {cotacao.DataAtualizado}";
        }
        private void ValidaValor(object sender)
        {
            if (!((TextBox)sender).Text.Equals(""))
            {
                try
                {
                    string texto = ((TextBox)sender).Text;
                    var valor = decimal.Parse(texto);
                    ((TextBox)sender).Text = valor.ToString("###,###,##0.00");
                }
                catch
                {
                    ((TextBox)sender).Text = "0,00";
                }
            }
        }
        private void MascaraValor(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void CalculaTroco()
        {
            try
            {
                decimal valorTotal = Convert.ToDecimal(textBoxTotal.Text);
                decimal valorPago = Convert.ToDecimal(textBoxPago.Text);
                decimal cotacao = Convert.ToDecimal(textBoxCotacao.Text);

                decimal trocoEmReais = (valorPago - valorTotal);
                decimal trocoEmDolares = Math.Round(trocoEmReais / cotacao, 2);

                Modelos.ModeloTroco troco = new Modelos.ModeloTroco
                {
                    ValorTotal = valorPago,
                    ValorPago = valorPago,
                    Cotacao = cotacao,
                    TrocoReais = trocoEmReais,
                    TrocoDolares = trocoEmDolares
                };

                MontarCampos(troco);
            }
            catch 
            {
                LimpaCampos();
            }
 
        }

        private void MontarCampos(Modelos.ModeloTroco troco)
        {
            labelTrocoValorReais.Text = $"{troco.TrocoReais:R$##0.00}";
            labelTrocoValorDolares.Text = $"{troco.TrocoDolares:$##0.00}";
        }
        private void LimpaCampos()
        {

        }
        #endregion

        #region Eventos
        private async void button1_Click(object sender, EventArgs e)
        {
            await AtualizarCotacao();
            CalculaTroco();
        }

        private void textBoxTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaraValor(sender, e);
        }

        private void textBoxPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaraValor(sender, e);
        }
        private void textBoxTotal_Validated(object sender, EventArgs e)
        {
            ValidaValor(sender);
            CalculaTroco();
        }

        private void textBoxPago_Validated(object sender, EventArgs e)
        {
            ValidaValor(sender);
            CalculaTroco();
        }
        private void textBoxCotacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaraValor(sender, e);
        }
        private void textBoxCotacao_Validated(object sender, EventArgs e)
        {
            if (!((TextBox)sender).Text.Equals(""))
            {
                try
                {
                    string texto = ((TextBox)sender).Text;
                    var valor = decimal.Parse(texto);
                    ((TextBox)sender).Text = valor.ToString("###,###,##0.0000");
                }
                catch
                {
                    ((TextBox)sender).Text = "0,00";
                }
            }
            labelEstadoCotacao.Text = "Cotação inserida manual";
            CalculaTroco();
        }

        #endregion


    }
}