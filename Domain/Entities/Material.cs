namespace Domain.Entities
{
    public class Material : BaseModel
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Price { get; set; }
        public virtual List<Good>? Goods { get; set; }
    }
}
