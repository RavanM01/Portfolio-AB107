namespace StringFormatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string helo = "Hello, Wo rl d!";
            BigLetter(helo);
            TextFormatter(helo);
        }
        static void BigLetter(string text)
        {
            string Bigchar = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (" " == text[i].ToString())
                {
                    Bigchar += text[i + 1]+" ";
                }
            }
            Console.WriteLine(Bigchar);

        }

        static void TextFormatter(string text)
        {
            string chars = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (" " != text[i].ToString())
                {
                    chars += text[i].ToString();
                }
            }
            Console.WriteLine(chars);
        }

    }
}