using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class TeamStatistic : BaseEntity<int>
    {
        [Required]
        [ForeignKey("TeamId")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        [Required]
        [ForeignKey("ChampionshipId")]
        public int ChampionshipId { get; set; }
        public Championship Championship { get; set; }

        [Required]
        [StringLength(20)]
        public string Years { get; set; }

        [Required]
        public bool IsChampion { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Team:{TeamId}-{Team?.Name}, Championship:{ChampionshipId}-{Championship?.Name}, Years:{Years}";
        }
    }
}