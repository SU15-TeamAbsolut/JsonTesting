using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonTesting.Models;
using NJsonSchema;

namespace JsonTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = JsonSchema4.FromType<Order>();
            var schemaData = schema.ToJson();

            Console.WriteLine(schemaData);
        }
    }
}
