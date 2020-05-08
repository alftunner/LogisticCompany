using System;
using System.Collections.Generic;
using System.Text;

namespace container
{
    public enum transType {regional, federal, international, transcontinental};
    public class Container // Базовый класс от него наследуются остальные
    {
        public double MaxLength { set; get; }
        public double Length { set; get; }
        public double MaxWidth { set; get; }
        public double Width { set; get; }
        public double MaxHeight { set; get; }
        public double Height { set; get; }
        public double MaxWeight { set; get; }
        public double Weight { set; get; }
        public double Price { set; get; }
        public transType[] type;
        public Container()
        {
            
        }
        public double getVolume() // Объём контейнера
        {
            return Height * Length * Width;
        }
        public double getPrice(Cargo cargo) // Узнаём цену перевозки груза
        {
            return cargo.getVolume() * cargo.Way * Price;
        }
        public bool canTransport(Cargo cargo) // Узнаем можно ли перевезти данный груз на данном транспорте
        {
            int counter = 0;
            foreach (var item in type)
            {
                if(item == cargo.type)
                {
                    counter += 1;
                }
            }
            if(counter>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkVolume(Cargo cargo) // Узнаём поместится ли груз с учётом прежнего загруза и типа перевозки
        {
            if((getVolume() - cargo.getVolume()) >= 0 && (Weight - cargo.Weight)>=0 && canTransport(cargo) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void containerPlace(Cargo cargo) // Вычисляем сколько еще осталось места для заполнения в контейнере
        {
            Height -= cargo.Height;
            Length -= cargo.Length;
            Width -= cargo.Width;
            Weight -= cargo.Weight;
        }
        public double Percent() // На сколько процентов заполнен контейнер.
        {
            double v = getVolume();
            double percent =100 - v / (MaxHeight * MaxLength * MaxWidth) * 100;
            return percent;
        }
        public string Reset() // Опустошение контейнера
        {
            Height = MaxHeight;
            Length = MaxLength;
            Width = MaxWidth;
            Weight = MaxWeight;
            return "Контейнер пуст";
        }

    }

    public class AirContainer : Container // класс контейнера для перевозки Самолётом
    {
        public AirContainer()
        {
            MaxLength = 100;
            MaxWidth = 50;
            MaxHeight = 10;
            MaxWeight = 100;
            Price = 10;
            Height = MaxHeight;
            Length = MaxLength;
            Width = MaxWidth;
            Weight = MaxWeight;
            type = new transType[] {transType.regional, transType.federal, transType.international, transType.transcontinental};
        }
    }

    public class SeaContainer : Container // класс контейнера для перевозки Кораблём
    {
        public SeaContainer()
        {
            MaxLength = 200;
            MaxWidth = 100;
            MaxHeight = 20;
            MaxWeight = 200;
            Price = 15;
            Height = MaxHeight;
            Length = MaxLength;
            Width = MaxWidth;
            Weight = MaxWeight;
            type = new transType[] { transType.international, transType.transcontinental };
        }
    }

    public class TrainContainer : Container // класс контейнера для перевозки Поездом
    {
        public TrainContainer()
        {
            MaxLength = 200;
            MaxWidth = 50;
            MaxHeight = 10;
            MaxWeight = 200;
            Price = 5;
            Height = MaxHeight;
            Length = MaxLength;
            Width = MaxWidth;
            Weight = MaxWeight;
            type = new transType[] {transType.federal, transType.international};
        }
    }

    public class WagonContainer : Container // класс контейнера для перевозки Фурой
    {
        public WagonContainer()
        {
            MaxLength = 30;
            MaxWidth = 10;
            MaxHeight = 5;
            MaxWeight = 10;
            Price = 3;
            Height = MaxHeight;
            Length = MaxLength;
            Width = MaxWidth;
            Weight = MaxWeight;
            type = new transType[] { transType.regional, transType.federal, transType.international };
        }
    }

    public class TruckContainer : Container // класс контейнера для перевозки небольшим грузовиком
    {
        public TruckContainer()
        {
            MaxLength = 10;
            MaxWidth = 5;
            MaxHeight = 2;
            MaxWeight = 3;
            Price = 2;
            Height = MaxHeight;
            Length = MaxLength;
            Width = MaxWidth;
            Weight = MaxWeight;
            type = new transType[] { transType.regional, transType.federal};
        }
    }
}
