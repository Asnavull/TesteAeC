namespace TesteAeC.Model.Models
{
    /// <summary>
    /// Modelo dos items pesquisados
    /// </summary>
    public class ItemPesquisa
    {
        /// <summary>
        /// Construtor do item.
        /// </summary>
        /// <param name="titulo">O titulo.</param>
        /// <param name="area">A área.</param>
        /// <param name="autor">O autor.</param>
        /// <param name="descricao">A descrição.</param>
        /// <param name="dataPublicacao">A data de publicação.</param>
        public ItemPesquisa(string titulo, string area, string autor, string descricao, DateTime dataPublicacao)
        {
            Titulo = titulo;
            Area = area;
            Autor = autor;
            Descricao = descricao;
            DataPublicacao = dataPublicacao;
        }

        /// <summary>
        /// Título
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Área
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// Autor
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Descrição
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Data Publicação
        /// </summary>
        public DateTime DataPublicacao { get; set; }
    }
}