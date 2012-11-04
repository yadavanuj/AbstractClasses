using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple fruit = new Apple();
            fruit.Print();
            //IContract contract = (IContract) fruit; //Invalid cast exception

            IContract contract =  fruit as IContract;
            if(contract != null)
                contract.Display();
            Console.ReadLine();
        }
    }

    internal interface IContract
    {
        void Display();
    }
    #region
    internal abstract class Fruit
    {
        public abstract string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("from abstract class");
        }
    }

    internal sealed class Apple: Fruit
    {
        public override string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("from child");
        }
    }
    #endregion
}
