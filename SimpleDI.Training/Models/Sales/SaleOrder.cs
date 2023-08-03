namespace SimpleDI.Training.Models.Sales
{
    internal class SaleOrder
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Qty { get; set; }
        public decimal Amount { get; set; }
    }
}
