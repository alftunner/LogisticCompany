using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;

namespace container
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargo cargo = new Cargo();
            Dictionary<double, string> options = new Dictionary<double, string>(); 

        AirContainer air = new AirContainer();
            SeaContainer sea = new SeaContainer();
            TrainContainer train = new TrainContainer();
            WagonContainer wagon = new WagonContainer();
            TruckContainer truck = new TruckContainer();

            OperationConsole.inputCargo(cargo);
            OperationConsole.showCargo(cargo);

            OperationConsole.selectContainer(cargo, air, options);
            OperationConsole.selectContainer(cargo, sea, options);
            OperationConsole.selectContainer(cargo, train, options);
            OperationConsole.selectContainer(cargo, wagon, options);
            OperationConsole.selectContainer(cargo, truck, options);

            double min = air.getPrice(cargo);
            string str = "";

            foreach (var item in options)
            {
                if(item.Key < min)
                {
                    min = item.Key;
                    str = item.Value;
                }
            }
            WriteLine("-------------------------------");
            WriteLine($"Мы рекомендуем воспользоваться {str}");
            

            
            



        }
    }
}
