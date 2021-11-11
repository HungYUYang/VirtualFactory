using System;
using System.Collections.Generic;
using FactoryCore;

namespace Maxxis
{
    public class Tire:Task
    {
        public override void Produce()
        {
            var Producer = GetStartProduce();
            Producer.START();
        }

        public virtual IProduce GetStartProduce()
        {
            return new Produce(this);
        }
    }
    
}
