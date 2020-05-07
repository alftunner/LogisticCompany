using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace container
{
    public class OperationConsole
    {
        public static void inputCargo(Cargo cargo) // метод для ввода свойств груза с клавиатуры
        {
            Write("Введите длину груза: ");
            cargo.Length = Convert.ToInt32(ReadLine());
            Write("Введите ширину груза: ");
            cargo.Width = Convert.ToInt32(ReadLine());
            Write("Введите высоту груза: ");
            cargo.Height = Convert.ToInt32(ReadLine());
            Write("Введите вес груза: ");
            cargo.Weight = Convert.ToInt32(ReadLine());
            Write("Введите расстояние перевозки: ");
            cargo.Way = Convert.ToInt32(ReadLine());
            selectCargoType(cargo);
        }

        public static void selectCargoType(Cargo cargo) // метод который определяет тип груза
        {
            WriteLine("Нажмите 1 если тип груза - РЕГИОНАЛЬНЫЙ: ");
            WriteLine("Нажмите 2 если тип груза - ФЕДЕРАЛЬНЫЙ: ");
            WriteLine("Нажмите 3 если тип груза - МЕЖДУНАРОДНЫЙ: ");
            WriteLine("Нажмите 4 если тип груза - ТРАНСКОНТИНЕНТАЛЬНЫЙ: ");
            Write("Выберите тип груза: ");
            int temp = Convert.ToInt32(ReadLine());
            switch (temp)
            {
                case 1:
                    cargo.type = transType.regional;
                    break;
                case 2:
                    cargo.type = transType.federal;
                    break;
                case 3:
                    cargo.type = transType.international;
                    break;
                case 4:
                    cargo.type = transType.transcontinental;
                    break;
                default:
                    WriteLine("Просьба быть внимательнее и выбрать один из предложенный выриантов.");
                    selectCargoType(cargo);
                    break;

            }
        }

        public static void showCargo(Cargo cargo) // Метод, который выводит на экран информацию о грузе.
        {
            WriteLine($"Длина груза - {cargo.Length}");
            WriteLine($"Ширина груза - {cargo.Width}");
            WriteLine($"Высота груза - {cargo.Height}");
            WriteLine($"Вес груза - {cargo.Weight}");
            WriteLine($"Объём груза - {cargo.getVolume()}");
        }

        public static void selectContainer(Cargo cargo, AirContainer air) // Метод который даёт полную информацию о совместимости груза и контейнера, если всё ок, то в массив с успешными вариантами
        {
            if (air.checkVolume(cargo))
            {
                WriteLine("Для Вашего груза доступна авиаперевозка");
                air.containerPlace(cargo);
                WriteLine($"С учётом Вашего груза контейнер загружен на {air.Percent()}%"); 
                WriteLine($"Стоимость перевозки составит - {air.getPrice(cargo)}");
                WriteLine("-------------------------");
                double temp = air.getPrice(cargo) / air.Percent(); // коэффициент оптимального выбора контейнера исходя из стоимости и загруженности
                
            }
            else
            {
                WriteLine("Авиаперевозка не доступна");
                WriteLine("--------------------------");
            }
        }

        public static void selectContainer(Cargo cargo, SeaContainer sea)
        {
            if (sea.checkVolume(cargo))
            {
                WriteLine("Для Вашего груза доступна перевозка по морю");
                sea.containerPlace(cargo);
                WriteLine($"С учётом Вашего груза контейнер загружен на {sea.Percent()}%");
                WriteLine($"Стоимость перевозки составит - {sea.getPrice(cargo)}");
                WriteLine("-------------------------");
                double temp = sea.getPrice(cargo) / sea.Percent(); // коэффициент оптимального выбора контейнера исходя из стоимости и загруженности
                
            }
            else
            {
                WriteLine("Перевозка по морю не доступна");
                WriteLine("--------------------------");
            }
        }

        public static void selectContainer(Cargo cargo, TrainContainer train)
        {
            if (train.checkVolume(cargo))
            {
                WriteLine("Для Вашего груза доступна перевозка поездом");
                train.containerPlace(cargo);
                WriteLine($"С учётом Вашего груза контейнер загружен на {train.Percent()}%");
                WriteLine($"Стоимость перевозки составит - {train.getPrice(cargo)}");
                WriteLine("-------------------------");
                double temp = train.getPrice(cargo) / train.Percent(); // коэффициент оптимального выбора контейнера исходя из стоимости и загруженности
                
            }
            else
            {
                WriteLine("Перевозка поездом не доступна");
                WriteLine("--------------------------");
            }
        }

        public static void selectContainer(Cargo cargo, WagonContainer wagon)
        {
            if (wagon.checkVolume(cargo))
            {
                WriteLine("Для Вашего груза доступна перевозка в фуре");
                wagon.containerPlace(cargo);
                WriteLine($"С учётом Вашего груза контейнер загружен на {wagon.Percent()}%");
                WriteLine($"Стоимость перевозки составит - {wagon.getPrice(cargo)}");
                WriteLine("-------------------------");
                double temp = wagon.getPrice(cargo) / wagon.Percent(); // коэффициент оптимального выбора контейнера исходя из стоимости и загруженности
                
            }
            else
            {
                WriteLine("Перевозка фурой не доступна");
                WriteLine("--------------------------");
            }
        }

        public static void selectContainer(Cargo cargo, TruckContainer truck)
        {
            if (truck.checkVolume(cargo))
            {
                WriteLine("Для Вашего груза доступна перевозка в небольшом грузовичке");
                truck.containerPlace(cargo);
                WriteLine($"С учётом Вашего груза контейнер загружен на {truck.Percent()}%");
                WriteLine($"Стоимость перевозки составит - {truck.getPrice(cargo)}");
                WriteLine("-------------------------");
                double temp = truck.getPrice(cargo) / truck.Percent(); // коэффициент оптимального выбора контейнера исходя из стоимости и загруженности
                
            }
            else
            {
                WriteLine("Перевозка в грузовичке не доступна");
                WriteLine("--------------------------");
            }
        }


    }
}
