using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Championship : BaseEntity<int>
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [StringLength(100)]
        public string Country { get; set; }

        [Required]
        public bool IsNational { get; set; }

        public override string ToString()
        {
            var suffix = IsNational ? $" ({Country})" : "";
            return $"{Name}{suffix}";
        }
    }
}