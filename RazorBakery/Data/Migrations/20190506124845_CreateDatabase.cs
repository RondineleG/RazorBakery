using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorBakery.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Preco = table.Column<decimal>(nullable: false),
                    ImageFileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome", "ImageFileName", "Preco" },
                values: new object[] { 1, "Uma Breve descricao do produto", "Bolo de Cenoura", "boloCenoura.jpg", 8.99m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome", "ImageFileName", "Preco" },
                values: new object[] { 2, "Uma Breve descricao do produto", "Torta de Limão", "tortaLimao.jpg", 9.99m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome", "ImageFileName", "Preco" },
                values: new object[] { 3, "Uma Breve descricao do produto", "Cupcakes", "cupcakes.jpg", 5.99m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome", "ImageFileName", "Preco" },
                values: new object[] { 4, "Uma Breve descricao do produto", "Pao", "pao.jpg", 1.49m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome", "ImageFileName", "Preco" },
                values: new object[] { 5, " Uma Breve descricao do produto", "Torta de Pera", "tortaPera.jpg", 5.99m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Descricao", "Nome", "ImageFileName", "Preco" },
                values: new object[] { 6, "Uma Breve descricao do produto", "Bolo de Chocolate ", "boloChocolate.jpg", 8.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
