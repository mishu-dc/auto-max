using System.Collections.Generic;
using System.Linq;
using AutoMax.Models;

namespace AutoMax.Dto
{
    public class MakeDto
    {
        public MakeDto(Make make)
        {
            this.Id = make.Id;
            this.Name = make.Name;
            this.Models = make.Models.Select(m=> new ModelDto(){ Name = m.Name, Id = m.Id });
        }
        public int Id { get; set; } 
        public string Name { get; set; }

        public IEnumerable<ModelDto> Models { get; set; }
    }
}