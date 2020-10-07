using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var httpClient = new HttpClient();
            var swaggerClient = new swaggerClient("http://localhost:17225/", httpClient);

            var getCustomerList = await swaggerClient?.GetcustomerAsync();

            foreach (CustomerModel customerModel in getCustomerList)
            {
                Console.WriteLine(customerModel.FullName);
            }

            var flag = await swaggerClient?.AddAsync(new CustomerModel()
            {
                FullName = "Kishor Naik",
                EmailId = "kishor.naik011.net@gmail.com",
                MobileNo = "9111111111"
            });

            Console.WriteLine(flag);
        }
    }
}