namespace MVCFrituurApplicatie_V3.Models
{
    public class Customer
    {
        //Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }


        //Relatonships
        public int RegisterId { get; set; }
        public virtual Register? Register { get; set; }        
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
