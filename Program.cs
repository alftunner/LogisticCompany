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
            

        AirContainer air = new AirContainer();
            SeaContainer sea = new SeaContainer();
            TrainContainer train = new TrainContainer();
            WagonContainer wagon = new WagonContainer();
            TruckContainer truck = new TruckContainer();

            OperationConsole.inputCargo(cargo);
            OperationConsole.showCargo(cargo);

            OperationConsole.selectContainer(cargo, air);
            OperationConsole.selectContainer(cargo, sea);
            OperationConsole.selectContainer(cargo, train);
            OperationConsole.selectContainer(cargo, wagon);
            OperationConsole.selectContainer(cargo, truck);

            
            



        }
    }
}
