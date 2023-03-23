using Selenium.Util;
using TesteAeC.Business;
using TesteAeC.Business.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Injeção de dependência do serviço do browser.
//Uma library própria que utiliza do Selenium.WebDriver e Selenium.Support para
//facilitar a utilização do framework e torná-la mais rápida.
builder.Services.AddSingleton(new Browser());

//Injeção de dependencia do serviço de pesquisa
builder.Services.AddScoped<IPesquisaAeC, PesquisaAeC>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();