using Microsoft.Extension.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();

using IHost AppHost = Builder.Build();


IAppLogger logger = AppHost.Services.GetRequiredService<IAppLogger>();
logger.Writelog("Applicacion started.");

IProductService service = AppHost.Services.GetRequiredService<IProductService>();
service.Add("Demo", "Azucar refinada");

/*
 * AppLogger y los Writers: Responsabilidad única
 * AppLogger: Abierto pero cerrado
 * AppLogger. inversión de dependencias. Los módulos
 * de alto nivle son independientes de los detalles de implementación.
 * 
 * */