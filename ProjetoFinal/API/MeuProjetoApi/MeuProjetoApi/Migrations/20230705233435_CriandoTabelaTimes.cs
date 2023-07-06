using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuProjetoApi.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaTimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Divisao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NomeTecnico = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Time");
        }
    }
}
