using Selenium.Util;
using Selenium.Util.Enum;
using TesteAeC.Business;
using TesteAeC.Business.Interface;

//Uma library própria que utiliza do Selenium.WebDriver e Selenium.Support para
//facilitar a utilização do framework e torná-la mais rápida.
var browser = new Browser();

IPesquisaAeC _pesquisaAeC = new PesquisaAeC(browser);

_pesquisaAeC.Pesquisar(args[0]);