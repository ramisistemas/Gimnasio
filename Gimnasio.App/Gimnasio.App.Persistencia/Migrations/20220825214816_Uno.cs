using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gimnasio.App.Persistencia.Migrations
{
    public partial class Uno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsejoNutricionales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsejoNutricionales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dificultades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Basica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Intermedia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avanzado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dificultades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "seguimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaTrabajado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seguimientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValoracionIniciales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoracionIniciales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrenSuperior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrenInferior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abdominal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GluteosPantorrila = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DificultadId = table.Column<int>(type: "int", nullable: true),
                    ValoracionInicialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rutinas_Dificultades_DificultadId",
                        column: x => x.DificultadId,
                        principalTable: "Dificultades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rutinas_ValoracionIniciales_ValoracionInicialId",
                        column: x => x.ValoracionInicialId,
                        principalTable: "ValoracionIniciales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RutinaId = table.Column<int>(type: "int", nullable: true),
                    SeguimientoId = table.Column<int>(type: "int", nullable: true),
                    ConsejoNutricionalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_ConsejoNutricionales_ConsejoNutricionalId",
                        column: x => x.ConsejoNutricionalId,
                        principalTable: "ConsejoNutricionales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Rutinas_RutinaId",
                        column: x => x.RutinaId,
                        principalTable: "Rutinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_seguimientos_SeguimientoId",
                        column: x => x.SeguimientoId,
                        principalTable: "seguimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ConsejoNutricionalId",
                table: "Clientes",
                column: "ConsejoNutricionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_RutinaId",
                table: "Clientes",
                column: "RutinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_SeguimientoId",
                table: "Clientes",
                column: "SeguimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Rutinas_DificultadId",
                table: "Rutinas",
                column: "DificultadId");

            migrationBuilder.CreateIndex(
                name: "IX_Rutinas_ValoracionInicialId",
                table: "Rutinas",
                column: "ValoracionInicialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "ConsejoNutricionales");

            migrationBuilder.DropTable(
                name: "Rutinas");

            migrationBuilder.DropTable(
                name: "seguimientos");

            migrationBuilder.DropTable(
                name: "Dificultades");

            migrationBuilder.DropTable(
                name: "ValoracionIniciales");
        }
    }
}
