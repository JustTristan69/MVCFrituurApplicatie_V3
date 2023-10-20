namespace MVCFrituurApplicatie_V3.Models
{
    public class Register
    {
        //Properties
        public int Id { get; set; }
        public float Total { get; set; }

        //Relationships
        
        public virtual Inventory? Inventory { get; set; }
        public virtual ICollection<Customer>? Customers { get; set; }

        public virtual ICollection<Register>? Registers { get; set; }
    }
}
