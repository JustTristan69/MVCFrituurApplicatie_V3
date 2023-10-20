namespace MVCFrituurApplicatie_V3.Models
{
    public class Inventory
    {
        //Properties
        public int Id { get; set; }
        public int FoodAmount { get; set; }
        public int? DrinkAmount { get; set; }
        
        //Relationships
        public int? RegisterId { get; set; }
        public virtual Register? Register { get; set; }
    }
}
