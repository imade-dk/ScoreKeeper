using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Core.Models
{
    public class CourseEstate
    {
        [Key]
        public Guid CourseEstateId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
