using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoptionLab.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Species = table.Column<string>(type: "varchar(20)", nullable: false),
                    Breed = table.Column<string>(type: "varchar(20)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Pets",
                newName: "Image");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Pets",
                newName: "Img");
        }
    }
}
