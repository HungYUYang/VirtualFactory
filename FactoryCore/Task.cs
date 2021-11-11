using System;
using System.Collections;

namespace FactoryCore
{
    public abstract class Task : ITask
    {
        public Task()
        {
            this._hashtable = new Hashtable();
        }
        public string Origin { get; set; }
        public string Company { get; set; }
        public string ProductName { get; set; }
        public abstract void Produce();

        Hashtable _hashtable;

        public Hashtable Hashtable {
            get {
                return _hashtable;
            }
            set {
                if (_hashtable == null) {
                    _hashtable = value;
                }
            }
        }
    }
}
