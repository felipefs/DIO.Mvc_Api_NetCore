using System.Threading;
using System.Threading.Tasks;
using DIO.Api.Controllers;
using DIO.Mvc.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace DIO.xunit
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;
        
        public CategoriasControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria{Id = 1, Descricao = "Teste Categoria"};

            _mockContext.Setup(m=>m.Categorias).Returns(_mockSet.Object);
            _mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria);

            _mockContext.Setup(m=>m.SetModified(_categoria));
            _mockContext.Setup(m=>m.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);

        }

        [Fact]
        public async Task Get_Categoria(){ 
            var service = new CategoriasController(_mockContext.Object);
            var testCategoria = await service.GetCategoria(1);
            _mockSet.Verify(m=>m.FindAsync(1), Times.Once());
        }
        
        [Fact]
        public async Task Put_Categoria(){ 
            var service = new CategoriasController(_mockContext.Object);
            var testCategoria = await service.PutCategoria(1,_categoria);
            _mockContext.Verify(m=>m.SaveChangesAsync(It.IsAny<CancellationToken>()),Times.Once() );
        }

        [Fact]
        public async Task Post_Categoria(){ 
            var service = new CategoriasController(_mockContext.Object);
            var testCategoria = await service.PostCategoria(_categoria);

            _mockSet.Verify(m=>m.Add(_categoria), Times.Once());
            _mockContext.Verify(m=>m.SaveChangesAsync(It.IsAny<CancellationToken>()),Times.Once() );
        }

        [Fact]
        public async Task Delete_Categoria(){ 
            var service = new CategoriasController(_mockContext.Object);
            var testCategoria = await service.DeleteCategoria(1);

            _mockSet.Verify(m=>m.FindAsync(1), Times.Once());
            _mockSet.Verify(m=>m.Remove(_categoria), Times.Once());
            _mockContext.Verify(m=>m.SaveChangesAsync(It.IsAny<CancellationToken>()),Times.Once() );
        }

    }
}