using RazorBakery.Models;
using Microsoft.EntityFrameworkCore;
namespace RazorBakery.Data
{
    public static class ModelBuilderDados
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    Id = 1,
                    Nome = "Bolo de Cenoura",
                    Descricao = "Uma Breve descricao do produto",
                    Preco = 8.99m,
                    NomeImagen = "boloCenoura.jpg"
                },
                new Produto
                {
                    Id = 2,
                    Nome = "Torta de Limão",
                    Descricao = "Uma Breve descricao do produto",
                    Preco = 9.99m,
                    NomeImagen = "tortaLimao.jpg"
                },
                new Produto
                {
                    Id = 3,
                    Nome = "Cupcakes",
                    Descricao = "Uma Breve descricao do produto",
                    Preco = 5.99m,
                    NomeImagen = "cupcakes.jpg"
                },
                new Produto
                {
                    Id = 4,
                    Nome = "Pao",
                    Descricao = "Uma Breve descricao do produto",
                    Preco = 1.49m,
                    NomeImagen = "pao.jpg"
                },
                new Produto
                {
                    Id = 5,
                    Nome = "Torta de Pera",
                    Descricao = " Uma Breve descricao do produto",
                    Preco = 5.99m,
                    NomeImagen = "tortaPera.jpg"
                },
                new Produto
                {
                    Id = 6,
                    Nome = "Bolo de Chocolate ",
                    Descricao = "Uma Breve descricao do produto",
                    Preco = 8.99m,
                    NomeImagen = "boloChocolate.jpg"
                }
            );
            return modelBuilder;
        }
    }
}