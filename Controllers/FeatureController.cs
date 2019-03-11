using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMax.Dto;
using AutoMax.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoMax.Controllers
{
    public class FeatureController:Controller
    {
        private readonly AutoMaxDbContext context;

        public FeatureController(AutoMaxDbContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureDto>> GetFeatures(){
            var features = await this.context.Features.ToListAsync();
            var featureDtos = features.Select(f=>new FeatureDto(){ Id = f.Id, Name= f.Name});

            return featureDtos;
        }
    }
}