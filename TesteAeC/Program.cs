using Newtonsoft.Json;
using Selenium.Util;
using TesteAeC.Business;
using TesteAeC.Business.Interface;

//Uma library própria que utiliza do Selenium.WebDriver e Selenium.Support para
//facilitar a utilização do framework e torná-la mais rápida.
var browser = new Browser();

//Inicializa o serviço.
IPesquisaAeC _pesquisaAeC = new PesquisaAeC(browser);

//Realiza a pesquisa.
var resposta = _pesquisaAeC.Pesquisar(args[0]);

Console.WriteLine(JsonConvert.SerializeObject(resposta, Formatting.Indented));