using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMovie.Migrations
{
    /// <inheritdoc />
    public partial class addedprofilepicturestonames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_MovieId",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.DropIndex(
                name: "IX_Producers_MovieId",
                table: "Producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KnownFors",
                table: "KnownFors");

            migrationBuilder.DropIndex(
                name: "IX_KnownFors_MovieId",
                table: "KnownFors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_MovieId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Producers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "KnownFors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Directors");

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

            migrationBuilder.AddColumn<string>(
                name: "FaceImageUrl",
                table: "Names",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                columns: new[] { "MovieId", "NameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                columns: new[] { "MovieId", "NameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_KnownFors",
                table: "KnownFors",
                columns: new[] { "MovieId", "NameId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                columns: new[] { "MovieId", "NameId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KnownFors",
                table: "KnownFors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "FaceImageUrl",
                table: "Names");

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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Producers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "KnownFors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Directors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KnownFors",
                table: "KnownFors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_MovieId",
                table: "Roles",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Producers_MovieId",
                table: "Producers",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_KnownFors_MovieId",
                table: "KnownFors",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_MovieId",
                table: "Directors",
                column: "MovieId");
        }
    }
}
