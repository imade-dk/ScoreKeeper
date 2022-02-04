using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeeper.Core.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        [Required]
        public string GolfId { get; set; } = string.Empty;
        public double Hcp { get; set; } = 54;

    }
}
