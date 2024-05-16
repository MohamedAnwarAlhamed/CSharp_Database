﻿
[Table("Orders", Schema = "Sales")]
public class Order
{
    [Key]
    public int Id { get; set; }
    public string CustomerEmail { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

}

