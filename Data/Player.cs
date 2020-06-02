using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Player : BaseEntity<int>
    {
        [Required]
        [ForeignKey("TeamId")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Number { get; set; }
        
        [StringLength(100)]
        public string Position { get; set; }

        public override string ToString()
        {
            var positionPart = string.IsNullOrWhiteSpace(Position) ? "" : $" {Position}";
            return $"{Number} {Name}{positionPart}";
        }
    }
}