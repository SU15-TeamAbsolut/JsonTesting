using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTesting.Models;
using Newtonsoft.Json;
using NJsonSchema;
using NJsonSchema.Validation;
using System.IO;

namespace JsonTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateObject();
            //ValidateFromFile("order.json");
        }

        private static void ValidateObject()
        {
            // Make an order object
            var order = new JsonOrder
            {
                CustomerId = -1,
                DeliveryAddressId = 147,
                DeliveryDate = DateTime.UtcNow.AddDays(5),
                OrderRows = new[]
                {
                    new JsonOrderRow {ArticleId = 15626, Amount = 28},
                    new JsonOrderRow {ArticleId = 25626, Amount = 10},
                    new JsonOrderRow {ArticleId = 23577, Amount = 150},
                }
            };

            string orderJson = JsonConvert.SerializeObject(order);

            // Validate order JSON
            ValidateJsonOrder(orderJson);
        }

        private static void ValidateFromFile(string fileName)
        {
            string file = File.ReadAllText(fileName);
            ValidateJsonOrder(file);
        }

        private static void ValidateJsonOrder(string orderJson)
        {
            var schema = JsonSchema4.FromType<JsonOrder>();
            var errors = schema.Validate(orderJson);

            Console.WriteLine($"{errors.Count} validation errors found");
            foreach (ValidationError error in errors)
            {
                Console.WriteLine($"{error.Path}: {error.Kind}");
            }

            Console.WriteLine("Order as JSON:");
            Console.WriteLine(orderJson);
        }
    }
}
