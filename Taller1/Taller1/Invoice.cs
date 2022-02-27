namespace Taller1
{
    public class Invoice : IPay
    {
        private List<Product> _products = new List<Product>();

        public Invoice()
        {

        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal totalValue = 0;

            foreach (Product product in _products)
            {
                totalValue += product.ValueToPay();
            }

            return totalValue;
        }

        public override string ToString()
        {
            string productsDetails = "";

            foreach (Product product in _products)
            {
                productsDetails += "\n" + product.ToString();
            }

            return  $"\nRECEIPT" +
                    $"\n-------------------------------------------------" +
                    $"{productsDetails}" +
                    $"\n                    ============" +
                    $"\n  TOTAL...........: {$"{ValueToPay():C2}",12}";
        }
    }
}


