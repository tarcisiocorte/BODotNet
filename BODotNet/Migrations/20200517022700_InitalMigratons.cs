using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BODotNet.Migrations
{
    public partial class InitalMigratons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    Fantasia = table.Column<string>(nullable: true),
                    CNPJ = table.Column<string>(nullable: true),
                    CNPJCompleto = table.Column<string>(nullable: true),
                    IE = table.Column<string>(nullable: true),
                    Logradouro = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: true),
                    Telefone1 = table.Column<string>(nullable: true),
                    Telefone2 = table.Column<string>(nullable: true),
                    email1 = table.Column<string>(nullable: true),
                    email2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
