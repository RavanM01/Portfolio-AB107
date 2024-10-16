namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ravan Maharramli", 20, "+994703202208");
            person.FullNameCheck();
            if (person.FullNameCheck() == true)
            {
                Console.WriteLine("Melumatlar duzgundur");
            }
            else
            {
                Console.WriteLine("datalari dogru daxil edin");
            }
            string string1 = "salam";
            CustomTrim(string1);
            CustomSubString(string1, 1, 3);
            CustomLastIndex(string1, 'n', 0);
            CustomReplace(string1, 'a', 'b');
            CustomContains(string1, "sa");

        }

        public static void CustomTrim(string str)
        {
            string newstr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    newstr += str[i];

                }
            }

            Console.WriteLine(newstr);
        }

        public static void CustomSubString(string str, int start, int len)
        {
            string subst = "";
            for (int i = start; i <= len; i++)
            {
                subst += str[i];
            }
            Console.WriteLine(subst);

        }

        public static void CustomLastIndex(string str, char symbol, int start)
        {
            for (int i = str.Length - 1; i >= start; i--)
            {
                if (str[i] == symbol)
                {
                    Console.WriteLine($"simvol tapildi:indexi {i}");
                }
                else
                {
                    Console.WriteLine("tapilmadi");
                }

            }

        }

        public static void CustomReplace(string str, char oldstr, char newstr)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == oldstr)
                {

                    newStr += newstr;
                }
                else
                {
                    newStr += str[i];
                }
            }
            Console.WriteLine("Replaced: " + newStr);
        }

        public static void CustomContains(string str, string cont)
        {
            bool result = false;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < cont.Length; j++)
                {
                    if (str[i] == cont[j])
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                }

            }
            Console.WriteLine(result);

        }

    }
}
