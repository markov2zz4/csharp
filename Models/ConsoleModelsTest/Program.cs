using Models;
using Models.DataProviders.DataTest;
using Models.Entities;
using System;

namespace ConsoleModelsTest
{
    class Program
    {
        static readonly DataManager data = new DataManager(new RecordRep());

        static void Main(string[] args)
        {
            
            Console.WriteLine(data.Records.Items.Length == 4);
            Guid id = Guid.NewGuid();


            var masha = new Record() { Id = id, Name = "Masha", Number = 0 };
            data.Records.Update(masha);
            Console.WriteLine(data.Records.Items[data.Records.Items.Length - 1] == masha);


        }
    }
}
