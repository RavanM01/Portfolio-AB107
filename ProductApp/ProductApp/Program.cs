namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool f = true;
            Store store = new Store();
            do
            {
                Console.WriteLine("1-Add Product\n2-Remove Product\n3-Get Product\n4-Filter Product(By Type)\n5-Filter Product(By Name)");
                string chose = Console.ReadLine();

                switch (chose)
                {

                    case "1":
                        string name = Console.ReadLine();
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("1-Baker,2-Drink,3-Meat,4-Diary");
                        int typeValue = Convert.ToInt32(Console.ReadLine());
                        try
                        {

                            if (typeValue == 1)
                            {
                                Product product1 = new Product(name, price, Type.Baker);
                                store.AddProduct(product1);
                            }
                            else if (typeValue == 2)
                            {
                                Product product1 = new Product(name, price, Type.Drink);
                                store.AddProduct(product1);
                            }
                            else if (typeValue == 3)
                            {
                                Product product1 = new Product(name, price, Type.Meat);
                                store.AddProduct(product1);

                            }
                            else if (typeValue == 4)
                            {
                                Product product1 = new Product(name, price, Type.Diary);
                                store.AddProduct(product1);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        //var type=Enum.GetName(typeof(Type), typeValue);
                        //Console.WriteLine(type);

                        break;
                    case "2":
                        int no = Convert.ToInt32(Console.ReadLine());
                        store.RemoveProductByNo(no);
                        break;
                    case "3":
                        int no2 = Convert.ToInt32(Console.ReadLine());
                        store.GetProduct(no2);
                        break;
                    case "4":
                        Console.WriteLine("1-Baker,2-Drink,3-Meat,4-Diary");               
                        int typeval=Convert.ToInt32(Console.ReadLine());
                        if (typeval==1)
                        {
                        store.FilterProductsByType(Type.Baker);
                        }
                        if (typeval == 2)
                        {
                            store.FilterProductsByType(Type.Drink);
                        }
                        if (typeval == 3)
                        {
                            store.FilterProductsByType(Type.Meat);
                        }
                        if (typeval == 4)
                        {
                            store.FilterProductsByType(Type.Diary);
                        }
                        break;
                    case "5":
                        string name2 = Console.ReadLine();
                        store.FilterProductsByName(name2);
                        break;
                }



            } while (f);




        }
    }
}
