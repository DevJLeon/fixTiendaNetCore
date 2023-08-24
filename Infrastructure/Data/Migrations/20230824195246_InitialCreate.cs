using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    CodPais = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePais = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.CodPais);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoPersonas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersonas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    CodEstado = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEstado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodPais = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPais = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisCodPais = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.CodEstado);
                    table.ForeignKey(
                        name: "FK_Estados_Paises_PaisCodPais",
                        column: x => x.PaisCodPais,
                        principalTable: "Paises",
                        principalColumn: "CodPais");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Regiones",
                columns: table => new
                {
                    CodRegion = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreRegion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoCodEstado = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiones", x => x.CodRegion);
                    table.ForeignKey(
                        name: "FK_Regiones_Estados_EstadoCodEstado",
                        column: x => x.EstadoCodEstado,
                        principalTable: "Estados",
                        principalColumn: "CodEstado");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApellidosPersona = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailPersona = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersona = table.Column<int>(type: "int", nullable: true),
                    TipoPersonaId = table.Column<int>(type: "int", nullable: true),
                    IdRegion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegionCodRegion = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                    table.ForeignKey(
                        name: "FK_Personas_Regiones_RegionCodRegion",
                        column: x => x.RegionCodRegion,
                        principalTable: "Regiones",
                        principalColumn: "CodRegion");
                    table.ForeignKey(
                        name: "FK_Personas_TipoPersonas_TipoPersonaId",
                        column: x => x.TipoPersonaId,
                        principalTable: "TipoPersonas",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonaProductos",
                columns: table => new
                {
                    IdPersona = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaProductos", x => new { x.IdPersona, x.IdProducto });
                    table.ForeignKey(
                        name: "FK_PersonaProductos_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonaProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_PaisCodPais",
                table: "Estados",
                column: "PaisCodPais");

            migrationBuilder.CreateIndex(
                name: "IX_PersonaProductos_ProductoId",
                table: "PersonaProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EmailPersona",
                table: "Personas",
                column: "EmailPersona",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_RegionCodRegion",
                table: "Personas",
                column: "RegionCodRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TipoPersonaId",
                table: "Personas",
                column: "TipoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Regiones_EstadoCodEstado",
                table: "Regiones",
                column: "EstadoCodEstado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonaProductos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Regiones");

            migrationBuilder.DropTable(
                name: "TipoPersonas");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
