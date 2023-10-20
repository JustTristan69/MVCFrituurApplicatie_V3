namespace MVCFrituurApplicatie_V3.Models
{
    public class Owner
    {
        //Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? OwnerUsername { get; set; }
        public string? OwnerPassword { get; set; }
       
        
        //Relationships
        public virtual Snackbar? Snackbar { get; set; }
        public virtual ICollection<Register>? Registers { get; set; }
    }
}
