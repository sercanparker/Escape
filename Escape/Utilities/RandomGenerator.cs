using System;
using Xamarin.Forms;

namespace Escape.Utilities
{
    public class RandomGenerator
    {
        public RandomGenerator()
        {
            
        }

        internal Color GenerateColor()
        {
            int randomIntForColor = new Random().Next(7);
            switch (randomIntForColor)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.Purple;
                case 2:
                    return Color.Pink;
                case 3:
                    return Color.Yellow;
                case 4:
                    return Color.Orange;
                case 5:
                    return Color.Plum;
                case 6:
                    return Color.YellowGreen;
                default:
                    return Color.OrangeRed;
            }

        }

        internal int GenerateGridSize()
        {
            return new Random().Next(3, 8);
        }
    }
}
