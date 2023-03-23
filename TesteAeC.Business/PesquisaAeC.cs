using OpenQA.Selenium;
using Selenium.Util;
using Selenium.Util.Helpers;
using System.Diagnostics;
using TesteAeC.Business.Interface;
using TesteAeC.Model.Models;

namespace TesteAeC.Business
{
    public class PesquisaAeC : IPesquisaAeC
    {
        private readonly Browser _browser;

        public PesquisaAeC(Browser browser)
        {
            _browser = browser;
        }

        public RetornoPesquisa Pesquisar(string pesquisa)
        {
            //Direciona o browser para o endereço
            _browser.Driver.Url = "https://www.aec.com.br/";

            //Inicializa o objeto de retorno.
            RetornoPesquisa retorno = new(TimeSpan.Zero, new(), TimeSpan.Zero);

            var watch = new Stopwatch();

            //Inicializa o timer
            watch.Start();

            //Aguarda pelo elemento âncora da página
            if (_browser.Driver.AwaitElement(By.Id("Menu_-_Busca")))
            {
                //Define o valor a ser pesquisado.
                _browser.Driver.FindElementByAttribute(By.TagName("input"), "title", "Pesquisar").SetAttributeJs("value", pesquisa);

                //Clica em pesquisar.
                _browser.Driver.FindElement(By.Id("Menu_-_Busca")).GetParentElement().ClickJs();

                //Aguarda pelo resultado da pesquisa.
                if (_browser.Driver.AwaitElement(By.ClassName("cardPost")))
                {
                    retorno.TempoPesquisa = watch.Elapsed;
                    //Para cada resultado da pesquisa adiciona
                    foreach (var card in _browser.Driver.FindElements(By.ClassName("cardPost")))
                    {
                        //Ao chamar o FindElement a partir do card é procurado apenas os filhos do elemento.

                        //Coleta o título.
                        var titulo = card.GetAttribute("title");
                        var area = card.FindElement(By.ClassName("hat"))?.Text;
                        var descricao = card.FindElement(By.ClassName("duas-linhas"))?.Text;

                        var textoPublicacao = card.FindElement(By.TagName("small"))?.Text;

                        var indexPor = textoPublicacao?.IndexOf("por") + 3;
                        var indexEm = textoPublicacao?.IndexOf("em") + 2;

                        DateTime.TryParse(textoPublicacao[indexEm.GetValueOrDefault(0)..].Trim(), out var dataPublicacao);
                        var autor = textoPublicacao[indexPor.GetValueOrDefault(0)..(indexEm.GetValueOrDefault(0) - 2)].Trim();

                        retorno.Resultados.Add(new(titulo, area, autor, descricao, dataPublicacao));
                    }
                }
                retorno.TempoAutomacao = watch.Elapsed;

                watch.Stop();

                return retorno;
            }
            else
            {
                watch.Stop();
                throw new NoSuchElementException("O campo de busca não foi localizado.");
            }
        }
    }
}