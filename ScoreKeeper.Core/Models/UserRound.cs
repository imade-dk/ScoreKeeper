using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Core.Models
{
    public class UserRound
    {
        public Guid UserRoundId { get; set; }
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
        public double UserHcp { get; set; }
        public DateTime PlayedAt { get; set; } = DateTime.Now;
    }
}
