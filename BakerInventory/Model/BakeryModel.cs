namespace BakerInventory.Model
{
    public class BakeryModel
    {
        public int Id { get; set; }
        public string BakeOrderName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double FinalAmount { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<CakeModel> CakeItems { get; set; }
        public bool IsActive { get; set; }

    }
}
