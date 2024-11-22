using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GSNet24.Migrations
{
    /// <inheritdoc />
    public partial class AddAparelho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APARELHO_NET",
                columns: table => new
                {
                    ID_APARELHO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NOME_APARELHO = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    TEMPO_UTILIZADO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APARELHO_NET", x => x.ID_APARELHO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APARELHO_NET");
        }
    }
}
