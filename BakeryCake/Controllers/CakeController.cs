using BakeryCake.Db;
using BakeryCake.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace BakeryCake.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CakeController : Controller
    {
        private readonly BakeryCakeDbContext _context;
        public CakeController(BakeryCakeDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable> Get()
        {
            return await _context.Cake.ToListAsync();
        }

        [HttpPost]
        public async Task<CakeModel> Post(CakeModel bakery)
        {
            await _context.Cake.AddAsync(bakery);
            await _context.SaveChangesAsync();
            return bakery;
        }

        [HttpGet("{id:int}")]
        public async Task<CakeModel> Get(int id)
        {
            return await _context.Cake.Where(x => x.Id == id).FirstOrDefaultAsync();

        }
    }
}
