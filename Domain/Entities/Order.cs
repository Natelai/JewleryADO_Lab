namespace Domain.Entities
{
    public class Order : BaseModel
    {
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public int GoodId { get; set; }
        public int ClientId { get; set; }
        public virtual Good Good { get; set; }
        public virtual Client Client { get; set; }
    }
}
