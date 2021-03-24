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

dotnet aspnet-codegenerator --project "DIO.Mvc.csproj" controller --force --controllerName CategoriasController --model DIO.mvc.Models.Categoria --dataContext DIO.mvc.Models.Context --relativeFolderPath Controllers --controllerNamespace DIO.mvc.Controllers --useDefaultLayout

dotnet aspnet-codegenerator --project "DIO.Mvc.csproj" controller --force --controllerName ProdutosController --model DIO.mvc.Models.Produto --dataContext DIO.mvc.Models.Context --relativeFolderPath Controllers --controllerNamespace DIO.mvc.Controllers --useDefaultLayout

dotnet ef migrations add Inicio
dotnet ef database update



