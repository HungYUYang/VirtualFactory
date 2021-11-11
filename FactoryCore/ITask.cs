using System;
using System.Collections;

namespace FactoryCore
{
    public interface ITask
    {
        string Origin { get;  }
        string Company { get;  }
        string ProductName { get; }
        void Produce();
        Hashtable Hashtable { get; set; }
    }
}
