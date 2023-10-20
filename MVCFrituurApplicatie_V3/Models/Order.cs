namespace MVCFrituurApplicatie_V3.Models
{
    public class Order
    {
        //Poperties
        public int Id { get; set; }

        //Relationships
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public int OrderregelId { get; set; }
        public virtual ICollection<Orderregel>? Orderregels { get; set; }
    }
}
