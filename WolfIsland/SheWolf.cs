using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfIsland
{
    internal class SheWolf
    {
            public int X { get; private set; }
            public int Y { get; private set; }
            public int Saturation { get; set; }

            public SheWolf(int x, int y, int saturation)
            {
            //параметри вовчиці. координати та рівень їжі
                X = x;
                Y = y;
                Saturation = saturation;
            }

            public void Move(int x, int y)
            {
            //переміщення
                X = x;
                Y = y;   
            }

        public bool IsHungry(int saturation)
        {
            Saturation = saturation;
            return Saturation <= 0; // перевірка на голод
        }

        public int Eat()
        {
            Saturation = 10;
            return Saturation;//після з'їдення кролика
        }

        public int ReduceSaturation(int saturation)
        {
            Saturation = saturation - 1;//кожен хід знімається очко
            return Saturation;
        }
    }
}
