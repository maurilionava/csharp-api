using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CATEGORIAS(Nome, ImagemUrl) VALUES('Eletrônicos','imagens/categorias/eletronicos.png');");
            migrationBuilder.Sql("INSERT INTO CATEGORIAS(Nome, ImagemUrl) VALUES('Livros','imagens/categorias/livros.png');");
            migrationBuilder.Sql("INSERT INTO CATEGORIAS(Nome, ImagemUrl) VALUES('Games','imagens/categorias/games.png');");
            migrationBuilder.Sql("INSERT INTO CATEGORIAS(Nome, ImagemUrl) VALUES('Casa e Cozinha','imagens/categorias/casa-cozinha.png');");
            migrationBuilder.Sql("INSERT INTO CATEGORIAS(Nome, ImagemUrl) VALUES('Esportes','imagens/categorias/esportes.png');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CATEGORIAS");
        }
    }
}
