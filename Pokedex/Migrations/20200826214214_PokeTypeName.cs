using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokedex.Migrations
{
    public partial class PokeTypeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PokeTypeName",
                table: "Pokemon",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 1,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 2,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 3,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 4,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 5,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 6,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 7,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 8,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 9,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 10,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 11,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 12,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 13,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 14,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 15,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 16,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 17,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 18,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 19,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 20,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 21,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 22,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 23,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 24,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 25,
                column: "PokeTypeName",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 26,
                column: "PokeTypeName",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 27,
                column: "PokeTypeName",
                value: "Ground");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 28,
                column: "PokeTypeName",
                value: "Ground");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 29,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 30,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 31,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 32,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 33,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 34,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 35,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 36,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 37,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 38,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 39,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 40,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 41,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 42,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 43,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 44,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 45,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 46,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 47,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 48,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 49,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 50,
                column: "PokeTypeName",
                value: "Ground");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 51,
                column: "PokeTypeName",
                value: "Ground");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 52,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 53,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 54,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 55,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 56,
                column: "PokeTypeName",
                value: "Fighting");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 57,
                column: "PokeTypeName",
                value: "Fighting");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 58,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 59,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 60,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 61,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 62,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 63,
                column: "PokeTypeName",
                value: "Psychic");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 64,
                column: "PokeTypeName",
                value: "Psychic");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 65,
                column: "PokeTypeName",
                value: "Psychic");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 66,
                column: "PokeTypeName",
                value: "Fighting");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 67,
                column: "PokeTypeName",
                value: "Fighting");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 68,
                column: "PokeTypeName",
                value: "Fighting");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 69,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 70,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 71,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 72,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 73,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 74,
                column: "PokeTypeName",
                value: "Rock");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 75,
                column: "PokeTypeName",
                value: "Rock");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 76,
                column: "PokeTypeName",
                value: "Rock");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 77,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 78,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 79,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 80,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 81,
                column: "PokeTypeName",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 82,
                column: "PokeTypeName",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 83,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 84,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 85,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 86,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 87,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 88,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 89,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 90,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 91,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 92,
                column: "PokeTypeName",
                value: "Ghost");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 93,
                column: "PokeTypeName",
                value: "Ghost");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 94,
                column: "PokeTypeName",
                value: "Ghost");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 95,
                column: "PokeTypeName",
                value: "Rock");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 96,
                column: "PokeTypeName",
                value: "Psychic");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 97,
                column: "PokeTypeName",
                value: "Psychic");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 98,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 99,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 100,
                column: "PokeTypeName",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 101,
                column: "PokeTypeName",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 102,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 103,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 104,
                column: "PokeTypeName",
                value: "Ground");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 105,
                column: "PokeTypeName",
                value: "Ground");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 106,
                column: "PokeTypeName",
                value: "Fighting");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 107,
                column: "PokeTypeName",
                value: "Fighting");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 108,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 109,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 110,
                column: "PokeTypeName",
                value: "Poison");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 111,
                column: "PokeTypeName",
                value: "Ground");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 112,
                column: "PokeTypeName",
                value: "Ground");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 113,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 114,
                column: "PokeTypeName",
                value: "Grass");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 115,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 116,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 117,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 118,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 119,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 120,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 121,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 122,
                column: "PokeTypeName",
                value: "Psychic");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 123,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 124,
                column: "PokeTypeName",
                value: "Ice");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 125,
                column: "PokeTypeName",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 126,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 127,
                column: "PokeTypeName",
                value: "Bug");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 128,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 129,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 130,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 131,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 132,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 133,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 134,
                column: "PokeTypeName",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 135,
                column: "PokeTypeName",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 136,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 137,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 138,
                column: "PokeTypeName",
                value: "Rock");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 139,
                column: "PokeTypeName",
                value: "Rock");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 140,
                column: "PokeTypeName",
                value: "Rock");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 141,
                column: "PokeTypeName",
                value: "Rock");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 142,
                column: "PokeTypeName",
                value: "Rock");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 143,
                column: "PokeTypeName",
                value: "Normal");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 144,
                column: "PokeTypeName",
                value: "Ice");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 145,
                column: "PokeTypeName",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 146,
                column: "PokeTypeName",
                value: "Fire");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 147,
                column: "PokeTypeName",
                value: "Dragon");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 148,
                column: "PokeTypeName",
                value: "Dragon");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 149,
                column: "PokeTypeName",
                value: "Dragon");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 150,
                column: "PokeTypeName",
                value: "Psychic");

            migrationBuilder.UpdateData(
                table: "Pokemon",
                keyColumn: "PokemonId",
                keyValue: 151,
                column: "PokeTypeName",
                value: "Psychic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PokeTypeName",
                table: "Pokemon");
        }
    }
}
