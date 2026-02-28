namespace SearchLibrary
{
    public class Order
    {
        public int OrderId { get; set; }
        public double Amount { get; set; }

        public Order(int id, double amount)
        {
            OrderId = id;
            Amount = amount;
        }
    }
}