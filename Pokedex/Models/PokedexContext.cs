using Microsoft.EntityFrameworkCore;

namespace Pokedex.Models
{
  public class PokedexContext: DbContext
  {
    public PokedexContext(DbContextOptions<PokedexContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Pokemon> Pokemon { get; set; }
    public DbSet<Type> Types { get; set; }
    public DbSet<PokemonType> PokemonTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Pokemon>()
      .HasData(
        new Pokemon { PokemonId = 1, TypeId =1 , Species = "Bulbasaur", Description = "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.", Weight = 6.9, Height = 0.7, ImageMain = "https://coding-assets.s3-us-west-2.amazonaws.com/pokemon/fight/bulbasaur.png", ImageSprite = "https://coding-assets.s3-us-west-2.amazonaws.com/pokemon/sprite/bulbasaur.gif", ImageSilhouette = "https://coding-assets.s3-us-west-2.amazonaws.com/pokemon/silhouette/bulbasaur.png", Hp = 45, Attack = 49, Defense = 49, SpAtk = 65, SpDef = 65, Speed = 45},
      );
    }
  }
}


