using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocoEmDolar.Requisicoes
{
    internal class RequisicaoCotacao
    {
        public async Task<Modelos.ModeloCotacao> FazerCotacao()
        {
            HttpClient client = new HttpClient();
            string url = @"https://economia.awesomeapi.com.br/last/USD-BRL";
            try
            {
                var resp = await client.GetAsync(url);
                if (resp.IsSuccessStatusCode)
                {
                    var content = await resp.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(content))
                    {
                        dynamic body = JsonConvert.DeserializeObject<dynamic>(content).USDBRL;
                        string code = body.code;
                        string codeIn = body.codeIn;
                        decimal ask = Convert.ToDecimal(body.ask);
                        DateTime create_date = Convert.ToDateTime(body.create_date);

                        return new Modelos.ModeloCotacao
                        {
                            CodigoMoeda = code,
                            CodigoMoedaComparada = codeIn,
                            Cotacao = ask,
                            DataAtualizado = create_date,
                        };

                    }
                    

                }
            }
            catch (Exception ex)
            {

            }

            return null;
            
        }
    }
}
