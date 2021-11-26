using System;
using Car_Composite.Units;
using Car_Composite.Components;

namespace Car_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1, 1);
            Total result = new Total();
            result = car.Info(result, car.Quantity);

            Console.WriteLine("Общее кол-во деталей: " + result.TotalQuantity);
            Console.WriteLine("Общий вес Автомобиля: " + result.TotalWeight);
        }
    }
}
