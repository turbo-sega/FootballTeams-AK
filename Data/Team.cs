using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Team : BaseEntity<int>
    {
        public Team()
        {
            Players = new HashSet<Player>();
        }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [StringLength(100)]
        public string Country { get; set; }
        
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(500)]
        public string Coaches { get; set; }

        [StringLength(2000)]
        public string History { get; set; }

        [Required]
        [StringLength(50)]
        public string GameScheme { get; set; }
        
        public virtual ICollection<Player> Players { get; set; }

        public override string ToString()
        {
            return $"{Name} ({City}, {Country})";
        }
    }
}