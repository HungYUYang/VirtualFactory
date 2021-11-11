using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryCore
{
    public class FactoryCould
    {
        public string Origin { get; set; }
        public string Company { get; set; }
        public string ProductName { get; set; }

        public void StartProduce()
        {

            string dllpath = Origin;

            Assembly oa = Assembly.LoadFile(dllpath + Company + ".dll");
            Type t = oa.GetType(Company + "." + ProductName);
            var task = (Task)Activator.CreateInstance(t);
            task.Hashtable.Add("Origin", Origin);
            task.Hashtable.Add("Company", Company);
            task.Hashtable.Add("ProductName", ProductName);
            task.Produce();

        }

    }
}
