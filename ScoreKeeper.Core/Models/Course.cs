using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Core.Models
{
    public class Course

    {
        public Guid CourseId { get; set; }
        public Guid CourseEstateId { get; set; }
        public bool Active { get; set; } = true;
        public string Name { get; set; } = string.Empty;
        public double Slope { get; set; }
        public double CourseRating { get; set; }
        public int Length { get; set; }
        public IEnumerable<CourseHole> CourseHoles { get; set; } = new List<CourseHole>();

    }
}
