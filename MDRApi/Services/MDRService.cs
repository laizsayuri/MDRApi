namespace MDRApi.Services
{
    public class MDRService
    {
        public List<Adquirente> GetMDRList()
        {
            List<Adquirente> list = new List<Adquirente>()
            {
                GetAdquirenteA(),
                GetAdquirenteB(),
                GetAdquirenteC(),
            };

            return list;
        }

        public Adquirente GetAdquirenteA()
        {
            Adquirente adquirenteA = new Adquirente()
            {
                Nome = "Adquirente A",
                Taxas = new List<Taxa>()
                {
                   new Taxa()
                   {
                       Bandeira = "Visa",
                       Credito = 2.25f,
                       Debito = 2.00f
                   },
                   new Taxa()
                   {
                       Bandeira = "Master",
                       Credito = 2.35f,
                       Debito = 1.98f
                   }
                }
            };

            return adquirenteA;
        }

        public Adquirente GetAdquirenteB()
        {
            Adquirente adquirenteB = new Adquirente()
            {
                Nome = "Adquirente B",
                Taxas = new List<Taxa>()
                {
                   new Taxa()
                   {
                       Bandeira = "Visa",
                       Credito = 2.50f,
                       Debito = 2.08f
                   },
                   new Taxa()
                   {
                       Bandeira = "Master",
                       Credito = 2.65f,
                       Debito = 1.75f
                   }
                }
            };

            return adquirenteB;
        }

        public Adquirente GetAdquirenteC()
        {
            Adquirente adquirenteC = new Adquirente()
            {
                Nome = "Adquirente C",
                Taxas = new List<Taxa>()
                {
                   new Taxa()
                   {
                       Bandeira = "Visa",
                       Credito = 2.75f,
                       Debito = 2.16f
                   },
                   new Taxa()
                   {
                       Bandeira = "Master",
                       Credito = 3.10f,
                       Debito = 1.58f
                   }
                }
            };

            return adquirenteC;
        }
    }
}
