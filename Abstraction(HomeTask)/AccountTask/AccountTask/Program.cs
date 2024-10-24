namespace AccountTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Ravan Maharram","revanwro@gmail.com","Revan123");
            User user2 = new User("Ravan Maharram","revanwro@gmail.com","Revan123");
            User user3 = new User("Ravan Maharram","revanwro@gmail.com","Revan123");
            User user4 = new User("Ravan Maharram","revanwro@gmail.com","Revan123");
            

            Console.WriteLine(user1.PasswordChecker(user1.Password));
            user1.ShowInfo(user1);
            user1.ShowInfo(user2);
            user3.ShowInfo(user3);
            user4.ShowInfo(user4);
        }
    }
}
