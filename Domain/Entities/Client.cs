﻿namespace Domain.Entities
{
    public class Client : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public virtual List<Order>? Orders { get; set; }
    }
}
