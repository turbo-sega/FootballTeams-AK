using System.ComponentModel.DataAnnotations;

namespace Data
{
    public abstract class BaseEntity<T>
    {
        [Key]
        public virtual T Id { get; set; }
    }
}