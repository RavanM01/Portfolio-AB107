namespace Galaxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country cty1 = new Country("Aze",86.6,"AZERI TORPAGININ HAMIMIZ OVLADIYIQ",Region.Antarktida);
            AppDbContext.CreateCountry(cty1);
            AppDbContext.GetCountryByRegion(Region.Antarktida);
            bool f = false;
            do
            {
                Console.WriteLine("1-sisteme giris 2- Exit");
                string opt0=Console.ReadLine();
                switch (opt0)
                {
                    case "0":
                        f = true;
                        break;
                    case "1":
                        Console.WriteLine();
                        opt0 = Console.ReadLine();

                        switch (opt0)
                        {
                            case "1":
                                Console.WriteLine("planet yarat");
                                break;
                            case "2":
                                Console.WriteLine("ALl planetleri gor");
                                break;
                            case "3":
                                Console.WriteLine("planet sec");
                                opt0 = Console.ReadLine();
                                switch (opt0)
                                {
                                    case "1":
                                        Console.WriteLine("olke yarat");
                                        break;
                                    case "2":
                                        Console.WriteLine("olke gor");
                                        break;
                                    case "3":
                                        Console.WriteLine("EVVELKI MENYUYA QAYIT");
                                        break;
                                    case "0":
                                        Console.WriteLine("EXIT");
                                        break;
                                }
                                break;
                            case "0":
                                break;
                        }
                        break;

                }


            } while (!f);
        }
    }
}
