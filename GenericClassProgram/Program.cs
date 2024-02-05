namespace GenericClassProgram
{
    class Program
    {
        static void Main()
        {
            // Example with generic type parameter <T>
            Basket<string> stringBasket = new Basket<string>();
            stringBasket.Fruits.Add("Apple");
            stringBasket.Fruits.Add("Banana");

            // Example with generic interface IComparable<T>
            Fruit apple = new Fruit { Name = "Apple", Price = 2 };
            Fruit banana = new Fruit { Name = "Banana", Price = 1 };

            Console.WriteLine($"Comparison result: {apple.CompareTo(banana)}");

            // Example combining <T> and IComparable<T>
            FruitBasket<Fruit> fruitBasket = new FruitBasket<Fruit>();
            fruitBasket.Fruits.Add(apple);
            fruitBasket.Fruits.Add(banana);

            // Sorting fruits based on their prices
            fruitBasket.SortFruits();

            // Displaying sorted fruits
            Console.WriteLine("Sorted Fruits:");
            foreach (var fruit in fruitBasket.Fruits)
            {
                Console.WriteLine($"Name: {fruit.Name}, Price: {fruit.Price}");
            }
        }
    }
}
