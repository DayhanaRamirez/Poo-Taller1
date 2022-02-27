namespace Taller1
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return Price + Price * (decimal)Tax;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n       Value......: {$"{ValueToPay():C2}",12}";
        }
    }
}
