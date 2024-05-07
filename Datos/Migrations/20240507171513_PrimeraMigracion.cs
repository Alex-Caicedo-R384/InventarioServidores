using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventarioServidores.Datos.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servidores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEquipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procesadores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caracteristicas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TamanoDiscos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuentesPoder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SistemaOperativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrendado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inversion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servidores");
        }
    }
}
