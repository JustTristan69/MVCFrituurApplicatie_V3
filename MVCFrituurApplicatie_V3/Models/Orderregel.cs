namespace MVCFrituurApplicatie_V3.Models
{
    public class Orderregel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public decimal? ItemPrice { get; set; }
        public int Quantity { get; set; }
        public virtual Order? Orders { get; set; }
        public virtual Item? items { get; set; }
    }
}
