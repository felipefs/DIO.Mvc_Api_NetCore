### Projeto: 

**Projeto .Net Core Mvc com SQL SqlServer**

Site: [Digital Innovation One](http://www.digitalinnovation.one/)

Comandos:

dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator

dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.Extensions.Logging.Debug
export PATH=$HOME/.dotnet/tools:$PATH

https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-5.0&tabs=visual-studio-code

dotnet aspnet-codegenerator --project "DIO.Mvc.csproj" controller --force --controllerName CategoriasController --model DIO.Mvc.Models.Categoria --dataContext DIO.Mvc.Models.Context --relativeFolderPath Controllers --controllerNamespace DIO.Mvc.Controllers --useDefaultLayout

dotnet aspnet-codegenerator --project "DIO.Mvc.csproj" controller --force --controllerName ProdutosController --model DIO.Mvc.Models.Produto --dataContext DIO.Mvc.Models.Context --relativeFolderPath Controllers --controllerNamespace DIO.Mvc.Controllers --useDefaultLayout

dotnet ef migrations add Inicio
dotnet ef database update


https://docs.microsoft.com/pt-br/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio-code

dotnet add DIO.Api.csproj package Swashbuckle.AspNetCore -v 5.6.3

dotnet aspnet-codegenerator --project "DIO.Api/DIO.Api.csproj" controller --force --controllerName CategoriasController --model DIO.Mvc.Models.Categoria --dataContext DIO.Mvc.Models.Context --relativeFolderPath Controllers --controllerNamespace DIO.Api.Controllers -api 

dotnet aspnet-codegenerator --project "DIO.Api/DIO.Api.csproj" controller --force --controllerName ProdutosController --model DIO.Mvc.Models.Produto --dataContext DIO.Mvc.Models.Context --relativeFolderPath Controllers --controllerNamespace DIO.Api.Controllers -api   


http://localhost:5000/swagger/index.html


