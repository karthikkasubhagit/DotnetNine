namespace Generics
{
    public interface IGenericClass<T>
    {

    }

    public class ConcreteClass : IGenericClass<int>
    {

    }
    public class GenericClass<T>
    {

    }

    public class GenericClass
    {
        public void GenericMethod<T>(T value)
        {
            Console.WriteLine($"This is of type {value.GetType()}");
            Console.WriteLine($"and the value is {value}");
        }

        public T GenericFunction<T>(T value)
        {
            Console.WriteLine($"This is of type {value.GetType()}");
            Console.WriteLine($"and the value is {value}");
            return value;
        }

        public int GenericFunction2<T>(T value)
        {
            Console.WriteLine($"This is of type {value.GetType()}");
            Console.WriteLine($"and the value is {value}");
            return 1234;
        }
    }
}
