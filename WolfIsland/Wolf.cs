using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfIsland
{
    public class Wolf
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Saturation { get; set; }

        public Wolf(int x, int y, int saturation)
        {
            //параметри вовка. координати та рівень їжі
            X = x;
            Y = y;
            Saturation = saturation;
        }

        public void Move(int newX, int newY)
        {
            //переміщення
            X = newX;
            Y = newY;
        }

        public bool IsHungry(int saturation)
        {
            Saturation = saturation;
            return Saturation <= 0; // перевірка на голод
        }

        public int Eat()
        {
            Saturation = 10;//після з'їдення кролика
            return Saturation;
        }

        public int ReduceSaturation(int saturation)
        {
            Saturation = saturation - 1;//кожен хід знімається очко
            return Saturation;
        }

        public int Sex()
        {
            Saturation = 5;//після розмноження рівень їжі падає до 5
            return Saturation;
        }
    }
}