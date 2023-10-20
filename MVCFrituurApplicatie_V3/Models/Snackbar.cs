namespace MVCFrituurApplicatie_V3.Models
{
    public class Snackbar
    {
        //Properties
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Location { get; set; }

        //Relationships
        public virtual ICollection<Owner>? Owners { get; }
    }
}
