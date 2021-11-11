using FactoryCore;
namespace BMW
{
    public class Car:Task
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
