using Selenium.Util;
using TesteAeC.Business;
using TesteAeC.Business.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Inje��o de depend�ncia do servi�o do browser.
//Uma library pr�pria que utiliza do Selenium.WebDriver e Selenium.Support para
//facilitar a utiliza��o do framework e torn�-la mais r�pida.
builder.Services.AddSingleton(new Browser());

//Inje��o de dependencia do servi�o de pesquisa
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