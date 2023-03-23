using TesteAeC.Model.Models;

namespace TesteAeC.Business.Interface
{
    /// <summary>
    /// Serviço de pesquisa no site AeC
    /// </summary>
    public interface IPesquisaAeC
    {
        /// <summary>
        /// Realiza a pesquisa de um termo no website.
        /// </summary>
        /// <param name="pesquisa">Termo a ser pesquisado</param>
        /// <returns></returns>
        RetornoPesquisa Pesquisar(string pesquisa);
    }
}