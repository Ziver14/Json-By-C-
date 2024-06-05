using Newtonsoft.Json;

namespace Json_By_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var store = new Store();
            store.AddProduct(new Product { Id = 1, Name = "Laptop", Price = 1000m });
            store.AddProduct(new Product { Id = 2, Name = "Phone", Price = 500m });
            store.AddProduct(new Product { Id = 3, Name = "TV", Price = 1500m });
            store.AddProduct(new Product { Id = 4, Name = "Phone", Price = 2000m });

            var order = new CustomerOrder
            {
                CustomerName = "Vlad",
                CustomerAddress = "123 Lenina St",
                CustomerPhone = "555-444-333"
            };

            var laptop = store.FindProductByName("Laptop").FirstOrDefault();
            var phone = store.FindProductByName("Phone").FirstOrDefault();
            if (laptop.Id != 0) order.AddProduct(laptop, 1);
            if (phone.Id != 0) order.AddProduct(phone, 2);

            store.AddOrder(order);

            Console.WriteLine(JsonHelper.SerializeObject(order));
            JsonHelper.SaveToFile<Order>("order.json",order);
            var loadedOrder = JsonHelper.LoadFromFile<CustomerOrder>("order.json");
            Console.WriteLine("\nLoadOrder");
            Console.WriteLine("Customer: " + loadedOrder.CustomerName);
            Console.WriteLine("Total Price " + loadedOrder.GetTotalPrice());

            var customerOrders = store.GetOrdersByCustumerName("Vlad");
            Console.WriteLine("\nOrders for Vlad");
            foreach(var customerOrder in customerOrders) 
            {
                Console.WriteLine("Order Total: " + customerOrder.GetTotalPrice());
            }
        }
    }
}
