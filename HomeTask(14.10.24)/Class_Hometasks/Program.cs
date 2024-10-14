namespace Class_Hometasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car(4, "Chrysler", "c300");
            bmw.ShowFullInfo();
            MotorCycle yamakasi = new MotorCycle(2, "Yamaha", "R9");
            yamakasi.ShowFullInfo();
            NoteBook notebook = new NoteBook("MSI GF65 Thin","Gaming laptop",0,2200, 8, 512);
            notebook.ShowFullData();
            notebook.Sale();
            notebook.ShowFullData();
        }
    }
    class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mile;

        public Vehicle(string Brand,string Model)
        {
            Brand = Brand;
            Model = Model;
        }
    }
    class Car : Vehicle
    {
        public int DoorsNum;


        public Car(int doorsNum,string brand,string model):base(brand,model)
        {
            DoorsNum = doorsNum;
            Brand = brand;
            Model = model;
        }
        public void ShowFullInfo() 
        {
            Console.WriteLine("Qapi sayi: "+DoorsNum+" "+Brand+" "+Model);
        }
    }
    class MotorCycle : Vehicle
    {
        public int WheelNum;
        public MotorCycle(int wheelNum, string brand, string model) : base(brand, model)
        {
            WheelNum = wheelNum;
            Brand = brand;
            Model = model;
        }
        public void ShowFullInfo()
        {
            Console.WriteLine("Teker sayi: "+WheelNum +" "+ Brand +" "+ Model);
        }
    }

    class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

        public Product(string name, string description, int count,double price)
        {
            Name = name;
            Description = description;
            Count = count;
            IsStock = count > 0;
            Price = price;
        }

        public void Sale()
        {
            if (IsStock)
            {
                Count--;
                IsStock = Count > 0;
                Console.WriteLine("Satildi");
            }
            else
            {
                Console.WriteLine("mehsul yoxdur");
            }


        }
    }
    
    class NoteBook : Product
    {
        public byte RAM;
        public int Storage;

        public NoteBook(string name, string description, int count, double price, byte ram, int storage): base(name, description, count,price)
        {
            RAM = ram;
            Storage = storage;
        }
        public string GetFullInfo()
        {
            return $"Name: {Name}, Description: {Description}, RAM: {RAM}GB, Storage: {Storage}GB, Price: {Price}, Count: {Count}, In Stock: {IsStock}";
        }

        public void ShowFullData()
        {
            if (IsStock)
            {
                Console.WriteLine(GetFullInfo());
            }
            else
            {
                Console.WriteLine("Mehsul yoxdur");
            }
        }
    }


}
