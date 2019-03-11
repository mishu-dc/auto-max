using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMax.Models
{
    [Table("Makes")]
    public class Make
    {
        public int Id { get; set; } 
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }

        public Make()
        {
            this.Models = new Collection<Model>();
        }
    }
}