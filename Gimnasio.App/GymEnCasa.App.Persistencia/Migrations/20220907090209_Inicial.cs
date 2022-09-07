using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymEnCasa.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaNutricionales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaNutricionales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DificultadEjercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DificultadEjercicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCuerpos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuerpos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZonaTrabajos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonaTrabajos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelefonico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ValoracionIniciales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoracionIniciales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValoracionIniciales_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsejoNutricionales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCuerpoId = table.Column<int>(type: "int", nullable: true),
                    CategoriaNutricionalId = table.Column<int>(type: "int", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsejoNutricionales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsejoNutricionales_CategoriaNutricionales_CategoriaNutricionalId",
                        column: x => x.CategoriaNutricionalId,
                        principalTable: "CategoriaNutricionales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsejoNutricionales_TipoCuerpos_TipoCuerpoId",
                        column: x => x.TipoCuerpoId,
                        principalTable: "TipoCuerpos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RutinasEjercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZonaTrabajoId = table.Column<int>(type: "int", nullable: true),
                    DificultadEjercicioId = table.Column<int>(type: "int", nullable: true),
                    NombreEjercicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionEjercicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AyudaMultimedia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutinasEjercicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RutinasEjercicios_DificultadEjercicios_DificultadEjercicioId",
                        column: x => x.DificultadEjercicioId,
                        principalTable: "DificultadEjercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RutinasEjercicios_ZonaTrabajos_ZonaTrabajoId",
                        column: x => x.ZonaTrabajoId,
                        principalTable: "ZonaTrabajos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ValoracionNutricionalClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    TipoCuerpoId = table.Column<int>(type: "int", nullable: true),
                    estatura = table.Column<float>(type: "real", nullable: false),
                    peso = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoracionNutricionalClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValoracionNutricionalClientes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ValoracionNutricionalClientes_TipoCuerpos_TipoCuerpoId",
                        column: x => x.TipoCuerpoId,
                        principalTable: "TipoCuerpos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ValoracionRutinasClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    DificultadEjercicioId = table.Column<int>(type: "int", nullable: true),
                    estatura = table.Column<float>(type: "real", nullable: false),
                    peso = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoracionRutinasClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValoracionRutinasClientes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ValoracionRutinasClientes_DificultadEjercicios_DificultadEjercicioId",
                        column: x => x.DificultadEjercicioId,
                        principalTable: "DificultadEjercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    RutinasEjercicioId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Historicos_RutinasEjercicios_RutinasEjercicioId",
                        column: x => x.RutinasEjercicioId,
                        principalTable: "RutinasEjercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_GeneroId",
                table: "Clientes",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsejoNutricionales_CategoriaNutricionalId",
                table: "ConsejoNutricionales",
                column: "CategoriaNutricionalId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsejoNutricionales_TipoCuerpoId",
                table: "ConsejoNutricionales",
                column: "TipoCuerpoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_ClienteId",
                table: "Historicos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_RutinasEjercicioId",
                table: "Historicos",
                column: "RutinasEjercicioId");

            migrationBuilder.CreateIndex(
                name: "IX_RutinasEjercicios_DificultadEjercicioId",
                table: "RutinasEjercicios",
                column: "DificultadEjercicioId");

            migrationBuilder.CreateIndex(
                name: "IX_RutinasEjercicios_ZonaTrabajoId",
                table: "RutinasEjercicios",
                column: "ZonaTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_ValoracionIniciales_GeneroId",
                table: "ValoracionIniciales",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_ValoracionNutricionalClientes_ClienteId",
                table: "ValoracionNutricionalClientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ValoracionNutricionalClientes_TipoCuerpoId",
                table: "ValoracionNutricionalClientes",
                column: "TipoCuerpoId");

            migrationBuilder.CreateIndex(
                name: "IX_ValoracionRutinasClientes_ClienteId",
                table: "ValoracionRutinasClientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ValoracionRutinasClientes_DificultadEjercicioId",
                table: "ValoracionRutinasClientes",
                column: "DificultadEjercicioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsejoNutricionales");

            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "ValoracionIniciales");

            migrationBuilder.DropTable(
                name: "ValoracionNutricionalClientes");

            migrationBuilder.DropTable(
                name: "ValoracionRutinasClientes");

            migrationBuilder.DropTable(
                name: "CategoriaNutricionales");

            migrationBuilder.DropTable(
                name: "RutinasEjercicios");

            migrationBuilder.DropTable(
                name: "TipoCuerpos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "DificultadEjercicios");

            migrationBuilder.DropTable(
                name: "ZonaTrabajos");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
