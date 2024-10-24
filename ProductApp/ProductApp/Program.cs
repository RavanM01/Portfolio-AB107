namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product("Corek",0.5,Type.Baker);
            Product product2= new Product("Cola",1.2,Type.Drink);
            Product product3= new Product("Dana",22,Type.Meat);
            Store store = new Store();
            store.AddProduct(product1);
            store.AddProduct(product2);
            store.AddProduct(product3);
            store.GetProduct(1);
        }
    }
}
