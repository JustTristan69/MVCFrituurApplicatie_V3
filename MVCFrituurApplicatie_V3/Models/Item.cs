using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFrituurApplicatie_V3.Models
{
    public class Item
    {
        //Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        
        //Relationships
        public int? OrderregelId { get; set; }
        public virtual ICollection<Orderregel>? Orderregels { get; set; }


    }
}
