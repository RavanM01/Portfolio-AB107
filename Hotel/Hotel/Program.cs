using Core.Data;
using Core.Models;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f=false;
            do {
                Console.WriteLine("1-Sisteme giris 0-EXIT");
                string opt0=Console.ReadLine();
                switch (opt0)
                {
                    case "1":
                        Console.WriteLine("1.Hotel yarat 2.Butun Hotelleri gor 3.Hotel sec (hotelin adini daxil ederek secilecek) 0.Exit");
                        opt0 = Console.ReadLine();
                        switch (opt0)
                        {
                            case "1":
                                Console.WriteLine("Hotel adini daxil edin");
                                string hotelName=Console.ReadLine();
                                Hotels hotel = new Hotels(hotelName);
                                break;
                            case "2":
                                Console.WriteLine("nül");
                                break;
                            case "3":
                                Console.WriteLine("1.Room yarat 2.Roomlari gor 3.Rezervasya et 0.Exit");
                                opt0 = Console.ReadLine();
                                switch (opt0)
                                {
                                    case "1":
                                        Console.WriteLine("Name");
                                        string name=Console.ReadLine();
                                        Console.WriteLine("Price");
                                        double price = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Avaliable(yes/no)");
                                        string aval =Console.ReadLine();
                                        bool isaval = false;
                                        if (aval.ToLower() == "yes")
                                        {
                                            isaval = true;
                                        }
                                        Console.WriteLine("Capacity");
                                        int personcapa =int.Parse(Console.ReadLine());
                                        Room room = new Room(name,price,isaval,personcapa);
                                        AppDBContext.AddRoom(room);
                                        break;
                                    case "2":
                                        Console.WriteLine("Otaqlari gormek ucun 1-qiymet/2-musteri sayi/3-otaq adi daxil edin");
                                        string findopt = Console.ReadLine();
                                        switch (findopt)
                                        {
                                            case "1":
                                                Console.WriteLine("price daxil edin");
                                                double allprice=double.Parse(Console.ReadLine());
                                                foreach (var data in AppDBContext.FindAllRoom(allprice))
                                                {
                                                    Console.WriteLine(AppDBContext.FindAllRoom(allprice));
                                                }

                                                break;
                                            case "2":
                                                Console.WriteLine("capacity daxil edin");
                                                int allcapa = int.Parse(Console.ReadLine());
                                                
                                                foreach(var data in AppDBContext.FindAllRoom(allcapa))
                                                {
                                                    Console.WriteLine(AppDBContext.FindAllRoom(allcapa));
                                                }
                                                break;
                                            case "3":
                                                Console.WriteLine("name daxil edin");
                                                string allname = Console.ReadLine();
                                                foreach (var data in AppDBContext.FindAllRoom(allname))
                                                {
                                                    Console.WriteLine(AppDBContext.FindAllRoom(allname));
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("duzgun daxil edin"); break;
                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("Rezerv et (id,person capacity)");
                                        int rezid= int.Parse(Console.ReadLine());
                                        int rezpercap= int.Parse(Console.ReadLine());
                                        AppDBContext.MakeReservation(rezid,rezpercap);
                                        break;
                                    case "0":
                                        f=true;
                                        break;
                                    default:
                                        Console.WriteLine("duzgun daxil edin"); break;
                                }
                                break;
                            case "0":
                                f=true;
                                break;
                            default:
                                Console.WriteLine("duzgun daxil edin"); break;
                        }
                        break;
                    case "0":
                        f = true;
                        break;
                    default: 
                        Console.WriteLine("duzgun daxil edin"); break;
                }

            }while (!f);
        }
    }
}
