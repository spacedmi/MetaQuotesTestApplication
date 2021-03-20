using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaQuotes.TestApplication.Data
{
    public class DataStorage : IDataStorage, IStartable
    {
        public DataStorage()
        {
            // TODO
        }

        public void Start()
        {
            Console.WriteLine("App is starting up!");
        }
    }
}
