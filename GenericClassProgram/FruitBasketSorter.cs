namespace GenericClassProgram
{
    public class FruitBasket<T> where T : IComparable<T>
    {
        public List<T> Fruits { get; } = new List<T>();

        public void SortFruits()
        {
            Fruits.Sort();
        }
    }

}
