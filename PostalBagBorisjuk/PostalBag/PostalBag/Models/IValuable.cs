namespace PostalBag.Models
{
    public interface IValuable
    {
        public double Value { get; set; }

        public string ToString();
    }
}