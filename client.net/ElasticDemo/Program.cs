using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace ElasticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Uri("http://10.0.75.1:9200");

            var settings = new ConnectionSettings(
                node
            );


            settings.DefaultIndex("default_index");

            var client = new ElasticClient(settings);



            for (int i = 0; i < 100; i++)
            {
                var person = new Person
                {
                    Id = Guid.NewGuid().ToString(),
                    Firstname = "Onur " + i,
                    Lastname = "Durmuş",
                    GroupIndex = i % 10
                };

                var createResponse = client.Create(person);
            }

        }

    }


}
