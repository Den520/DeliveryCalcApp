using System;

namespace CDEKLib
{
    public class CDEK
    {
        public static bool CheckAvailability(double length, double width, double height, double weight)
        {
            if (length > 150 || width > 150 || height > 150 || weight > 29) { return false; }
            return true;
        }

        public static DateTime GetDate(int stepOfDistance)
        {
            return DateTime.Today.AddDays(stepOfDistance * 4);  //шаг*кол-во дней одного шага
        }

        public static double GetPrice(int stepOfDistance, bool fromDoor, bool toDoor, double length, double width, double height, double weight)
        {
            double price = 50 + stepOfDistance * 50;  //начальная стоимость + стоимость от расстояния
            price += (length + width + height) * (price * 0.02) + weight * (price * 0.2);
            if (fromDoor) { price += 100; }
            if (toDoor) { price += 100; }
            return price;
        }
    }
}
