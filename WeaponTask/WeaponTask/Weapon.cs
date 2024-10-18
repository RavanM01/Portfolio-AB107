using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponTask
{
    internal class Weapon
    {
        private int _bulletcapacity;
        private int _numberofbullet;
        private bool _shootmode;

        public Weapon(int bulletcapacity, int numberofbullet, bool shootmode)
        {
            Bulletcapacity = bulletcapacity;
            Numberofbullet = numberofbullet;
            Shootmode = shootmode;
        }

        public int Bulletcapacity { get { return _bulletcapacity; } set { if (value >= _numberofbullet) { _bulletcapacity=value; } } }
        public int Numberofbullet { get { return _numberofbullet; } set { if (value <= _bulletcapacity) { _numberofbullet = value; } } }
        public bool Shootmode { get { return _shootmode; } set { _shootmode=value; } }

        public static void Shoot(Weapon weapon)
        {

            if (weapon.Shootmode == true)
            {
                weapon.Numberofbullet -= weapon.Numberofbullet;
                Console.WriteLine(weapon._numberofbullet);
            }
            else
            {
                weapon.Numberofbullet -= 1;
                Console.WriteLine(weapon.Numberofbullet);


            }
        }

        public static void GetRemainBulletCount(Weapon weapon)
        {
            int remain = weapon.Bulletcapacity - weapon.Numberofbullet;
        }
        public static void Reload(Weapon weapon)
        {
            weapon.Numberofbullet = weapon.Bulletcapacity;
        }
        public static void ChangeFireMode(Weapon weapon)
        {
            if (!weapon.Shootmode)
            {
                weapon.Shootmode = true;
            }
            else
            {
                weapon.Shootmode = false;
            }
        }
        public static void CapacityChanger(Weapon weapon)
        {
            int newcapacity=int.Parse( Console.ReadLine());
            weapon.Bulletcapacity = newcapacity;
            Console.WriteLine(weapon.Bulletcapacity);
        }
        public static void NumberChanger(Weapon weapon)
        {
            int newnumber = int.Parse(Console.ReadLine());
            weapon.Numberofbullet = newnumber;
            Console.WriteLine(weapon.Numberofbullet);
        }


    }
}
