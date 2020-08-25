namespace Pokedex.Models
{
  public class UserPokemon
  {
    public int UserPokemonId { get; set; }
    public int UserId { get; set; }
    public int PokemonId { get; set; }
    public User User { get; set; }
    public Pokemon Pokemon { get; set; }
  }
}