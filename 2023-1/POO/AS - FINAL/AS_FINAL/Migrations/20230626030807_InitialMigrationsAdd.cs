using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AS_FINAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationsAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "livros",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    telefone = table.Column<string>(type: "varchar(15)", nullable: false),
                    documento = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "autores",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    telefone = table.Column<string>(type: "varchar(20)", nullable: false),
                    LivroId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Livro_Autores",
                        column: x => x.LivroId,
                        principalTable: "livros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "emprestimos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data_emprestimo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    data_devolucao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    LivroId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emprestimos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Usuario_Empresta_Livros",
                        column: x => x.UsuarioId,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_emprestimos_livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "livros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_autores_LivroId",
                table: "autores",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_emprestimos_LivroId",
                table: "emprestimos",
                column: "LivroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_emprestimos_UsuarioId",
                table: "emprestimos",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "autores");

            migrationBuilder.DropTable(
                name: "emprestimos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "livros");
        }
    }
}
