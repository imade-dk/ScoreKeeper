using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Core.Entities
{
    public class UserHoleScore
    {
        public Guid UserHoleScoreId { get; set; }
        public Guid UserId { get; set; }
        public Guid CourseHoleId { get; set; }
        public int Strokes { get; set; }

    }
}
