using System.Linq.Expressions;
using WeaponTask;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WeaponTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menunav = true;
            Weapon akm = new Weapon(40,30,true);
            Console.WriteLine("Weapon app");
            do
            {
        

                Console.WriteLine("0 - İnformasiya almaq üçün 1 - Shoot metodu üçün 2 - GetRemainBulletCount metodu üçün 3 - Reload metodu üçün 4 - ChangeFireMode metodu üçün 5 - Proqramdan dayandırmaq üçün qısayoldur 6 - Yeni menyuya kecid edir.");
                string menus = Console.ReadLine();

            



                switch (menus)
                {
                     
                    case "0":
                        Console.WriteLine($"Bullet Capacity: {akm.Bulletcapacity} Number of bullet:{akm.Numberofbullet} Shoot Mode:{akm.Shootmode} ");                       
                        break;
                    case "1":
                        Weapon.Shoot(akm);
                        break;
                    case "2":
                        Weapon.GetRemainBulletCount(akm);
                        break;
                    case "3":
                        Weapon.Reload(akm);
                        break;
                    case "4":
                        Weapon.ChangeFireMode(akm);
                        break;
                    case "5":
                        menunav =false;
                        break;
                    case "6":
                        Console.WriteLine("Optional Menu: 7 - Tutumu dəyişsin 8 - Güllə sayı deyissin 9-Geri menuye qayit");
                        string opt=Console.ReadLine();
                        switch (opt)
                        {
                            case "7":
                            Weapon.CapacityChanger(akm);
                                break;
                            case "8":
                                Weapon.NumberChanger(akm);

                                break;
                            case "9":
                               
                                break;
                        }
                        break;
                    default:
                        
                        Console.WriteLine("Duzgun daxil edin");
                        break;

                }
            }
            while (menunav);

        }


    }
}



//Weapon deyə class yaradılır.
//Darağın güllə tutumu, Daraqdakı güllə sayı, atış modu (təkli və ya avtomatik) propertileri verilir.
//Shoot() -  metodu hər çağırıldıqda fire moduna gore ya 1 güllə atır yada avtomatik gulleni bosaldir.(Ekranda bunu bildirir)
//GetRemainBulletCount() - darağın tam dolması üçün lazım olan güllə sayını qaytarır.
//Reload() - darağı yenidən doldurur.
//ChangeFireMode() - Atış modunu dəyişir.
//Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
//0 - İnformasiya almaq üçün
//1 - Shoot metodu üçün
//2 - GetRemainBulletCount metodu üçün
//3 - Reload metodu üçün
//4 - ChangeFireMode metodu üçün
//5 - Proqramdan dayandırmaq üçün
//qısayoldur.