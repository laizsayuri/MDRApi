namespace MDRApi.Models
{
    public class ResultadoTransacaoModel
    {
        public ResultadoTransacaoModel(float valorLiquido)
        {
            ValorLiquido = (float)Math.Round(valorLiquido, 2);
        }

        public float ValorLiquido { get; set; }
    }
}
