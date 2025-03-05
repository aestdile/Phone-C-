
namespace Phone
{
    class Phone
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public int Storage { get; set; } 
        public int RAM { get; set; } 
        public int FrontCamera { get; set; } 
        public int RearCamera { get; set; }
        public string Company { get; set; }

        public Phone(string model, string color, decimal price, int year, int storage, int ram, int frontCamera, int rearCamera, string company)
        {
            Model = model;
            Color = color;
            Price = price;
            Year = year;
            Storage = storage;
            RAM = ram;
            FrontCamera = frontCamera;
            RearCamera = rearCamera;
            Company = company;
        }

        public string GetModel() => $"Model: {Model}";
        public string GetColor() => $"Color: {Color}";
        public string GetPrice() => $"Price: {Price} USD";
        public string GetYear() => $"Year: {Year}";
        public string GetStorage() => $"Storage: {Storage} GB";
        public string GetRAM() => $"RAM: {RAM} GB";
        public string GetFrontCamera() => $"Front Camera: {FrontCamera} MP";
        public string GetRearCamera() => $"Rear Camera: {RearCamera} MP";
        public string GetCompany() => $"Manufacturer: {Company}";

        public void DisplayInfo()
        {
            Console.WriteLine(GetModel());
            Console.WriteLine(GetColor());
            Console.WriteLine(GetPrice());
            Console.WriteLine(GetYear());
            Console.WriteLine(GetStorage());
            Console.WriteLine(GetRAM());
            Console.WriteLine(GetFrontCamera());
            Console.WriteLine(GetRearCamera());
            Console.WriteLine(GetCompany());
            Console.WriteLine("------------------------------");
        }
    }
}