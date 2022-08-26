using MDRApi.Models;

namespace MDRApi.Services
{
    public class MDRService
    {
        public List<AdquirenteModel> GetMDRList()
        {
            List<AdquirenteModel> list = new List<AdquirenteModel>()
            {
                GetAdquirenteA(),
                GetAdquirenteB(),
                GetAdquirenteC(),
            };

            return list;
        }

        public AdquirenteModel GetAdquirenteA()
        {
            AdquirenteModel adquirenteA = new AdquirenteModel()
            {
                Adquirente = "Adquirente A",
                Taxas = new List<TaxaModel>()
                {
                   new TaxaModel()
                   {
                       Bandeira = "Visa",
                       Credito = 2.25f,
                       Debito = 2.00f
                   },
                   new TaxaModel()
                   {
                       Bandeira = "Master",
                       Credito = 2.35f,
                       Debito = 1.98f
                   }
                }
            };

            return adquirenteA;
        }

        public AdquirenteModel GetAdquirenteB()
        {
            AdquirenteModel adquirenteB = new AdquirenteModel()
            {
                Adquirente = "Adquirente B",
                Taxas = new List<TaxaModel>()
                {
                   new TaxaModel()
                   {
                       Bandeira = "Visa",
                       Credito = 2.50f,
                       Debito = 2.08f
                   },
                   new TaxaModel()
                   {
                       Bandeira = "Master",
                       Credito = 2.65f,
                       Debito = 1.75f
                   }
                }
            };

            return adquirenteB;
        }

        public AdquirenteModel GetAdquirenteC()
        {
            AdquirenteModel adquirenteC = new AdquirenteModel()
            {
                Adquirente = "Adquirente C",
                Taxas = new List<TaxaModel>()
                {
                   new TaxaModel()
                   {
                       Bandeira = "Visa",
                       Credito = 2.75f,
                       Debito = 2.16f
                   },
                   new TaxaModel()
                   {
                       Bandeira = "Master",
                       Credito = 3.10f,
                       Debito = 1.58f
                   }
                }
            };

            return adquirenteC;
        }

        public ResultadoTransacaoModel CalcTransaction(TransacaoModel transacao)
        {
            AdquirenteModel adquirente = new AdquirenteModel();
            TaxaModel taxa = new TaxaModel();
            float desconto = 0;

            switch (transacao.Adquirente.ToLower())
            {
                case "a":
                    adquirente = GetAdquirenteA();
                    break;
                case "b":
                    adquirente = GetAdquirenteB();
                    break;
                case "c":
                    adquirente = GetAdquirenteC();
                    break;
                default:
                    throw new Exception("Adquirente " + transacao.Adquirente + " inválido");                   
            }

            switch (transacao.Bandeira.ToLower())
            {
                case "visa":
                    taxa = adquirente.Taxas[0];
                    break;
                case "master":
                    taxa = adquirente.Taxas[1];
                    break;
                default:
                    throw new Exception("Bandeira " + transacao.Bandeira + " inválido");
            }

            switch (transacao.Tipo.ToLower())
            {
                case "credito":
                    desconto = taxa.Credito;
                    break;
                case "debito":
                    desconto = taxa.Debito;
                    break;
                default:
                    throw new Exception("Tipo " + transacao.Tipo + " inválido");
            }

            float valorLiquido = transacao.Valor - ((desconto / 100) * transacao.Valor);
            return new ResultadoTransacaoModel(valorLiquido);
        }
    }
}
