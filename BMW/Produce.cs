using System;
using FactoryCore;

namespace BMW
{
    public class Produce : IProduce
    {
        ITask task;
        public Produce(ITask task)
        {
            try {
                this.task = task;
            }
            catch {
                throw;
            }
        }
        public void START()
        {
            string Company = task.Hashtable["Company"].ToString();
            string ProductName = task.Hashtable["ProductName"].ToString();
            string ProduceDateTime = DateTime.Now.ToString();
            Console.WriteLine("{0} produce the {1} in {2}", Company, ProductName, ProduceDateTime);
        }
    }
}
