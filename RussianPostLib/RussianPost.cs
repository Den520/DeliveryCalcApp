using System;

namespace RussianPostLib
{
    public class RussianPost
    {
        public bool CheckAvailability(double length, double width, double height, double weight)
        {
            if (length > 150 || width > 150 || height > 150 || (length + width + height) > 300 || weight > 20) { return false; }
            return true;
        }

        public DateTime GetDate(int stepOfDistance)
        {
            return DateTime.Today.AddDays(stepOfDistance * 5);  //шаг*кол-во дней одного шага
        }

        public double GetPrice(int stepOfDistance, bool fromDoor, bool toDoor, double length, double width, double height, double weight)
        {
            double price = 60 + stepOfDistance * 45;  //начальная стоимость + стоимость от расстояния
            price += (length + width + height) * (price * 0.025) + weight * (price * 0.1);
            if (fromDoor) { price += 50; }
            if (toDoor) { price += 50; }
            return price;
        }
    }
}
