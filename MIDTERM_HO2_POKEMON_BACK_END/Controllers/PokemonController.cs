using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MIDTERM_HO2_POKEMON_BACK_END.db;
using MIDTERM_HO2_POKEMON_BACK_END.models;

namespace MIDTERM_HO2_POKEMON_BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PokemonController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        // GET: api/Pokemon
        //get all pokemon
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetAllPokemon()
        {
            

            var pokemons = await _context.Pokemon.ToListAsync();
            return Ok(pokemons);
        }

        // GET: api/Pokemon/5 
        //get pokemon by id
        [HttpGet("{id}")]
        public async Task<ActionResult<Pokemon>> GetPokemonById(int id)
        {
            var pokemon = await _context.Pokemon.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();

            }
            return Ok(pokemon);
        }

        [HttpPost]
        public async Task<ActionResult<Pokemon>> CreatePokemon(Pokemon pokemon)
        {
            _context.Pokemon.Add(pokemon);
            await _context.SaveChangesAsync();
            return Ok("");
            //return CreatedAtAction(nameof(GetPokemonById), new { id = pokemon.Id }, pokemon);

        }
    }
}
