using MovieInfoEF.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoEF.Domain.Models
{
    public class Genres : BaseEntity
    {
        [MaxLength(32)]
        public string Name { get; set; } = String.Empty;
    }
}
