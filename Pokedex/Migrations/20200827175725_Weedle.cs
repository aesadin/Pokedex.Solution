using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class Weedle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 13,
                column: "ImageSprite",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/pokemon/sprite/weedle-2.gif");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 13,
                column: "ImageSprite",
                value: "https://coding-assets.s3-us-west-2.amazonaws.com/pokemon/sprite/weedle.png");
        }
    }
}
