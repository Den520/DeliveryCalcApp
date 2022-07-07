using System;

namespace BoxberryLib
{
    public class Boxberry
    {
        public bool CheckAvailability(double length, double width, double height, double weight)
        {
            if (length > 120 || width > 80 || height > 50 || (length + width + height) > 250 || weight > 15) { return false; }
            return true;
        }

        public DateTime GetDate(int stepOfDistance)
        {
            return DateTime.Today.AddDays(stepOfDistance * 3);  //шаг*кол-во дней одного шага
        }

        public double GetPrice(int stepOfDistance, bool fromDoor, bool toDoor, double length, double width, double height, double weight)
        {
            double price = 40 + stepOfDistance * 45;  //начальная стоимость + стоимость от расстояния
            price += (length + width + height) * (price * 0.02) + weight * (price * 0.1);
            if (fromDoor) { price += 50; }
            if (toDoor) { price += 50; }
            return price;
        }
    }
}
