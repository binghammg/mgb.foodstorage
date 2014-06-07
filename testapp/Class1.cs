using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testapp.ServiceReference1;

namespace testapp
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            try
            {
                FoodStorageClient client = new FoodStorageClient();
                client.AddItem(123, "Campbells Soup", "123456");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
