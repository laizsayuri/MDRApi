namespace MDRApi
{
    public class ResultadoTransacao
    {
        public ResultadoTransacao(float valorLiquido)
        {
            ValorLiquido = valorLiquido;
        }

        public float ValorLiquido { get; set; }
    }
}
