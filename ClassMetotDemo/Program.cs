namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.Id = 46;
            customer.FirstName = "Ali";
            customer.LastName = "Galender";

            CustomerManager customer1 = new CustomerManager();
            customer1.Add(customer);



        }
    }
}