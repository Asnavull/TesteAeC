namespace TesteAeC.Model.Models
{
    /// <summary>
    /// Classe de retorno dos resultados da pesquisa.
    /// </summary>
    public class RetornoPesquisa
    {
        /// <summary>
        /// Construtor do retorno
        /// </summary>
        /// <param name="tempoPesquisa">O tempo de pesquisa.</param>
        /// <param name="resultados">Os resultados</param>
        /// <param name="tempoAutomacao">O tempo da automação.</param>
        public RetornoPesquisa(TimeSpan tempoPesquisa, List<ItemPesquisa> resultados, TimeSpan tempoAutomacao)
        {
            TempoPesquisa = tempoPesquisa;
            Resultados = resultados;
            TempoAutomacao = tempoAutomacao;
        }

        /// <summary>
        /// Tempo de resposta do site para a pesquisa.
        /// </summary>
        public TimeSpan TempoPesquisa { get; set; }

        /// <summary>
        /// Tempo total da automação.
        /// </summary>
        public TimeSpan TempoAutomacao { get; set; }

        /// <summary>
        /// Lista de resultados.
        /// </summary>
        public List<ItemPesquisa> Resultados { get; set; }
    }
}