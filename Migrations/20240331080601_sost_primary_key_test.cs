using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMovie.Migrations
{
    /// <inheritdoc />
    public partial class sost_primary_key_test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Writers",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Writers_MovieId",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Writers");

            migrationBuilder.AlterColumn<int>(
                name: "NameId",
                table: "Writers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Writers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Writers",
                table: "Writers",
                columns: new[] { "MovieId", "NameId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Writers",
                table: "Writers");

            migrationBuilder.AlterColumn<int>(
                name: "NameId",
                table: "Writers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Writers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Writers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Writers",
                table: "Writers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Writers_MovieId",
                table: "Writers",
                column: "MovieId");
        }
    }
}
