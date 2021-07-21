using System;

namespace DelegatesDemo
{
    public delegate void Calculate(int length, int width);
    public class MultiCastDelegateClass
    {
        public void Area(int length, int widith)
        {
            Console.WriteLine("Area :" + length * widith);
        }

        public void Perimeter(int length, int widith)
        {
            Console.WriteLine("Perimeter : " + 2 * (length + widith));
        }
    }
}
