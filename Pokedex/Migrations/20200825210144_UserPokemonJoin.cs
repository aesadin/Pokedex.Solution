using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class UserPokemonJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Users_UserId",
                table: "Pokemon");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_UserId",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Pokemon");

            migrationBuilder.CreateTable(
                name: "UserPokemon",
                columns: table => new
                {
                    UserPokemonId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    PokemonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPokemon", x => x.UserPokemonId);
                    table.ForeignKey(
                        name: "FK_UserPokemon_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "PokemonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPokemon_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPokemon_PokemonId",
                table: "UserPokemon",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPokemon_UserId",
                table: "UserPokemon",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPokemon");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Pokemon",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_UserId",
                table: "Pokemon",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Users_UserId",
                table: "Pokemon",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
