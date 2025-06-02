using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Client
    {
        GenericClass<string> g1 = new GenericClass<string>();
        GenericClass<int> g2 = new GenericClass<int>();
        ConcreteClass c = new ConcreteClass(); // We stopped Generic at interface level so no need to specify it over here

        public void Run()
        {
            GenericClass g3 = new GenericClass();

            var result = g3.GenericFunction(123);

            g3.GenericMethod("test");

            var testDog1 = new Dog(25, 45);
            var testDog2 = new Dog(35, 65);
            var testCat1 = new Cat(15, 30, true);
            var testCat2 = new Cat(20, 40, false);
            var testFish1 = new GoldFish(5, 15);
            var testFish2 = new GoldFish(8, 12);

            IAnimal[] animals = [testDog1, testDog2, testCat1, testCat2, testFish1, testFish2];

            Calculate<IAnimal> calculate = new();

            var totalHeight = calculate.GetHeight(animals);
            var totalWeight = calculate.GetWeight(animals);
            var animalsWithFur = calculate.FurAnimals(animals);

            Console.WriteLine($"Animals total height is {totalHeight}");
            Console.WriteLine($"Animals total weight is {totalWeight}");

            Console.WriteLine($"Total animals with Fur is {animalsWithFur.Count()}");

            //Can also pass only single type

            var testCat3 = new Cat(15, 30, true);
            var testCat4 = new Cat(20, 40, false);

            IAnimal[] onlyCats = [testCat3, testCat4];


            var totalCatsHeight = calculate.GetHeight(onlyCats);
            var totalCatsWeight = calculate.GetWeight(onlyCats);
            var animalsCatsWithFur = calculate.FurAnimals(onlyCats);

            Console.WriteLine($"Cats total height is {totalCatsHeight}");
            Console.WriteLine($"Cats total weight is {totalCatsWeight}");



        }
    }
}
