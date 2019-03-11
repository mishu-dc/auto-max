using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMax.Dto;
using AutoMax.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoMax.Controllers
{
    public class MakeController : Controller
    {
        private readonly AutoMaxDbContext context;
        public MakeController(AutoMaxDbContext context)
        {
            this.context = context;
        }
        
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeDto>> GetMakes(){
            var makes = await this.context.Makes.Include(m=>m.Models).ToListAsync();
            var makeDtos = makes.Select(m=> new MakeDto(m){});

            return makeDtos;
        }
    }
}