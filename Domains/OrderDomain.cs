namespace gas_stationDomain
{
    public class Order
    {
        public int OrderId { get; set; }
        public float OrderPrice { get; set; }
        public Client Client { get; set; }
        public byte Payment { get; set; }
    }
}
