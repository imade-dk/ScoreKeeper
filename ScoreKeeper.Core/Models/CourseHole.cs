using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Core.Models
{
    public class CourseHole
    {
        [Key]
        public Guid CourseHoleId { get; set; }
        [Key]
        public Guid CourseId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Index { get; set; }
        public int Par { get; set; }
        public int Length { get; set; }
    }
}
