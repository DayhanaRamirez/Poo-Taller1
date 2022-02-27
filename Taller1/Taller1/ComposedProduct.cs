namespace Taller1
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal totalValue = 0;

            foreach (Product product in Products)
            {
                totalValue += product.ValueToPay();
            }

            return totalValue - totalValue * (decimal)Discount;
        }

        public override string ToString()
        {
            string names = "";

            foreach (Product product in Products)
            {
                names += product.Description + ", ";
            }

            return  $"  {Id} {Description} " +
                    $"\n       Products...: {$"{names}",12}" +
                    $"\n       Discount...: {$"{Discount:P2}",12}" +
                    $"\n       Value......: {$"{ValueToPay():C2}",12}";
        }
    }
}
