using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudUsuario.Migrations
{
    public partial class primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(60)", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(60)", nullable: false),
                    Identificacion = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Edad = table.Column<decimal>(type: "numeric(2,0)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maneja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lentes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diabetico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enfermedades = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS_4544DWF", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
