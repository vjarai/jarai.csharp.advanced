using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using NorthwindApi;

namespace Jarai.RestApi.ClientApplication
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                var client = new NorthwindClient(httpClient);

                var customer = await client.GetCustomerAsync("ALFKI");
                
                Debug.WriteLine(customer.CompanyName);
            }
        }
    }
}