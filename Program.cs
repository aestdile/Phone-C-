
namespace Phone
{
    class Program
    {
        static void Main()
        {
            Phone phone1 = new Phone("Samsung S25 Ultra", "Black", 1299.99m, 2025, 512, 12, 40, 200, "Samsung");
            Phone phone2 = new Phone("iPhone 16 Pro Max", "Silver", 1599.99m, 2025, 512, 12, 48, 108, "Apple");
            Phone phone3 = new Phone("Redmi 14 Pro", "Blue", 699.99m, 2025, 256, 8, 32, 108, "Xiaomi");

            Console.WriteLine("Phone Details:\n");
            phone1.DisplayInfo();
            phone2.DisplayInfo();
            phone3.DisplayInfo();
        }
    }
}
