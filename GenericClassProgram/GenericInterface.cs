namespace GenericClassProgram
{
    public class Fruit : IComparable<Fruit>
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }

        public int CompareTo(Fruit? other)
        {
            if (other == null)
                return 1;

            return Price.CompareTo(other.Price);
        }
    }

}
