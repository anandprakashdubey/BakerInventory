using BakerInventory.Db;
using BakerInventory.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace BakerInventory.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BakeryController : Controller
    {
        private readonly BakeryDbContext _context;
        public BakeryController(BakeryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable> Get()
        {
            return await _context.Bakery.ToListAsync();
        }

        [HttpPost]
        public async Task<BakeryModel> Post(BakeryModel bakery)
        {
            await _context.Bakery.AddAsync(bakery);
            await _context.SaveChangesAsync();
            return bakery;
        }

        [HttpGet("{id:int}")]
        public async Task<BakeryModel> Get(int id)
        {
            return await _context.Bakery.Where(x => x.Id == id).FirstOrDefaultAsync();
        
        }
    }
}
