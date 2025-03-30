namespace Car.Model
{
    public class BrandCar
    {
        public Guid RowPointer { get; set; } = Guid.NewGuid();
        public string Brand { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }

        public BrandCar(string Brandd,string Namee, int quantityy)
        {
            this.Brand= Brandd;
            this.Name = Namee;
            this.quantity = quantityy;
        }
    }
}
