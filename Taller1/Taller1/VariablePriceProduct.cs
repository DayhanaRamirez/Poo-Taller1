namespace Taller1
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return (decimal)Quantity * (Price + Price * (decimal)Tax);
        }

        public override string ToString()
        {
         return $"  {Id} {Description} " +
                $"\n       Measurement: {$"{Measurement}",12}" +
                $"\n       Quantity...: {$"{Quantity:N2}",12}" +
                $"\n       Price......: {$"{Price:C2}",12}" +
                $"\n       Tax........: {$"{Tax:P2}",12}" +
                $"\n       Value......: {$"{ValueToPay():C2}",12}";
        }
    }
}
